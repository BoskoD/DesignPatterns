using FlixOne.InventoryManagement.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class QuitCommandTests
    {
        [TestMethod]
        public void QuitCommand_Successful()
        {
            var expectedInterface = new Helpers.TestUserInterface(
                new List<System.Tuple<string, string>>(),  // ReadValue()
                new List<string>  // WriteMessage()
                {
                    "Thank you for using FlixOne Inventory Management System"
                },
                new List<string>()  // WriteWarning()
            );

            // create an instance of the command
            var command = new QuitCommand(expectedInterface);

            // add a new book with parameter "name"
            var (wasSuccessful, shouldQuit) = command.RunCommand();

            expectedInterface.Validate();

            Assert.IsTrue(shouldQuit, "Quit is a terminating command.");
            Assert.IsTrue(wasSuccessful, "Quit did not complete Successfully.");
        }
    }
}
