using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsSep07
{
    internal class LargestAmongThree
    {
        public static void MaxOfThreeNum()
        {
            Console.WriteLine("Enter First Number");
            int FNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int SNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int TNumber = int.Parse(Console.ReadLine());
            if (FNumber > SNumber)
            {
                if (FNumber > TNumber)
                    Console.WriteLine("{0} is maximum", FNumber);
                else
                    Console.WriteLine("{0} is maximum", TNumber);
            }
            else if (SNumber > TNumber)
            {
                Console.WriteLine("{0} is maximum", SNumber);
            }
            else { Console.WriteLine("{0} is maximum", TNumber); }
        }
    }
}
