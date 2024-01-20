using System;
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProperties fileProperties = new FileProperties();
            
            List<string> fileNames = fileProperties.GetJournalNames();
            foreach (string fileName in fileNames)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
