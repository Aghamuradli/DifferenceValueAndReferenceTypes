﻿using System;

namespace ValueAndReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1 ??
            Console.WriteLine(number1);

             
            int[] numbers1 = new int[] {10, 20, 30};
            int[] numbers2 = new int[] {100, 200, 300};
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] ??
            Console.WriteLine(numbers1[0]);
        }
     }
}
