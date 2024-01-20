using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class FileWork
    {
        public string CreateNewFile()
        {
            Console.Write($"Name your new file (e.g. MyJournal)");
            string _newJournalName = Console.ReadLine();
            return _newJournalName;
        }

        public List<string> GetJournalNames()
        {
            // Get the current folder
            string folder = Environment.CurrentDirectory;
            // only get the .txt files
            string[] files = Directory.GetFiles(folder, "*.txt");

            // Create a list to store file names
            List<string> fileNames = new List<string>();
            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                fileNames.Add(fileName);
            }

            return fileNames;
        }
    }
}