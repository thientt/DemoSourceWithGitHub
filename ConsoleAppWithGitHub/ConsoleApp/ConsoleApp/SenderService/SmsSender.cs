using System;

namespace MockingWithIoC.SenderService
{
    public class SmsSender : ISender
    {
        public string Send()
        {
            return "Send SMS";
        }
    }
}
