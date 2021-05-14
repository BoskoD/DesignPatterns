using System;
using System.Collections.Generic;
using System.Threading;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<IMessage>
            {
                new NormalDecorator(new SimpleMessage("Simple text.")),
                new NormalDecorator(new AlertMessage("This is alert with a beep!")),
                new ErrorDecorator(new AlertMessage("This is alert with beep and in red!")),
                new SimpleMessage("Not decorated...")
            };

            foreach (var item in messages)
            {
                item.PrintMessage();
                Thread.Sleep(1000);
            }

            Console.Read();
        }
    }
}
