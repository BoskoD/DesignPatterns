using FlixOne.InventoryManagement.Interfaces;

namespace FlixOne.InventoryManagement.Commands
{
    public class HelpCommand : NonTerminatingCommand
    {
        public HelpCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        protected override bool InternalCommand()
        {
            UserInterface.WriteMessage("USAGE:");
            UserInterface.WriteMessage("\taddinventory (a)");
            UserInterface.WriteMessage("\tgetinventory (g)");
            UserInterface.WriteMessage("\tupdatequantity (u)");
            UserInterface.WriteMessage("\tquit (q)");
            UserInterface.WriteMessage("\t?");
            UserInterface.WriteMessage("Examples:");
            UserInterface.WriteMessage("\tNew Inventory");
            UserInterface.WriteMessage("\t> addinventory");
            UserInterface.WriteMessage("\tEnter name:The Meaning of Life");
            UserInterface.WriteMessage("");
            UserInterface.WriteMessage("\tGet Inventory");
            UserInterface.WriteMessage("\t> getinventory");
            UserInterface.WriteMessage("\tThe Meaning of Life        Quantity:10");
            UserInterface.WriteMessage("\tThe Life of a Ninja        Quantity:2");
            UserInterface.WriteMessage("");
            UserInterface.WriteMessage("\tUpdate Quantity (Increase)");
            UserInterface.WriteMessage("\t> updatequantity");
            UserInterface.WriteMessage("\tEnter name:The Meaning of Life");
            UserInterface.WriteMessage("\t11");
            UserInterface.WriteMessage("\t11 added to quantity");
            UserInterface.WriteMessage("");
            UserInterface.WriteMessage("\tUpdate Quantity (Decrease)");
            UserInterface.WriteMessage("\t> updatequantity");
            UserInterface.WriteMessage("\tEnter name:The Life of a Ninja");
            UserInterface.WriteMessage("\t-3");
            UserInterface.WriteMessage("\t3 removed from quantity");
            UserInterface.WriteMessage("");

            return true;
        }
    }
}
