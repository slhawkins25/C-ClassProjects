using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager<Document> documentManager = new DocumentManager<Document>();

           documentManager.addDocument(new Document("A portrait of the Artist as a Young Man "," "));
           documentManager.addDocument(new Document("A Tale of Two Cities", " "));
           documentManager.addDocument(new Document("Nature Girl", " "));
           documentManager.addDocument(new Document("Hammerhead Ranch Motel", " "));
           documentManager.addDocument(new Document("A Heartbreaking Work of Staggering Genius", " "));
           documentManager.addDocument(new Document("A Heartbreaking Work of Staggering Genius", " "));

            documentManager.DisplayAllDocuments();

        }
    }
}
