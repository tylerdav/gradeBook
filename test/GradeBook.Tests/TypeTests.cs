using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects ()
        {
            var book1 = getBook ("Book 1");
            var book2 = getBook ("Book 2");

            Assert.Equal ("Book 1", book1.Name);
            Assert.Equal ("Book 2", book2.Name);
            Assert.NotSame (book1, book2);
        }

        [Fact]
        public void TwoVarsCanRefrenceSameObject ()
        {
            var book1 = getBook ("Book 1");
            var book2 = book1;

            Assert.NotSame (book1, book2);
            Assert.True (Object.ReferenceEquals (book1, book2));
        }

        BookTests GetBook (string name)
        {
            return new Book (name);
        }
    }
}