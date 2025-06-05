using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Producto : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Producto [Id: {Id}, Name: {Name}, Price: {Price:C}, Stock: {Stock}]";
        }

    }
}
