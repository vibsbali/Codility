using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ChapterOne
{
    public class TriangleUpsideDown
    {
        public TriangleUpsideDown(int numberOfRows)
        {
            Rows = numberOfRows;
        }

        private int Rows { get; }

        //The formula is 2n-1
        public void Print()
        {
            var spaceCounter = 0;
            for (int i = Rows; i > 0; i--)
            {
                for (int j = 0; j < spaceCounter; j++)
                {
                    Console.Write(" ");
                }

                var n = (2 * i) - 1;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                spaceCounter++;
            }
        }
    }
}
