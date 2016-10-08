using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingWithIoC;
using Moq;
using System;

namespace MockingWithIoC.UnitTest
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void PlayTest()
        {
            var player = new Player();

            var mock = new Mock<IPlayer>();
            mock.Setup(x => x.Add()).Returns(true);
            mock.Setup(x => x.Play()).Returns(true);

            SongMusic music = new SongMusic(mock.Object);
            Assert.AreEqual(music.Play(), true);
        }
    }
}
