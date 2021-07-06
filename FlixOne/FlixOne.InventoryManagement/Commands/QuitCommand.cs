using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    public class QuitCommand : InventoryCommand
    {
        public QuitCommand(IUserInterface userInterface) : base(true, userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            UserInterface.WriteMessage("Thank you for using FlixOne Inventory Management System");

            return true;
        }
    }
}
