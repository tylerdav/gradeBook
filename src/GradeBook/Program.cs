using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main (string[] args)
        {
            var book = new Book ("Tyler's Grade Book");
            book.AddGrade (89.3);
            book.AddGrade (90.2);
            book.AddGrade (77.5);

            var stats = book.GetStatistics ();

            Console.WriteLine ($"the lowest grade is {stats.Low}");
            Console.WriteLine ($"the highest grade is {stats.High}");
            Console.WriteLine ($"the average grade is {stats.Average:N1}");

        }
    }
}