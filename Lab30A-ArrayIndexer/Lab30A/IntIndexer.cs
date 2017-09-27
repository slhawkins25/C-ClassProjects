using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30A
{
    class IntIndexer: Layout
    {
        int Size { get; set; }

        public IntIndexer()
        {

        }

        public IntIndexer(int size)
        {
            Size = size;
            for (int i = 0; i < size; i++)
            nameArray[i] = "Empty";
        }
    }
}
