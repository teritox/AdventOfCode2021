using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_December
{
    public class Decoder
    {
        public static string GetGammaRate(List<string> binaries)
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
                else if (ones > zeros)
                {
                    gammaRate += "1";
                }
            }

            return gammaRate;
        }

        public static string GetEpsilonRate(List<string> binaries)
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

        public static string GetOxygenGeneratorRating(List<string> binaries)
        {
            List<string> oxygenList = binaries;

            while (oxygenList.Count > 1)
            {
                for (int i = 0; i < oxygenList[0].Length; i++)
                {
                    int zeros = 0;
                    int ones = 0;

                    foreach (var binary in oxygenList)
                    {
                        if (binary[i] == '0')
                        {
                            zeros++;
                        }
                        else if (binary[i] == '1')
                        {
                            ones++;
                        }
                    }

                    if (zeros > ones)
                    {
                        oxygenList = oxygenList.Where(c => c[i].ToString() == "0")
                            .ToList();
                    }
                    else if (ones > zeros || ones == zeros)
                    {
                        oxygenList = oxygenList.Where(c => c[i].ToString() == "1")
                            .ToList();
                    }

                }
            }

            return oxygenList.FirstOrDefault();

        }


        public static string GetCO2ScrubberRating(List<string> binaries)
        {
            List<string> CO2List = binaries;
            int length = CO2List[0].Length;


            while (CO2List.Count > 1)
            {
                for (int i = 0; i < length; i++)
                {
                    int zeros = 0;
                    int ones = 0;

                    foreach (var binary in CO2List)
                    {
                        if (binary[i] == '0')
                        {
                            zeros++;
                        }
                        else if (binary[i] == '1')
                        {
                            ones++;
                        }
                    }

                    if (zeros > ones && ones > 0)
                    {
                        CO2List = CO2List.Where(c => c[i].ToString() == "1")
                            .ToList();

                    }
                    else if ((ones > zeros || ones == zeros) && zeros > 0 )
                    {
                        CO2List = CO2List.Where(c => c[i].ToString() == "0")
                            .ToList();
                    }

                }
            }

            return CO2List.FirstOrDefault();

        }
    }

}