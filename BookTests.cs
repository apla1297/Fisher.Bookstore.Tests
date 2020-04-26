using Fisher.Bookstore.Models;
using System;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void AddBookPrice()
        {
            var book = new Book()
            {
                Id = 1, 
                Title = "My Test Book",
                Price = 9.99
            }; 

            book.ApplyMemberDiscount();

            var discountPrice = 9.99*.9; 
            Assert.Equal(discountPrice, book.Price);  

        }
    }
}
