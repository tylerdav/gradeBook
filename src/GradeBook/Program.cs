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
            book.ShowStatistics ();

        }
    }
}