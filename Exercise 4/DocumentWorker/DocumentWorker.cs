using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4.DocumentWorker
{
     internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версii Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версii Про");
        }
        public void Show()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }
    }
}
