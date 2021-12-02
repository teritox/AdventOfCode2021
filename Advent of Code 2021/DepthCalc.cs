using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2021
{
    public class DepthCalc
    {
        public void AmountOfIncreases()
        {
            List<string> measurements = FileReader.GetMeasurements();
            string[] calculationArray = measurements.ToArray();


            for (int i = 0; i < calculationArray.Length; i++)
            {
                if (i == 0)
                {
                    measurements[i] += " (N/A - no previous measurement)";
                }
                else if (i > 0)
                {
                    int current = Convert.ToInt32(calculationArray[i]);
                    int lastInt = i - 1;
                    int last = Convert.ToInt32(calculationArray[i - 1]);

                    if (current > last)
                    {
                        measurements[i] += " (increased)";
                    }
                    else
                    {
                        measurements[i] += " (decreased)";
                    }
                }
            }

            Util.PrintList(measurements);

            int countOfIncreases = Util.CalculateIncreases(measurements);    

            Console.WriteLine("Times depth was increased " + countOfIncreases);

        }


    }
}

