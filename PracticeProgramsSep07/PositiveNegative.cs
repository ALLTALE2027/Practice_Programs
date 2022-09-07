using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsSep07
{
    internal class PositiveNegative
    {
        public static void NumberCheck()
            {
                Console.WriteLine("Enter Number");
                int Number = int.Parse(Console.ReadLine());
                if (Number == 0)
                    Console.WriteLine("0 is zero");
                else if (Number > 0)
                    Console.WriteLine("{0} is Positive", Number);
                else 
                  Console.WriteLine("{0} is Negative", Number); 
            }
        
    }
}
