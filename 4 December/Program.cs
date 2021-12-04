using _4_December.Models;
using System;
using System.Collections.Generic;

namespace _4_December
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BingoBoard> boards = FileReader.ReadInBoards();
            BingoController controller = new BingoController();
            
            controller.BingoRound(FileReader.ReadInNumbers(), boards);
        }
    }
}
