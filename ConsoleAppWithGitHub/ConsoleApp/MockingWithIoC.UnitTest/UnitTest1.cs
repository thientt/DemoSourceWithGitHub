using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingWithIoC.SenderService;

namespace MockingWithIoC.UnitTest
{
    [TestClass]
    public class SenderUnitTest
    {
        [TestMethod]
        public void SendTest()
        {
            string sms = "Send SMS";
            string email = "Send Email";
            string voice = "Send Voice";

            Assert.AreEqual(sms, new Sender().Send(new SmsSender()));
            Assert.AreEqual(email, new Sender().Send(new EmailSender()));
            Assert.AreEqual(voice, new Sender().Send(new VoiceSender()));
        }
    }
}
