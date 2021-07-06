using FlixOne.InventoryManagement.Commands;
using FlixOne.InventoryManagement.Models;
using FlixOne.InventoryManagementTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class AddInventoryCommandTests
    {
        [TestMethod]
        public void AddInventoryCommand_Successful()
        {
            const string expectedBookName = "AddInventoryUnitTest";
            var expectedInterface = new TestUserInterface(
                new List<System.Tuple<string, string>>
                {
                    new System.Tuple<string, string>("Enter name:", expectedBookName)
                },
                new List<string>(),
                new List<string>()
            );

            var context = new TestInventoryContext(new Dictionary<string, Book>
            {
                { "Gremlins", new Book { Id = 1, Name = "Gremlins", Quantity = 7 } }
            });

            // create an instance of the command
            var command = new AddInventoryCommand(expectedInterface, context);

            // add a new book with parameter "name"
            var (wasSuccessful, shouldQuit) = command.RunCommand();

            Assert.IsFalse(shouldQuit, "AddInventory is not a terminating command.");
            Assert.IsTrue(wasSuccessful, "AddInventory did not complete Successfully.");

            // verify the book was added with the given name with 0 quantity
            Assert.AreEqual(1, context.GetAddedBooks().Length, "AddInventory should have added one new book.");

            var newBook = context.GetAddedBooks().First();
            Assert.AreEqual(expectedBookName, newBook.Name, "AddInventory did not add book successfully.");
        }
    }
}
