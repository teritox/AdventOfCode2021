using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2021
{
    public static class FileReader
    {
        private static List<string> RawList = new();
        public static void ReadSonarMeasurements()
        {
            StreamReader streamReader = new StreamReader("SonarDepth.txt");

            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                line.Trim();
                RawList.Add(line);
            }
        }

        public static List<string> GetMeasurements()
        {
            return RawList;
        }
    }
}
