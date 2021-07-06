using FlixOne.InventoryManagement.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlixOne.InventoryManagementTests
{
    [TestClass]
    public class HelpCommandTests
    {
        [TestMethod]
        public void HelpCommand_Successful()
        {
            var expectedInterface = new Helpers.TestUserInterface(
                new List<System.Tuple<string, string>>(),
                new List<string>
                {
                    "USAGE:",
                    "\taddinventory (a)",
                    "\tgetinventory (g)",
                    "\tupdatequantity (u)",
                    "\tquit (q)",
                    "\t?",
                    "Examples:",
                    "\tNew Inventory",
                    "\t> addinventory",
                    "\tEnter name:The Meaning of Life",
                    "",
                    "\tGet Inventory",
                    "\t> getinventory",
                    "\tThe Meaning of Life        Quantity:10",
                    "\tThe Life of a Ninja        Quantity:2",
                    "",
                    "\tUpdate Quantity (Increase)",
                    "\t> updatequantity",
                    "\tEnter name:The Meaning of Life",
                    "\t11",
                    "\t11 added to quantity",
                    "",
                    "\tUpdate Quantity (Decrease)",
                    "\t> updatequantity",
                    "\tEnter name:The Life of a Ninja",
                    "\t-3",
                    "\t3 removed from quantity",
                    ""
                },
                new List<string>()
            );

            // create an instance of the command
            var command = new HelpCommand(expectedInterface);

            var (wasSuccessful, shouldQuit) = command.RunCommand();

            Assert.IsFalse(shouldQuit, "Help is not a terminating command.");
            Assert.IsTrue(wasSuccessful, "Help did not complete Successfully.");
        }
    }
}
