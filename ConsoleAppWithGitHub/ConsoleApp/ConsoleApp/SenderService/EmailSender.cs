using System;

namespace MockingWithIoC.SenderService
{
    public class EmailSender : ISender
    {
        public string Send() => "Send Email";
    }
}
