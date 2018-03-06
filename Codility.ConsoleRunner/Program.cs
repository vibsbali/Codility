using System;
using Codility.StringToNumber;

namespace Codility.ConsoleRunner
{
    class Program
    {
        static void Main()
        {
            var converter = new ConvertStringToNumber();
            Console.WriteLine(converter.StringToNumber("91234"));
        }
    }
}
