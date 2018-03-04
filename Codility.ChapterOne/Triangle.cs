using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ChapterOne
{
    public class Triangle
    {
        private int Rows { get; set; }
        public Triangle(int numberOfRows)
        {
            Rows = numberOfRows;
        }

        public void Print()
        {
            for (int i = 1; i <= Rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
