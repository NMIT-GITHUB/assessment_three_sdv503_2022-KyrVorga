/* File Information
Title: Javascript conversion
Author: Rhylei Tremlett
Version: 1.3
Date: 1/06/2022
------------------------------------------------------------- */
using System;

class Program
{
    public int[][] Construct(int size)
    {
        int[][] jagged = new int[size][];
        Random rnd = new Random();
        for (int i = 0; i < jagged.Length; i++)
        {
            int col = rnd.Next(1, 10);
            jagged[i] = new int[col];
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = rnd.Next(1, 100);
            }
        }
        return jagged;
    }

    static void Main()
    {
        Program p = new Program();
        Console.WriteLine("Enter the size of the jagged array");
        int size = int.Parse(Console.ReadLine());
        int[][] result = p.Construct(size);
        
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("contents of sub-array: ", i);
            for (int j = 0; j < result[i].Length; j++)
            {
                Console.WriteLine(result[i][j]);
            }
        }
        Console.ReadLine();
    }
}