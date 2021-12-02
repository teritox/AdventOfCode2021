using System;

namespace Advent_of_Code_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader.ReadSonarMeasurements();
            DepthCalc depthCalc = new DepthCalc();
            ThreeSlidingCalc slidingCalc = new ThreeSlidingCalc();  

            depthCalc.AmountOfIncreases();
            slidingCalc.AmountOfIncreases();
        }
    }
}
