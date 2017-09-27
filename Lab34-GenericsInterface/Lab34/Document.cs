using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    class Document : IDocument
    {
        public string Title { get; set; } 
        public string Author { get; set; }  

        public Document()
        {

        }

        public Document(string title, string author)
        {
            Author = author;
            Title = title;
          }

      
    }
}
