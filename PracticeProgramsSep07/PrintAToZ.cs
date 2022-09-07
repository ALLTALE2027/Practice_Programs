using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsSep07
{
    internal class PrintAToZ
    {
        public static void Alphabets()
        {
            char Alphabet = 'a';

            Console.WriteLine("Alphabets in small case");
            for (int i = 1; i <= 26; i++)
            {
                Console.Write(Alphabet++ + " " );
            }
        }
    }
}
