﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedTime2
{
    class Time2Test
    {
        static void Main(string[] args)
        {
            var t1 = new Time2();
            var t2 = new Time2(2);
            var t3 = new Time2(21, 34);
            var t4 = new Time2(12, 25, 42);

            Console.WriteLine("Constructed with: \n");
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine($" {t1.ToUniversalString()}");
            Console.WriteLine($" {t1.ToString()}\n");

            Console.WriteLine("t2: hour specified; minute and second defaulted");
            Console.WriteLine($" {t2.ToUniversalString()}");
            Console.WriteLine($" {t2.ToString()}");

            Console.WriteLine("t3: hour and minute specified; second defaulted");
            Console.WriteLine($" {t3.ToUniversalString()}");
            Console.WriteLine($" {t3.ToString()}");

            Console.WriteLine("t4: hour, minute and second specified");
            Console.WriteLine($" {t4.ToUniversalString()}");
            Console.WriteLine($" {t4.ToString()}");



            try
            {
                var t6 = new Time2(27, 74, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while initializing t6");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
