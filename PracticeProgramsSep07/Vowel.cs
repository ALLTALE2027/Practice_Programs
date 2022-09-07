using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsSep07
{
    internal class Vowel
    {
        public static void CheckVowel()
        {
            Console.WriteLine("C# Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("Enter a Alphabet ");
            char a = char.Parse(Console.ReadLine());


            switch (a.ToString().ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabet is Consonant");
                    break;


            }
        }
    }
}
