﻿using System;

    class ExcllentOrNot
    {
        static void Main()
        {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else Console.WriteLine("Not excellent.");
        }
    }