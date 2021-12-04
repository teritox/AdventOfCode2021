using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_December.Models
{
    public class BingoBoard
    {
        public int[,] NumbersArray { get; set; } = new int[5, 5];
        public bool[,] BoolArray { get; set; } = new bool[5, 5];

    }
}
