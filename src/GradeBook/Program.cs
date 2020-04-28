using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main (string[] args)
        {
            // var x = 32.2;
            // var y = 17.8;
            // var result = x + y;
            // Console.WriteLine ($"{x} + {y} = {result}");

            // assigning a new array
            // var numbers = new double[3];
            // numbers[0] = 12.7;
            // numbers[1] = 10.3;
            // numbers[2] = 6.11;

            // var numbers = new []
            // {
            //     12.7,
            //     10.3,
            //     6.11,
            //     4.1
            // };

            List<double> grades = new List<double> ()
            {
                12.7,
                10.3,
                6.11,
                4.1
            };
            grades.Add (20.1);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine ($"the average grade is {result}");

            if (args.Length > 0)
            {
                Console.WriteLine ($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine ($"Hello!");
            }
        }
    }
}