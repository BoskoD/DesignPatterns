using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    public abstract class NonTerminatingCommand : InventoryCommand
    {
        protected NonTerminatingCommand(IUserInterface userInterface) : base(IsTerminatedCommand: false, userInterface: userInterface)
        {
        }
    }
}
