﻿namespace Program;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Find");
        string? inputPara = Console.ReadLine();

        string[] convertToArray = inputPara.Split(" ");

        if (convertToArray.Length == 0)
        {
            System.Console.WriteLine();
        }
    }
}
