using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/*
 * From Codility verbatim https://codility.com
   Task description
   A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
   
   For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps.
   
   Write a function:
   
   class Solution { public int solution(int N); }
   
   that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.
   
   For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.
   
   Assume that:
   
   N is an integer within the range [1..2,147,483,647].
   Complexity:
   
   expected worst-case time complexity is O(log(N));
   expected worst-case space complexity is O(1).
   Copyright 2009–2018 by Codility Limited. All Rights Reserved.
 */
namespace Codility.ChapterOne
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            //Step 1 look for edge cases
            if (N <= 0)
            {
                throw new IndexOutOfRangeException();
            }

            var max = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            checked
            {
                //convert int to binary
                var A = Convert.ToString(N, 2);
                int firstOne = 0;
                int secondOne = 0;
                int i = 0;
                int j = 0;

                while (i < A.Length)
                {
                    for (i = j; i < A.Length; i++)
                    {
                        if (A[i] == '1')
                        {
                            firstOne = i;
                            break;
                        }
                    }

                    for (j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == '1')
                        {
                            secondOne = j;
                            break;
                        }
                    }

                    var difference = secondOne - firstOne - 1;
                    if (difference > 0)
                    {
                        max = difference > max ? difference : max;
                    }
                }
            }

            return max;
        }
    }
}
