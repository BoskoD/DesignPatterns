using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate
            var subject = new Subject();
            var redObserver = new Observer(ConsoleColor.Red);
            var blueObserver = new Observer(ConsoleColor.Blue);
            var whiteObserver = new Observer(ConsoleColor.White);

            // Subscribing to quantity changes
            subject.OnQuantityUpdated += redObserver.ObserverQuantity;
            subject.OnQuantityUpdated += blueObserver.ObserverQuantity;
            subject.OnQuantityUpdated += whiteObserver.ObserverQuantity;

            // Update quantity on the Subject
            subject.UpdateQuantity(27);
            Console.WriteLine();
            subject.UpdateQuantity(7);
        }
    }
}
