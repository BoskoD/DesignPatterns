using FlixOne.InventoryManagement.Commands;
using FlixOne.InventoryManagement.Interfaces;
using System.Reflection;

namespace FlixOne.InventoryManagementClient
{
    internal class CatalogService : ICatalogService
    {
        private readonly IUserInterface userInterface;
        private readonly IInventoryCommandFactory commandFactory;


        public CatalogService(IUserInterface userInterface, IInventoryCommandFactory commandFactory)
        {
            this.userInterface = userInterface;
            this.commandFactory = commandFactory;
        }

        public void Run()
        {
            Greeting();

            var response = commandFactory.GetCommand("?").RunCommand();

            while (!response.shouldQuit)
            {
                var input = userInterface.ReadValue("> ").ToLower();
                var command = commandFactory.GetCommand(input);

                response = command.RunCommand();

                if (!response.wasSuccessful)
                {
                    userInterface.WriteMessage("Enter ? to view options.");
                }

            }
        }

        private void Greeting()
        {
            // get version and display
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            userInterface.WriteMessage("*********************************************************************************************");
            userInterface.WriteMessage("*                                                                                           *");
            userInterface.WriteMessage("*               Welcome to FlixOne Inventory Management System                              *");
            userInterface.WriteMessage($"*                                                                                v{version}   *");
            userInterface.WriteMessage("*********************************************************************************************");
            userInterface.WriteMessage("");
        }
       
    }
}