using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInit();
            SetInit(ref x);

            Assert.Equal(42, x);
        }

        private void SetInit(ref int z)
        {
            z = 42;
        }

        private int GetInit()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);

        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
          
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
          
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("book 1");
           var book2 = GetBook("book 2");

            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 2", book2.Name);
            Assert.NotSame(book1, book2);
       
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            var book1 = GetBook("book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
