using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book (string name)
        {
            grades = new List<double> ();
            Name = name;
        }
        public void AddLetterGrade (char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddLetterGrade (90);
                    break;

                case 'B':
                    AddLetterGrade (80);
                    break;

                case 'C':
                    AddLetterGrade (70);
                    break;

                default:
                    AddLetterGrade (0);
                    break;
            }
        }
        public Statistics GetStatistics ()
        {
            var result = new Statistics ();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for (var index = 0; index < grades.Count; index += 1)
            {
                result.Low = Math.Min (grades[index], result.Low);
                result.High = Math.Max (grades[index], result.High);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            return result;
        }
        public string Name;

        private List<double> grades;
    }
}