using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Book : ICloneable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        public object Clone()
        {
            return new Book()
            {
                Id = this.Id,
                Name = this.Name,
                Price = this.Price,
                Amount = this.Price
            };
        }
    }
}