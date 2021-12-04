using _4_December.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_December
{
    public static class BoardPrinter
    {
        public static void PrintAllBoards(List<BingoBoard> bingoBoards)
        {
            int rows = bingoBoards.Count / 10;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        for (int g = 0; g < 5; g++)
                        {
                            if (bingoBoards[(i * 10) + h].BoolArray[j, g] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }

                                if ((bingoBoards[(i * 10) + h].NumbersArray[j, g] < 10))
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(bingoBoards[(i * 10) + h].NumbersArray[j, g] + " ");

                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.Write("     ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
