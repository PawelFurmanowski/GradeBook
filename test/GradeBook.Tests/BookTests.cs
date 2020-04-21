using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange (dane do testów)
            Book book = new Book("");
            book.AddGrade(77.3);
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            

            //actual 
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3,result.Low, 1);
        }
    }
}
