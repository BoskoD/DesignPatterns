using FlixOne.InventoryManagement.Interfaces;
using FlixOne.InventoryManagement.Repository;

namespace FlixOne.InventoryManagement.Commands
{
        public class InventoryCommandFactory : IInventoryCommandFactory
        {
            private readonly IUserInterface _userInterface;
            private readonly IInventoryContext _context = InventoryContext.Singleton;

            public InventoryCommandFactory(IUserInterface userInterface)
            {
                _userInterface = userInterface;
            }

            public InventoryCommand GetCommand(string input)
            {
                return input.ToLower() switch
                {
                    "q" or "quit" => new QuitCommand(_userInterface),
                    "a" or "addinventory" => new AddInventoryCommand(_userInterface, _context),
                    "g" or "getinventory" => new GetInventoryCommand(_userInterface, _context),
                    "u" or "updatequantity" => new UpdateQuantityCommand(_userInterface, _context),
                    "?" => new HelpCommand(_userInterface),
                    _ => new UnknownCommand(_userInterface),
                };
            }
        }
    }
