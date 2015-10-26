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
            caculateDiscountPrice();
        }

        private void caculateDiscountPrice()
        {
            if (_books.Count() >= 5)
            {
                Price *= 0.75m;
            }
            else if (_books.Count() >= 4)
            {
                Price *= 0.8m;
            }
            else if (_books.Count() >= 3)
            {
                Price *= 0.9m;
            }
            else if (_books.Count() >= 2)
            {
                Price *= 0.95m;
            }
        }
    }
}