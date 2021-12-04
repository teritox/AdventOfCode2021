using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_December
{
    public class Decoder
    {
        public static string GammaDecoder(List<string> binaries)
        {
            string[,] binaryArray = new string[binaries.Count, binaries[0].Length];
            int counter = 0;

            foreach (var binary in binaries)
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    binaryArray[counter, i] = binary[i].ToString();
                }
                    counter++;
            }

            string gammaRate = "";
            int columns = binaryArray.GetUpperBound(1);
            int length = binaryArray.GetUpperBound(0);

            for (int i = 0; i < columns + 1; i++) //columns
            {

                int zeros = 0;
                int ones = 0;

                for (int j = 0; j < length + 1; j++) //rows
                {
                    if (binaryArray[j, i] == "0")
                    {
                        zeros++;
                    }
                    else if (binaryArray[j, i] == "1")
                    {
                        ones++;
                    }
                }

                if (zeros > ones)
                {
                    gammaRate += "0";
                }
                else if(ones > zeros)
                {
                    gammaRate += "1";
                }
            }

            return gammaRate;
        }

        public static string EpsilonDecoder(List<string> binaries)
        {
            string[,] binaryArray = new string[binaries.Count, binaries[0].Length];
            int counter = 0;

            foreach (var binary in binaries)
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    binaryArray[counter, i] = binary[i].ToString();
                }
                counter++;
            }

            string epsilonRate = "";
            int columns = binaryArray.GetUpperBound(1);
            int length = binaryArray.GetUpperBound(0);

            for (int i = 0; i < columns + 1; i++) //columns
            {

                int zeros = 0;
                int ones = 0;

                for (int j = 0; j < length + 1; j++) //rows
                {
                    if (binaryArray[j, i] == "0")
                    {
                        zeros++;
                    }
                    else if (binaryArray[j, i] == "1")
                    {
                        ones++;
                    }
                }

                if (zeros < ones)
                {
                    epsilonRate += "0";
                }
                else if (ones < zeros)
                {
                    epsilonRate += "1";
                }
            }

            return epsilonRate;
        }
    }
}
