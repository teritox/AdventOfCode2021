using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2021
{
    public class ThreeSlidingCalc
    {
        public void AmountOfIncreases()
        {
            List<string> measurements = FileReader.GetMeasurements();
            string[] calculationArray = measurements.ToArray();

            for (int i = 0; i < calculationArray.Length - 2; i++)
            {
                int sum = Convert.ToInt32(calculationArray[i]) + Convert.ToInt32(calculationArray[i + 1]) + Convert.ToInt32(calculationArray[i + 2]);

                if (i == 0)
                {
                    measurements.Add(sum + " (N/A - no previous change sum)");
                }
                else
                {
                    int lastSum = Convert.ToInt32(calculationArray[i - 1]) + Convert.ToInt32(calculationArray[i]) + Convert.ToInt32(calculationArray[i + 1]);


                    if (sum > lastSum)
                    {
                        measurements.Add(sum + " (increased)");
                    }
                    else if (lastSum > sum)
                    {
                        measurements.Add(sum + " (decreased)");
                    }
                    else if (sum == lastSum)
                    {
                        measurements.Add(sum + " (no change)");
                    }
                }
            }

            Util.PrintList(measurements);

            int countOfIncreases = Util.CalculateIncreases(measurements);

            Console.WriteLine("Times depth was increased " + countOfIncreases);
        }

    }
}

