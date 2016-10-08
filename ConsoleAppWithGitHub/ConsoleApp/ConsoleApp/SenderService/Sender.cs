namespace MockingWithIoC.SenderService
{
    public class Sender
    {
        public string Send(ISender sender) => sender.Send();
    }
}
