internal class MessageEventArgs : EventArgs
{
    public string Sender { get; }
    public string Message { get; }
    public DateTime Time { get; }

    public MessageEventArgs(string sender, string message)
    {
        Sender = sender;
        Message = message;
        Time = DateTime.Now;
    }
}