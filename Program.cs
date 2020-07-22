using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            string cont = "y";
            while (cont == "y")
            {
                Console.WriteLine("Please enter a number between 1 and 100 ");
                int input = int.Parse(Console.ReadLine());
                
                if (input > 1 && input < 26 && input % 2 == 0)
                {
                    Console.WriteLine(name + ", your number is "+input + " Even and less than 25");
                }
                else if (input > 25 && input < 61 && input%2==0)
                {
                    Console.WriteLine(name+ ", your number is "+"Even");
                }

                else if (input % 2 == 0)
                {
                    Console.WriteLine(name + ", your number is "+input + " Even");
                }
                else if (input % 2 != 0)
                {
                    Console.WriteLine(name+ ", your number is "+input + " Odd");

                }
                Console.WriteLine("Would you like to continue? (y/n)");
                cont= Console.ReadLine();
            }
            Console.WriteLine("Goodbye");








            
        }
    }
}
