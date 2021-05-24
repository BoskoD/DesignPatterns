using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observer
    {
        ConsoleColor _color;

        public Observer(ConsoleColor color)
        {
            _color = color;
        }

        internal void ObserverQuantity(int quantity)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine($"I observe the new quantity value: {quantity}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
