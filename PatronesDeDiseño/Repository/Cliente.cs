using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Cliente : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Edad {  get; set; }

        public override string ToString()
        {
            return $"Cliente [Id: {Id}, Name: {Name}, Edad: {Edad}]";
        }

    }
}
