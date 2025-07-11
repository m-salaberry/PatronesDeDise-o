using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEjemplo2
{
    public class TortaComposite : Component
    {
        private List<Component> ingredientes = new List<Component>();
        public void Add(Component _elemento)
        {
            ingredientes.Add(_elemento);
        }

        public void Remove(Component _elemento)
        {
            ingredientes.Remove(_elemento);
        }

        public List<Ingrediente> GetIngredientes()
        {
            List<Ingrediente> ings = new List<Ingrediente>();
            foreach (var item in ingredientes)
            {
                if (item is Ingrediente ingrediente)
                {
                    ings.Add(ingrediente);
                }
                else
                {
                    Ingrediente ingredienteCompuesto = new Ingrediente(item.Nombre, ((TortaComposite)item).CostoTotal, 1, "unidad");
                    ings.Add(ingredienteCompuesto);
                }
            }

            return ings;
        }

        public double CostoTotal
        {
            get
            {
                double costoTotal = 0;
                foreach (var item in ingredientes)
                {
                    if (item is TortaComposite)
                    {
                        costoTotal += ((TortaComposite)item).CostoTotal; // Obtiene el costo total de la torta compuesta que componen a mi nueva torta
                    }
                    else if (item is Ingrediente)
                    {
                        costoTotal += item.Costo;
                    }
                }
                return costoTotal;
            }
        }
        public TortaComposite(string nombre, double costo=0) : base(nombre, costo)
        {
        }
    }
}
