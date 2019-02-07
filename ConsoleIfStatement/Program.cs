using System;

namespace ConsoleIfStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondnum = int.Parse(Console.ReadLine());
            if (firstnum > secondnum)
            {
                Console.WriteLine("First number is greater than second number");
                
            }
            else if (secondnum > firstnum)
            {
                Console.WriteLine("Second number is greater than First number");
                
            }
            else
            {
                Console.WriteLine("The two number are equal");
            }

            string password = "4528kahara";
            string name = "morris";
            Console.WriteLine("Enter name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password1 = Console.ReadLine();
            if ((name != name1) && (password != password1))
            {
                Console.WriteLine("Invalid name or password");
                Console.WriteLine("Try again");
            }
            else
            {
                Console.WriteLine("Welcone , enjoy your code");
                
            }
            Console.WriteLine("Enter any number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("The number is odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("The number is even");
                    break;
                default:
                    Console.WriteLine("The number you entered is out of bound between 1 and 9");
                    break;
                
            }
            
            

            Console.ReadKey();

        }
    }
}