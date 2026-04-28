namespace Task2
{
    internal class MessagePublisher
    {
        public event EventHandler<MessageEventArgs> MessageSent;

        public void SendMessage(string sender, string message)
        {
            MessageSent?.Invoke(this, new MessageEventArgs(sender, message));
        }
    }
}