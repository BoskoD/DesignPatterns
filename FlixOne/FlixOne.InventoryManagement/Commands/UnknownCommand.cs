using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    public class UnknownCommand : NonTerminatingCommand
    {
        public UnknownCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            UserInterface.WriteWarning("Unable to determine the desired command.");

            return false;
        }
    }
}
