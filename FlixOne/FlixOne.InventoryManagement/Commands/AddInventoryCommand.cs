using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    internal class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        private readonly IInventoryContext _context;

        internal AddInventoryCommand(IUserInterface userInterface, IInventoryContext context) : base(userInterface)
        {
            _context = context;
        }

        public string InventoryName { get; private set; }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");

            return !string.IsNullOrWhiteSpace(InventoryName);
        }

        protected override bool InternalCommand()
        {
            return _context.AddBook(InventoryName);
        }
    }
}
