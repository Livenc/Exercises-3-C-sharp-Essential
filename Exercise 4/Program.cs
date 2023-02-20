using Exercise_4.DocumentWorker;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker.DocumentWorker documentWorker = null;
            Console.WriteLine("input code");
            string key = Console.ReadLine();
            if(key == "")
            {
                 documentWorker = new DocumentWorker.DocumentWorker();
            }else if(key == "pro")
            {
                 documentWorker = new ProDocumentWorker();
            }
            else if(key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            documentWorker.Show();
            Console.ReadKey();
        }
    }
}