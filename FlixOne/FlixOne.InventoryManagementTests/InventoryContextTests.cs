﻿using FlixOne.InventoryManagement.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class InventoryContextTests
    {
        [TestMethod]
        public void MaintainBooks_Successful()
        {
            List<Task> tasks = new();

            // add thirty books
            foreach (var id in Enumerable.Range(1, 30))
            {
                tasks.Add(AddBook($"Book_{id}"));
            }

            Task.WaitAll(tasks.ToArray());
            tasks.Clear();

            // let's update the quantity of the books by adding 1, 2, 3, 4, 5 ...
            foreach (var quantity in Enumerable.Range(1, 10))
            {
                foreach (var id in Enumerable.Range(1, 30))
                {
                    tasks.Add(UpdateQuantity($"Book_{id}", quantity));
                }
            }

            // let's update the quantity of the books by subtracting 1, 2, 3, 4, 5 ...
            foreach (var quantity in Enumerable.Range(1, 10))
            {
                foreach (var id in Enumerable.Range(1, 30))
                {
                    tasks.Add(UpdateQuantity($"Book_{id}", -quantity));
                }
            }

            // wait for all adds and subtracts to finish
            Task.WaitAll(tasks.ToArray());

            // all quantities should be 0            
            foreach (var book in InventoryContext.Singleton.GetBooks())
            {
                Assert.AreEqual(0, book.Quantity);
            }
        }

        public static Task AddBook(string book)
        {
            return Task.Run(() =>
            {
                Assert.IsTrue(InventoryContext.Singleton.AddBook(book));
            });
        }

        public static Task UpdateQuantity(string book, int quantity)
        {
            return Task.Run(() =>
            {
                Assert.IsTrue(InventoryContext.Singleton.UpdateQuantity(book, quantity));
            });
        }
    }
}
