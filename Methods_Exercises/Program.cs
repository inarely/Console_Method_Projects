using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercises
{
    internal class Program
    {
        // 1. Method: Display person's name
        static void NameOfPerson(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // 2. Method: Sum of two numbers
        static int SumOfNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // 3. Method: Check if number is even
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        // 4. Method: Calculate power (square)
        static double PowNumberMethod(int a)
        {
            double pow = Math.Pow(a, 2);
            return pow;
        }

        // 5. Method: Find the maximum of two numbers
        static int MaxNumber(int a, int b)
        {
            if (a > b)
                return a;
            else if (a < b)
                return b;
            else
                return 0; // both numbers are equal
        }

        // 6. Method: Count characters in string
        static int CharsInString(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }

        // 7. Method: Convert string to upper case
        static string ToUpperCase(string s)
        {
            string result = s.ToUpper();
            return result;
        }

        // 8. Method: Check if number is between 10 and 20
        static bool IsNumberInRange(int numberInRange)
        {
            return numberInRange >= 10 && numberInRange <= 20;
        }

        // 9. Method: Calculate factorial of a number
        static int FactorialMethod(int a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
                factorial *= i;

            return factorial;
        }

        // 10. Method: Check if number is palindrome
        static bool PalindromeMethod(int pNum)
        {
            int staticNumber = pNum;
            int palindrome = 0;
            while (pNum > 0)
            {
                int temp = pNum % 10;
                palindrome = palindrome * 10 + temp;
                pNum /= 10;
            }

            return palindrome == staticNumber;
        }

        static void Main(string[] args)
        {
            // 1. Display name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            NameOfPerson(name);
            Console.ReadKey();
            Console.Clear();

            // 2. Sum of numbers
            Console.WriteLine("Sum of Two Numbers");
            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of numbers is: {SumOfNumbers(firstNum, secondNum)}");
            Console.ReadKey();
            Console.Clear();

            // 3. Check if number is even
            Console.WriteLine("Even Number Check");
            Console.Write("Enter a number: ");
            int testNumber = int.Parse(Console.ReadLine());
            if (IsEven(testNumber))
                Console.WriteLine($"Number {testNumber} is even.");
            else
                Console.WriteLine($"Number {testNumber} is odd.");
            Console.ReadKey();
            Console.Clear();

            // 4. Power of a number
            Console.WriteLine("Power of a Number");
            Console.Write("Enter a number: ");
            int powNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number {powNumber} squared is: {PowNumberMethod(powNumber)}");
            Console.ReadKey();
            Console.Clear();

            // 5. Find max number
            Console.WriteLine("Find the Maximum Number");
            Console.Write("Enter the first number: ");
            int firstMaxNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondMaxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The greater number is: {MaxNumber(firstMaxNumber, secondMaxNumber)}");
            Console.ReadKey();
            Console.Clear();

            // 6. Count characters in string
            Console.WriteLine("Count Characters in a Sentence");
            Console.Write("Write something: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Number of characters: {CharsInString(sentence)}");
            Console.ReadKey();
            Console.Clear();

            // 7. Convert to upper case
            Console.WriteLine("Convert Sentence to Upper Case");
            Console.Write("Write a sentence: ");
            string sentenceUpper = Console.ReadLine();
            Console.WriteLine($"Upper case version: {ToUpperCase(sentenceUpper)}");
            Console.ReadKey();
            Console.Clear();

            // 8. Check if number is in range
            Console.WriteLine("Check if Number is in Range (10–20)");
            Console.Write("Enter a number: ");
            int numberInRange = int.Parse(Console.ReadLine());
            if (IsNumberInRange(numberInRange))
                Console.WriteLine($"Number {numberInRange} is within the range of 10 and 20");
            else
                Console.WriteLine($"Number {numberInRange} is NOT within the range");
            Console.ReadKey();
            Console.Clear();

            // 9. Factorial of a number
            Console.WriteLine("Factorial Calculator");
            Console.Write("Enter a number: ");
            int factorialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {factorialNumber} is: {FactorialMethod(factorialNumber)}");
            Console.ReadKey();
            Console.Clear();

            // 10. Palindrome check
            Console.WriteLine("Palindrome Number Check");
            Console.Write("Enter a number: ");
            int palindromeNumber = int.Parse(Console.ReadLine());
            if (PalindromeMethod(palindromeNumber))
                Console.WriteLine($"Number {palindromeNumber} IS a palindrome");
            else
                Console.WriteLine($"Number {palindromeNumber} is NOT a palindrome");
        }
    }
}