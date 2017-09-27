using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    class DocumentManager<TDocument>  where TDocument : IDocument
    {
    
       private readonly Queue<IDocument> documentQueue = new Queue<IDocument>();

        public bool IsDocumentAvailable
        {
            get
            {
               if (documentQueue.Count > 0)
                {
                }
                return IsDocumentAvailable;
            }
          
        }

        public void addDocument(IDocument doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public TDocument getDocument()
        {
            TDocument doc = default(TDocument);

            lock (this)
            {
                documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in documentQueue)
            {
                Console.WriteLine($"{doc.Title}");
            }
        }

    }

}
