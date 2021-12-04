using _4_December.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_December
{
    public class FileReader
    {

        public static List<BingoBoard> ReadInBoards()
        {
            List<BingoBoard> bingoBoards = new List<BingoBoard>();

            StreamReader reader = new StreamReader("BingoFile.txt");
            string line = reader.ReadToEnd();


            string[] bingoBoardString = line.Split("\r\n\r\n");

            for (int i = 0; i < bingoBoardString.Length; i++)
            {
                BingoBoard board = new BingoBoard();

                string[] bingoRows = bingoBoardString[i].Split("\r\n", StringSplitOptions.None);

                for (int j = 0; j < bingoRows.GetUpperBound(0) + 1; j++)
                {
                    string[] bingoColumn = bingoRows[j].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    for (int g = 0; g < bingoColumn.GetUpperBound(0) + 1; g++)
                    {
                        board.NumbersArray[j, g] = Convert.ToInt32(bingoColumn[g]);

                    }
                }

                bingoBoards.Add(board);
            }

            return bingoBoards;
        }

        public static int[] ReadInNumbers()
        {
            StreamReader reader = new StreamReader("BingoNumbers.txt");
            string line = reader.ReadToEnd();

             string[] stringNumbers = line.Split(",");
            int[] numbers = new int[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(stringNumbers[i]);
            }

            return numbers;
        }
    }
}
