using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsSep07
{
    internal class LargestOf3
    {
        public static void CheckMaxNumber()
        {
            Console.WriteLine("C# Program to Find the Largest Among Three Numbers");
            Console.WriteLine("Enter  first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  third Number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum from {0} {1} {2} is {3} ", a, b, c, a > b ? (a > c ? a : c) : (b > c ? b : c));
        }
    }
}
