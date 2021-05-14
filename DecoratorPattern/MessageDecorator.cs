namespace DecoratorPattern
{
    abstract class MessageDecorator : IMessage
    {
        protected Message _message;

        public MessageDecorator(Message message)
        {
            _message = message;
        }

        public abstract void PrintMessage();
    }
}
