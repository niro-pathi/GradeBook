using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void InMemoryBookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade('B');
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //actual
            var result = book.GetStatistics();

            //assert
            Assert.Equal(84.2, result.Average, 1);
            Assert.Equal(90.5, result.High,1);
            Assert.Equal(77.3, result.Low,1);
            Assert.Equal('B', result.Letter);

        }

        [Fact]
        public void DiskBookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new DiskBook("");
            book.AddGrade('B');
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //actual
            var result = book.GetStatistics();

            //assert
            Assert.Equal(84.2, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }

    }
}
