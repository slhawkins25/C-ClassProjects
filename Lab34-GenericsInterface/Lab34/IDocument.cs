using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    interface IDocument
    {
         string Title { get; set; }
         string Author { get; }
    }
}
