using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Folder: DirectoryComponent
    {

        private List<DirectoryComponent> _components = new List<DirectoryComponent>();

        public Folder(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string(' ', depth)}Folder: {Name}");
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }

        public override void Add(DirectoryComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(DirectoryComponent component)
        {
            _components.Remove(component);
        }

        public override long GetSize()
        {
            long totalSize = 0;
            foreach (var component in _components)
            {
                totalSize += component.GetSize();
            }
            return totalSize;
        }

    }
}
