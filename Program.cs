/* File Information
Title: SDV503 Assessment 3
Author: Rhylei Tremlett
Version: 1.8
Date: 18/06/2022
------------------------------------------------------------- */
using System;

namespace Assessment_3
{
    public class JavaScript : Program
    {
        /* 
         * creates a jagged array with random values,
         * length is defined by the user.
         */
        private int[][] Construct(int size, int min, int max)
        {
            // initialize an empty array of arrays with length == size
            int[][] jagged = new int[size][];
            // generate a random integer to be used for sub array length
            Random rnd = new Random();
            // iterate over empty jagged
            for (int i = 0; i < jagged.Length; i++)
            {
                // give the sub array a length between 1 - 10
                int col = rnd.Next(1, 10);
                jagged[i] = new int[col];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    // create a random number to fill index j
                    jagged[i][j] = rnd.Next(min-1, max+1);
                }
            }
            return jagged;
        }

        // Prints out the contents of the jagged array
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
            JavaScript javascript = new JavaScript();

            // ask user to enter a value for the array length
            int size = Input("Enter the size of the jagged array", Int32.MinValue, Int32.MaxValue);

            // take user input and pass it as an argument to the construct method
            Console.WriteLine("This program will randomly generate a jagged array, it takes two parameters, a minimum value and a maximum value. Values are inclusive.");
            int min = Input("Define the minimum", Int32.MinValue, Int32.MaxValue);
            int max = Input("Define the maximum", Int32.MinValue, Int32.MaxValue);

            // construct the jagged array
            int[][] jaggedArray = javascript.Construct(size, min, max);

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
            javascript.WriteArray(jaggedArray);

            // write out the largest numbers
            Console.WriteLine("Largest Numbers");
            foreach (int number in largestNumbers) { Console.WriteLine(number); }
            Console.ReadLine();
        }
    }

    public class Calculator : Program
    {
        public void Begin()
        {
            Console.Title = "Calculator";
            Calculator calculator = new Calculator();

            bool flag = true;
            while (flag)
            {
                
                int choice = Input("Please select which operator you would like to use:\n1. Addition\n2. Subtraction\n3. Division\n4. Muliplication\n5. Power\n6. Remainder\n", 1, 6);
                int first = Input("Enter the first number: ", Int32.MinValue, Int32.MaxValue);
                int second = Input("Enter the second number: ", Int32.MinValue, Int32.MaxValue);

                switch (choice)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Addition(first, second));
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Subtraction(first, second));
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Division(first, second));
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Muliplication(first, second));
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Power(first, second));
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Answer: ");
                        Console.WriteLine(calculator.Remainder(first, second));
                        break;
                }
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
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
    public class Program
    {
        /*
        Ive placed this method into this class and made the other 
        classes inherit from it so that this method doesnt need to be
        pasted into all three classes, very DRY :)

        This method takes takes a message and a range as parameters.
        It takes user input and attempts to parse it,
        if it fails it gives an error and asks for input again.

        if it succesfully parses it then is check if the value falls
        insides the range provided, if not it gives an error and repeats
        */
        public int Input(string message, int min, int max)
        {
            // write message to console
            Console.Write(message);
            while (true)
            {
                // take input and attempt to parse
                string input = Console.ReadLine();
                int.TryParse(input, out int result);
                // if parse is successful
                if (result != 0)
                {
                    // check if parsed value falls in the range
                    if (result <= max && result >= min)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input, please try again.");
                    }
                }
                // if parse fails
                else
                {
                    Console.WriteLine("That was not a valid input, please try again.");
                }
            }
        }
        static void Main()
        {
            Program program = new Program();

            int choice = program.Input("Please select which program you would like to run:\n(At any point press CTRL + C to Exit the program)\n1. Calculator\n2. Javascript Converted Code\n", 1, 2);

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
