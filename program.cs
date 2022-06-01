/* File Information
Title: Javascript conversion
Author: Rhylei Tremlett
Version: 1.3
Date: 1/06/2022
------------------------------------------------------------- */
using System;

class Program
{
    public int[][] Construct(int size, int min, int max)
    {
        int[][] jagged = new int[size][];
        Random rnd = new Random();
        for (int i = 0; i < jagged.Length; i++)
        {
            int col = rnd.Next(1, 10);
            jagged[i] = new int[col];
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = rnd.Next(min, max);
            }
        }
        return jagged;
    }

    public void WriteArray(int[][] jagged)
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
    static void Main()
    {
        // Instantiate the Program class as an object
        Program p = new Program();

        // ask user to enter a value
        Console.WriteLine("Enter the size of the jagged array");
        
        // take user input and pass it as an argument to the construct method
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("This program will randomly generate a jagged array, it takes two parameters which you will input, a minimum value and a maximum value.");
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