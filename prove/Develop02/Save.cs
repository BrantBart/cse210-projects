using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Save
    {
        public void SaveToFile(List<string> entries)
        {
            string filePath = "test.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (string line in entries)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}