/* File Information
Title: Javascript conversion
Author: Rhylei Tremlett
Version: 1.2
Date: 1/06/2022
------------------------------------------------------------- */
using System;

class Program
{
    public int[] Construct()
    {
        int[] array = { 1, 2, 3 };
        return array;
    }

    public string Sender()
    {
        return "hello world!";
    }
    static void Main()
    {
        Program p = new Program();
        int[] result = p.Construct();

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        Console.WriteLine("Hello World!");
        Console.ReadLine();
    }
}