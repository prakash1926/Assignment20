using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        // Task 7: Methods
        static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            // Task 2: Variables and User Input

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            // Task 3: Basic Arithmetic

            Console.Write("Enter the first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division: {num1 / num2}");
                Console.WriteLine($"Modulus: {num1 % num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // Task 4: Control Structures

            Console.Write("Enter an integer to check if it's even or odd: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            // Task 5: Loops
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Task 6: Arrays
            
            int[] Array = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in Array)
            {
                sum += num;
            }

            double average = (double)sum / Array.Length;

            Console.WriteLine($"Array Sum: {sum}");
            Console.WriteLine($"Array Average: {average}");

            // Task 7: Methods
            Console.Write("Enter an integer to calculate its factorial: ");
            int factorialInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {factorialInput}: {CalculateFactorial(factorialInput)}");

            // Task 8: Exception Handling
            int age;
            bool validAge = false;

            do
            {
                Console.Write("Please enter your age: ");

                if (int.TryParse(Console.ReadLine(), out age))
                {
                    validAge = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (!validAge);

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }

            Console.ReadKey(); 
        }

    
        
    }
}
