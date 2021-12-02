using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2021
{
    public static class Util
    {
        public static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static int CalculateIncreases(List<string> list)
        {
            int count = 0;

            foreach (var item in list)
            {
                if (item.Contains("increased"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
