using CompositeEjemplo2;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component Harina = new Ingrediente("Harina", 900, 1, "kg");
            Component Leche = new Ingrediente("Leche", 2000, 1, "L");
            Component Huevos = new Ingrediente("Leche", 2500, 1, "Docena");
            Component Chocolate = new Ingrediente("Chocolate", 5000, 1, "kg");

            TortaComposite torta = new TortaComposite("Torta de chocolate");

            torta.Add(Harina);
            torta.Add(Leche);
            torta.Add(Huevos);
            torta.Add(Chocolate);

            Console.WriteLine($"Torta: {torta.Nombre}");
            Console.WriteLine($"Costo Total: {torta.CostoTotal} ARS");
            Console.WriteLine("Ingredientes:");
            foreach (var component in torta.GetIngredientes())
            {
                Console.WriteLine($"- {component.Nombre}: {component.Cantidad } {component.Unidad} a {component.Costo} ARS");
            }
            Console.ReadKey();
            Console.Clear();

            Component Glaseado = new Ingrediente("Glaseado", 1500, 500, "gr");

            TortaComposite tortaCompuesta = new TortaComposite("Torta de chocolate con glaseado");

            tortaCompuesta.Add(torta);
            tortaCompuesta.Add(Glaseado);

            Console.WriteLine($"Torta Compuesta: {tortaCompuesta.Nombre}");
            Console.WriteLine($"Costo Total: {tortaCompuesta.CostoTotal} ARS");
            Console.WriteLine("Ingredientes:");
            foreach (var component in tortaCompuesta.GetIngredientes())
            {
                Console.WriteLine($"- {component.Nombre}: {component.Cantidad} {component.Unidad} a {component.Costo} ARS");
            }
            Console.ReadKey();
        }
    }
}