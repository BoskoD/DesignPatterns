using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    public abstract class InventoryCommand
    {
        private readonly bool IsTerminatedCommand;
        protected IUserInterface UserInterface { get; }

        protected InventoryCommand(bool IsTerminatedCommand, IUserInterface userInterface)
        {
            this.IsTerminatedCommand = IsTerminatedCommand;
            this.UserInterface = userInterface;
        }

        public (bool wasSuccessful, bool shouldQuit) RunCommand() 
        {
            if (this is IParameterisedCommand parameterisedCommand)
            {
                var allParametersCompleted = false;

                while (allParametersCompleted == false)
                {
                    allParametersCompleted = parameterisedCommand.GetParameters();
                }
            }

            return (InternalCommand(), IsTerminatedCommand);
        }

        protected abstract bool InternalCommand();

        protected string GetParameter(string parameterName)
        {
            return UserInterface.ReadValue($"Enter {parameterName}");
        }
    }
}
