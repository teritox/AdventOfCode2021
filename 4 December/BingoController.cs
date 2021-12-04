using _4_December.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_December
{
    public class BingoController
    {
        public void BingoRound(int[] numbers, List<BingoBoard> bingoBoards)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                BoardPrinter.PrintAllBoards(bingoBoards);
                Console.ReadLine();
                Console.Clear();

                foreach (var board in bingoBoards)
                {
                    for (int row = 0; row < 5; row++)
                    {
                        for (int column = 0; column < 5; column++)
                        {
                            if(board.NumbersArray[row, column] == numbers[i])
                            {
                                board.BoolArray[row, column] = true;
                            }
                        }
                    }
                }

            }
        }
    }
}
