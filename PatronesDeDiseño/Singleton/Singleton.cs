using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {

        private Singleton() { }

        public string name { get; set; }

        private static Singleton _instance;

        private Singleton(string name)
        {
            this.name = name;
        }

        public static Singleton GetIntance(string name)
        {
            if(_instance == null)
            {
                _instance = new Singleton(name);
            }
            return _instance;
        }

        

    }
}
