using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void CaculateFeeTest_第一集一本_價錢為100()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100}
            };
            target.SetBooks(books);
            var expected = 100;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_第一集一本_第二集一本_價錢為190()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 1, Price = 100}
            };
            target.SetBooks(books);
            var expected = 190;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_一二三集各買一本_價錢為270()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 1, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 1, Price = 100}
            };
            target.SetBooks(books);
            var expected = 270;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_一二三四集各買一本_價錢為320()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 1, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 1, Price = 100},
                new Book() { Id = 4, Name="哈利波特4", Amount = 1, Price = 100}
            };
            target.SetBooks(books);
            var expected = 320;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_一二三四五集各買一本_價錢為375()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 1, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 1, Price = 100},
                new Book() { Id = 4, Name="哈利波特4", Amount = 1, Price = 100},
                new Book() { Id = 5, Name="哈利波特5", Amount = 1, Price = 100}
            };
            target.SetBooks(books);
            var expected = 375;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_一二集各買一本_第三集買兩本_價錢為370()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 1, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 2, Price = 100},
            };
            target.SetBooks(books);
            var expected = 370;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_第一集買了一本_第二三集各買兩本_價錢為460()
        {
            // arrange
            var target = new PotterShoppingCart();
            var books = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 2, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 2, Price = 100},
            };
            target.SetBooks(books);
            var expected = 460;

            // act
            target.CaculatePrice();
            var actual = target.Price;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CaculateFeeTest_計算運費後購物車內容不會消失()
        {
            // arrange
            var target = new PotterShoppingCart();
            var booksStub = new Book[]
            {
                new Book() { Id = 1, Name="哈利波特1", Amount = 1, Price = 100},
                new Book() { Id = 2, Name="哈利波特2", Amount = 2, Price = 100},
                new Book() { Id = 3, Name="哈利波特3", Amount = 2, Price = 100},
            };
            target.SetBooks(booksStub);
            var expected = 5;

            // act
            target.CaculatePrice();
            var actual = target.BookCount;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}