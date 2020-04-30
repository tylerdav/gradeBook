using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate (string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod ()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log ("Hello!");
            Assert.Equal (3, count);
        }

        string IncrementCount (string message)
        {
            count++;
            return message.ToLower ();
        }
        string ReturnMessage (string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void ValueTypesAlsoPassByValue ()
        {
            var x = GetInt ();
            SetInt (ref x);

            Assert.Equal (42, x);
        }

        private void SetInt (ref int32 z)
        {
            z = 42;
        }

        private int GetInt ()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByValue ()
        {
            var book1 = GetBook ("Book 1");
            GetBookSetName (out book1, "New Name");

            Assert.Equal ("New Name", book1.Name);
        }

        private void GetBookSetName (out Book book, string name)
        {
            book = new Book (name);
        }

        [Fact]
        public void CanSetNameFromReference ()
        {
            var book1 = GetBook ("Book 1");
            setName (book1, "New Name");

            Assert.Equal ("New Name", book1.Name);
        }
        private void SetName (BookTests book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes ()
        {
            string name = "Scott";
            var upper = MakeaUppercase (name);

            Assert.Equal ("Scott", name);
            Assert.Equal ("SCOTT", upper);
        }

        private string MakeaUppercase (string parameter)
        {
            return parameter.ToUpper ();
        }

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

        Book GetBook (string name)
        {
            return new Book (name);
        }
    }
}