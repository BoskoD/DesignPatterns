using FlixOne.InventoryManagement.Commands;

namespace FlixOne.InventoryManagement.Interfaces
{
    public interface IInventoryCommandFactory
    {
        InventoryCommand GetCommand(string input);
    }
}
