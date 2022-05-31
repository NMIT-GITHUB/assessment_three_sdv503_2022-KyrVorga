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
        return jagged;
    }

    static void Main()
    {
        Program p = new Program();
        string size = Console.ReadLine();
        int[][] result = p.Construct(Int32.Parse(size));

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        Console.WriteLine("array: "+ string.Join(",", result));
        Console.ReadLine();
    }
}