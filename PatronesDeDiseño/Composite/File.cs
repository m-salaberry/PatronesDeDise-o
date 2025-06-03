using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class File : DirectoryComponent
    {
        public long Size { get; set; }

        public File(string name, long size) : base(name)
        {
            this.Size = size;
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string(' ', depth)}File: {Name}, Size: {Size} bytes");
        }

        public override long GetSize()
        {
            return Size;
        }
    }
}
