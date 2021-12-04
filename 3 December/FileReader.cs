using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_December
{
    public static class FileReader
    {
        public static List<string> ReadInTextFile()
        {
            List<string> binaryNumbers = new List<string>();

            StreamReader reader = new StreamReader("Binaries.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                binaryNumbers.Add(line);    
            }
            return binaryNumbers;
        }

    }
}
