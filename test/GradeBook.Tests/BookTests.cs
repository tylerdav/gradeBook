using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade ()
        {
            // arrange
            var book = new Book ("");
            book.AddGrade (89.1);
            book.AddGrade (90.5);
            book.AddGrade (75.5);

            // act
            var result = book.GetStatistics ();

            // assert
            Assert.Equal (85.6, result.Average);
        }
    }
}