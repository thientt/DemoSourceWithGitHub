using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MockingWithIoC.UnitTest
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void PlayTest()
        {
            var mock = new Mock<IPlayer>();
            mock.Setup(x => x.Add()).Returns(true);
            mock.Setup(x => x.Play()).Returns(true);

            var music = new SongMusic(mock.Object);
            Assert.AreEqual(music.Play(), true);
        }
    }
}
