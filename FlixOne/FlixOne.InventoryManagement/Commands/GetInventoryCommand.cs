using FlixOne.InventoryManagement.Interfaces;
using System;

namespace FlixOne.InventoryManagement.Commands
{
    internal class GetInventoryCommand : NonTerminatingCommand
    {
        private readonly IInventoryContext _context;
        internal GetInventoryCommand(IUserInterface userInterface, IInventoryContext context) : base(userInterface)
        {
            _context = context;
        }

        protected override bool InternalCommand()
        {
            foreach (var book in _context.GetBooks())
            {
                UserInterface.WriteMessage($"{book.Name,-30}\tQuantity:{book.Quantity}");
            }

            return true;
        }
    }
}
