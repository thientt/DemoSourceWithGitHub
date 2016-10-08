using System;

namespace MockingWithIoC.SenderService
{
    public class VoiceSender : ISender
    {
        public string Send() => "Send Voice";
    }
}
