using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class PotterShoppingCart
    {
        private IEnumerable<Book> _books;

        public int BookCount
        {
            get { return _books.Sum(book => book.Amount); }
        }

        public decimal Price { get; set; }

        public void SetBooks(IEnumerable<Book> books)
        {
            _books = books;
        }

        public void CaculatePrice()
        {
            Price = 0;

            // 將書依照數量單本展開
            var sepreatedBooks = new List<Book>();
            foreach (var book in _books)
            {
                for (var i = 0; i < book.Amount; ++i)
                {
                    var tmpBook = book.Clone() as Book;
                    tmpBook.Amount = 1;
                    sepreatedBooks.Add(tmpBook);
                }
            }
            // 將展開的清單取distinct物件群組, 加入運費計算後從清單移除
            while (sepreatedBooks.Any())
            {
                var distinctBooks = sepreatedBooks.Distinct(new BookComparer()).ToList();
                Price += caculateDiscountPrice(distinctBooks);
                foreach (var caculatedBook in distinctBooks)
                {
                    sepreatedBooks.Remove(caculatedBook);
                }
            }
        }

        private decimal caculateDiscountPrice(IEnumerable<Book> books)
        {
            decimal price = books.Sum(book => book.Price * book.Amount);
            if (books.Count() >= 5)
            {
                price *= 0.75m;
            }
            else if (books.Count() >= 4)
            {
                price *= 0.8m;
            }
            else if (books.Count() >= 3)
            {
                price *= 0.9m;
            }
            else if (books.Count() >= 2)
            {
                price *= 0.95m;
            }
            return price;
        }
    }
}