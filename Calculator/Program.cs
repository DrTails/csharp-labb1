using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Welcome to the console calculator.");
            Menu();

            while (true)
            {
                Selection(cal);
            }

        }

        private static void Menu()
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Multiply two numbers");
            Console.WriteLine("3. Sum the numbers between two numbers");
            Console.WriteLine("4. Add number to memory");
            Console.WriteLine("5. Clear memory");
            Console.WriteLine("6. Print calculator contents");
            Console.WriteLine("7. Quit");
            Console.WriteLine("\n");
        }

        private static void Selection(Calculator cal)
        {
            var input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("Please enter the first number:");
                    cal.FirstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    cal.SecondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("The sum of your numbers is " + cal.SumNumbers() + ".");
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "2":
                    Console.WriteLine("Please enter the first number:");
                    cal.FirstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    cal.SecondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("The product of your numbers is " + cal.MultiplyNumbers() + ".");
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "3":
                    Console.WriteLine("Please enter the first number:");
                    cal.FirstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    cal.SecondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("The sum total of your numbers is " + cal.SumInBetween() + ".");
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "4":
                    Console.WriteLine("Please enter the number you wish to save to memory:");
                    cal.NumberInMemory = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number successfully added to memory.");
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "5":
                    cal.NumberInMemory = 0;
                    Console.WriteLine("Number in memory cleared.");
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "6":
                    Console.WriteLine(cal.ToString());
                    Console.WriteLine("Please hit enter to return to the menu.");
                    Console.ReadLine();
                    Menu();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default :
                    Console.WriteLine("Incorrect choice, try again.");
                    break;
            }
        }
    }
}
