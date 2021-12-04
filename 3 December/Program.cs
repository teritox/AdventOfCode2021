using System;
using System.Collections.Generic;

namespace _3_December
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> reading = FileReader.ReadInTextFile();

            //string gammaRate = Decoder.GetGammaRate(reading);
            //string epsilonRate = Decoder.GetEpsilonRate(reading);

            //Console.WriteLine(gammaRate);
            //Console.WriteLine($"In decimal: {Convert.ToInt32(gammaRate, 2)}");
            //Console.WriteLine(epsilonRate);
            //Console.WriteLine($"In decimal: {Convert.ToInt32(epsilonRate, 2)}");

            //Console.WriteLine($"Gamma rate * epsilon rate = {Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2)}");


            string OxygenGeneratorRatingInBinary = Decoder.GetOxygenGeneratorRating(reading);
            string CO2XcrubberRatingInBinary = Decoder.GetCO2ScrubberRating(reading);

            Console.WriteLine(OxygenGeneratorRatingInBinary);
            Console.WriteLine($"In decimal: {Convert.ToInt32(OxygenGeneratorRatingInBinary, 2)}");

            Console.WriteLine(CO2XcrubberRatingInBinary);
            Console.WriteLine($"In decimal: {Convert.ToInt32(CO2XcrubberRatingInBinary, 2)}");

            Console.WriteLine($"Oxygen Generator Rating * CO2 Scrubber Rating = {Convert.ToInt32(OxygenGeneratorRatingInBinary, 2) * Convert.ToInt32(CO2XcrubberRatingInBinary, 2)}");

        }
    }
}
