/* File Information
Title: Javascript conversion
Author: Rhylei Tremlett
Version: 1
Date: 24/05/2022
------------------------------------------------------------- */
using System;

class Program
{
    string name;

    public void GetName()
    {
        name = Console.ReadLine();
    }

    static void Main()
    {
        Program instance = new Program();
        instance.GetName();
        Console.WriteLine(name);
    }
}