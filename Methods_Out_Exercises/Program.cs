using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Methods_Out_Exercises
{
    internal class Program
    {
        // 1. Method for finding sum and differece
        static void SumAndDifference(int a, int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b;
        }

        // 2. Method for dividing a numbers
        static void DivideNumbers(int a, int b, out int DivideResult, out int Remain)
        {
            DivideResult = a / b;
            Remain = a % b;
        }

        // 3. Method for finding max and min number
        static void FindMinMax(int a, int b, int c, out int min, out int max)
        {
            min = int.MinValue;
            max = int.MinValue;
            if (a >= b && a >= c)
                max = a;
            else
                min = a;

            if (b >= c && b >= a)
                max = b;
            else
                min = b;

            if (c >= b && c >= a)
                max = c;
            else
                min = c;
        }

        // 4. Method Convert string into int
        static void ParseInteger(string s, out bool result, out int number)
        {
            result = int.TryParse(s, out number);
        }

        // 5. Method for rectangle Datas
        static void GetRectangleData(int length, int width, out int perimetr, out int area)
        {
            perimetr = 2 * (length + width);
            area = length * width;
        }

        // 6. Method for Arrays
        static void ArrayMinMaxAverage(int[] array, out int max, out int min, out int average)
        {
            min = array[0];
            max = array[0];
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];

                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            average = sum / array.Length;
        }

        // 7. Method for splitting
        static void SplitFullName(string fullName, out string firstName, out string lastName)
        {           
            string[] parts = fullName
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 2)
            {
                firstName = parts[0];
                lastName = parts[1];
            }
            else
            {              
                firstName = parts[0];
                lastName = "(isn't entered)";
            }
        }

        // 8 Method for root calculating
        static bool CalculateRoots(double a, double b, double c, out double x1, out double x2)
        {
            double D = b * b - 4 * a * c; 
            if(D < 0)
            {
                x1 = 0;
                x2 = 0;
                return false;
            }
            else if(D == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return true;
            }
        }

        // 9. Method for Data parts
        static void GetDataParts(string data, out string day, out string month, out string year)
        {          
            string[] parts = data
                .Trim()
                .Split(new[] { ' ', '-', '.', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            day = parts[0];
            month = parts[1];
            year = parts[2];
        }

        // 10. Method for Text analyze
        static void GetTextData(string text, out int sumOfChars, out int sumOfWords, out int sumOfSentences)
        {
            sumOfChars = 0;
            sumOfSentences = 0;

            string[] word = text.Split(' ');
            sumOfWords = word.Length;
            foreach (char c in text)
            {
                sumOfChars++;
                if (c == '.')
                    sumOfSentences++;               
            }       
            
        }
        static void Main(string[] args)
        {
            // 1. Exercise
            Console.WriteLine("Finding sum and differece");
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int sum, diff;
            SumAndDifference(a, b, out sum, out diff);

            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Diff of numbers: " + diff);
            Console.ReadKey();
            Console.Clear();

            // 2. Exercise
            Console.WriteLine("Finding divide result and remain");
            Console.Write("Enter first number: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b1 = int.Parse(Console.ReadLine());

            int divideResult, remain;
            DivideNumbers(a1, b1, out divideResult, out remain);

            Console.WriteLine("Divide result: " + divideResult);
            Console.WriteLine("Divide remain: " + remain);
            Console.ReadKey();
            Console.Clear();

            // 3. Exercise
            Console.WriteLine("Finding Max number out of three");
            Console.Write("Enter first number: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c2 = int.Parse(Console.ReadLine());

            int max, min;
            FindMinMax(a2, b2, c2, out min, out max);

            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
            Console.ReadKey();
            Console.Clear();

            // 4. Exercise
            Console.WriteLine("Value converter");
            Console.Write("Enter a value: ");
            string s = Console.ReadLine();

            int numberResult;
            bool result;

            ParseInteger(s, out result, out numberResult);
            if (result)
                Console.WriteLine("Value is converted: " + numberResult);
            else Console.WriteLine("Value is NOT converted!");
            Console.ReadKey();
            Console.Clear();

            // 5. Exercise
            Console.WriteLine("Getting Rectangle data");
            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            int perimetr, area;
            GetRectangleData(length, width, out perimetr, out area);

            Console.WriteLine("Perimetr of rectangle: " + perimetr);
            Console.WriteLine("Area of rectangle: " + area);
            Console.ReadKey();
            Console.Clear();

            // 6. Exercise
            Console.Write("Enter array lenght: ");
            int arrayLenghtV6 = int.Parse(Console.ReadLine());
            int[] arrayFilled = new int[arrayLenghtV6];

            for (int i = 0; i < arrayFilled.Length; i++)
            {
                Console.Write($"Enter value number {i + 1}: ");
                arrayFilled[i] = int.Parse(Console.ReadLine());
            }
            
            
            int minV6, maxV6, averageV6;
            ArrayMinMaxAverage(arrayFilled, out maxV6, out minV6, out averageV6);

            Console.WriteLine("\nMax Value: " + maxV6);
            Console.WriteLine("Min Value: " + minV6);
            Console.WriteLine("Average Value: " + averageV6);
            Console.ReadKey();
            Console.Clear();

            // 7. Exercise
            Console.Write("Enter your Full name: ");
            string fullName = Console.ReadLine();

            string firstName, lastName;
            SplitFullName(fullName, out firstName, out lastName);

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.ReadKey();
            Console.Clear();

            // 8. Exercise
            Console.WriteLine("Finding the roots of a quadratic equation.");
            Console.Write("Enter a: ");
            double a8 = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b8 = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c8 = double.Parse(Console.ReadLine());

            double root1, root2;

            if (CalculateRoots(a8, b8, c8, out root1, out root2))
            {
                Console.WriteLine($"x1 = {root1}");
                Console.WriteLine($"x2 = {root2}");
            }
            else            
                Console.WriteLine("No roots find.");
            
            Console.ReadKey();
            Console.Clear();

            // 9. Exercise
            Console.WriteLine("Data pats.");
            Console.Write("Enter any date. Example(20-09-2025): ");
            string data = Console.ReadLine();

            string day, month, year;
            GetDataParts(data, out day, out month, out year);

            Console.WriteLine("Day: " + day);
            Console.WriteLine("Month: " + month);
            Console.WriteLine("Year: " + year);

            // 10. Exercise 
            Console.WriteLine("Text analyzer");
            Console.Write("Enter any text: ");
            string text = Console.ReadLine();

            int sumOfChars, sumOfWords, sumOfSentences;
            GetTextData(text, out sumOfChars, out sumOfWords, out sumOfSentences);

            Console.WriteLine("Amount of chars: " + sumOfChars);
            Console.WriteLine("Amount of words: " + sumOfWords);
            Console.WriteLine("Amount of sentences: " + sumOfSentences);
        }
    }
}
