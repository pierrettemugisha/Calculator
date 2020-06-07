using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            bool endApp = false;
            while (!endApp)
            {
                Console.Write("Type a number, and press Enter:");
                string input1 = Console.ReadLine();
                double value1;
                while (!double.TryParse(input1, out value1))
                {
                    Console.Write("This is not a valid input. Please enter an integer or floating value: ");
                    input1 = Console.ReadLine();
                }

                Console.Write("Type another number, and press Enter:");
                string input2 = Console.ReadLine();
                double value2;
                while (!double.TryParse(input2, out value2))
                {
                    Console.Write("This is not a valid input. Please enter an integer or floating value: ");
                    input2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Substract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option?: ");

                string op = Console.ReadLine();

                double result = Calculator.DoOperation(value1, value2, op);

                try
                {
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An exception occurred trying to do the math.\n - Details: {e.Message}");
                }
                Console.WriteLine("--------------------------\n");

                // end app
                Console.WriteLine("Press 'n' and Enter to end the app. Press any other key and Enter to do more operations: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine("\n");
            }

        }
    }
}
