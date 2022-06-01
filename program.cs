/* File Information
Title: SDV503 Assessment 3
Author: Rhylei Tremlett
Version: 1.4
Date: 2/06/2022
------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment_3
{
    internal class JavaScript
    {
        private int[][] Construct(int size, int min, int max)
        {
            int[][] jagged = new int[size][];
            Random rnd = new Random();
            for (int i = 0; i < jagged.Length; i++)
            {
                int col = rnd.Next(1, 10);
                jagged[i] = new int[col];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = rnd.Next(min-1, max+1);
                }
            }
            return jagged;
        }

        private void WriteArray(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("Sub-Array: ", i);
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine(jagged[i][j]);
                } 
            }
        }
        public void Begin()
        {
            // Instantiate the Program class as an object
            JavaScript p = new JavaScript();

            // ask user to enter a value
            Console.WriteLine("Enter the size of the jagged array");
        
            // take user input and pass it as an argument to the construct method
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("This program will randomly generate a jagged array, it takes two parameters, a minimum value and a maximum value. Values are inclusive.");
            Console.WriteLine("Define the minimum");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Define the maximum");
            int max = int.Parse(Console.ReadLine());


            int[][] jaggedArray = p.Construct(size, min, max);

            // setup the array to be returned
            int[] largestNumbers = new int[size];

            // iterate over the entire jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int largestNum = min;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                   if (jaggedArray[i][j] > largestNum)
                    {
                        largestNum = jaggedArray[i][j];
                    } 
                }
                largestNumbers[i] = largestNum;
            }
        
            // write out all of the elements of the jagged array
            p.WriteArray(jaggedArray);

            // write out the largest numbers
            Console.WriteLine("Largest Numbers");
            foreach (int number in largestNumbers) { Console.WriteLine(number); }
            Console.ReadLine();
        }
    }

    internal class Calculator
    {
        public void Begin()
        {
            Calculator calculator = new Calculator();
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select which operator you would like to use:\n1. Addition\n2. Subtraction\n3. Division\n4. Muliplication\n5. Power\n6. Remainder");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the first number:");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int second = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(calculator.Addition(first, second));
                        break;
                    case 2:
                        Console.WriteLine(calculator.Subtraction(first, second));
                        break;
                    case 3:
                        Console.WriteLine(calculator.Division(first, second));
                        break;
                    case 4:
                        Console.WriteLine(calculator.Muliplication(first, second));
                        break;
                    case 5:
                        Console.WriteLine(calculator.Power(first, second));
                        break;
                    case 6:
                        Console.WriteLine(calculator.Remainder(first, second));
                        break;
                }
            }
        }

        private double Addition(double value1, double value2)
        {
            return value1 + value2;
        }
        private double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }
        private double Division(double value1, double value2)
        {
            return value1 / value2;
        }
        private double Muliplication(double value1, double value2)
        {
            return value1 * value2;
        }
        private double Power(double value1, double value2)
        {
            return Math.Pow(value1, value2);
        }
        private double Remainder(double value1, double value2)
        {
            return value1 % value2;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select which program you would like to run:\n(At any point press CTRL + C to Exit the program.\n1. Calculator\n2. Javascript Converted Code");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Calculator calculator = new Calculator();
                calculator.Begin();
            }
            else if (choice == 2)
            {
                JavaScript javaScript = new JavaScript();
                javaScript.Begin();
            }
        }
    }
}
