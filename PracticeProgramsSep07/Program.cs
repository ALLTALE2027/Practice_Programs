namespace PracticeProgramsSep07
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Practice Program!!!");
            char again = 'y';
            while (again == 'y')
            {
                
                Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Check for vowel");
            Console.WriteLine("2.Check for +ve -ve zero");
            Console.WriteLine("3.Largest among 3");
            Console.WriteLine("4.Max of 3");
            Console.WriteLine("5.Print a-z");
            int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Vowel.CheckVowel();
                        break;
                    case 2:
                        PositiveNegative.NumberCheck();
                        break;
                    case 3:
                        LargestAmongThree.MaxOfThreeNum();
                        break;
                    case 4:
                        LargestOf3.CheckMaxNumber();
                        break;
                    case 5:
                        PrintAToZ.Alphabets();
                        break;
                    default:
                        Console.WriteLine("enter correct choice");
                        break;
                }

                Console.WriteLine("Do you want to continue, (y/n)");
                again = char.Parse(Console.ReadLine());

            }

        }
       
    }
}
