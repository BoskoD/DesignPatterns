using FlixOne.InventoryManagement.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class UnknownCommandTests
    {
        [TestMethod]
        public void UnknownCommand_Successful()
        {
            var expectedInterface = new Helpers.TestUserInterface(
                new List<System.Tuple<string, string>>(),
                new List<string>(),
                new List<string>
                {
                    "Unable to determine the desired command."
                }
            );

            // create an instance of the command
            var command = new UnknownCommand(expectedInterface);

            var (wasSuccessful, shouldQuit) = command.RunCommand();

            Assert.IsFalse(shouldQuit, "Unknown is not a terminating command.");
            Assert.IsFalse(wasSuccessful, "Unknown should not complete Successfully.");
        }
    }
}
