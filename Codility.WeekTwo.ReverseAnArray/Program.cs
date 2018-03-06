using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.WeekTwo.ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = "Hello World";
            var enumerable = one.Reverse();
            foreach (var item in enumerable)
            {
                Console.Write($"{item} ");
            }
        }
    }

    public static class ReverseArray
    {
        public static void Reverse<T>(this T[] A)
        {
            if (A.Length <= 1)
            {
                return;
            }

            var ptrOne = 0;
            var ptrTwo = A.Length - 1;

            while (ptrOne < ptrTwo)
            {
                var temp = A[ptrOne];
                A[ptrOne] = A[ptrTwo];
                A[ptrTwo] = temp;
                ++ptrOne;
                --ptrTwo;
            }
        }
    }
}
