using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class PotterShoppingCart
    {
        private IEnumerable<Book> _books;

        public decimal Price { get; set; }

        public void SetBooks(IEnumerable<Book> books)
        {
            _books = books;
        }

        public void CaculatePrice()
        {
            Price = _books.Sum(book => book.Price * book.Amount);
        }
    }
}