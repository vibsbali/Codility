using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Codility.ChapterOne;

namespace Codility.ConsoleRunner
{
    class Program
    {
        static void Main()
        {
            var binaryGap = new BinaryGap();
            Console.WriteLine(binaryGap.Solution(5));
        }
    }
}
