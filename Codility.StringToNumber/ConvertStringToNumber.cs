using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.StringToNumber
{
    public class ConvertStringToNumber
    {
        public int StringToNumber(string input)
        {
            var A = input.ToCharArray();

            int result = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                result += (int)Math.Pow(10.0, A.Length -1 - i) * int.Parse(A[i].ToString());
            }

            return result;
        }
    }
}
