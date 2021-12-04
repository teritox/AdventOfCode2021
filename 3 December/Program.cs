using System;
using System.Collections.Generic;

namespace _3_December
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> reading = FileReader.ReadInTextFile(); 

            string gammaRate = Decoder.GammaDecoder(reading);
            string epsilonRate = Decoder.EpsilonDecoder(reading);

            Console.WriteLine(gammaRate);
            Console.WriteLine($"In decimal: {Convert.ToInt32(gammaRate, 2)}");
            Console.WriteLine(epsilonRate);
            Console.WriteLine($"In decimal: {Convert.ToInt32(epsilonRate, 2)}");

            Console.WriteLine($"Gamma rate * epsilon rate = {Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2)}");
        }
    }
}
