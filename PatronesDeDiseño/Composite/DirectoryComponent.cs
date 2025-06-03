using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class DirectoryComponent
    {
        public string Name { get; set; }

        protected DirectoryComponent(string name) 
        {
            this.Name = name;
        }

        public abstract void Display(int depth);

        public virtual void Add(DirectoryComponent component)
        {
            throw new NotImplementedException("This method is not implemented for this component.");
        }

        public virtual void Remove(DirectoryComponent component)
        {
            throw new NotImplementedException("This method is not implemented for this component.");
        }

        public abstract long GetSize();
    }
}
