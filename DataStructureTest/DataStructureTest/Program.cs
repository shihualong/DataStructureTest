using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            for (row = 1; row <= 9; row++)
            {
                for (column = 1; column <= row; column++)
                {
                    Console.Write(column + "*" + row + "=" + column * row);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
