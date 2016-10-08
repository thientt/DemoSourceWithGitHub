using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectLibrary.Test
{
    [TestClass]
    public class UnitTest
    {
        TestClass objt;
        string rvalue;

        [TestInitialize]
        public void TestInit()
        {
            objt = new TestClass();
            rvalue = "Done";
        }

        [TestCleanup]
        public void TestCleanup()
        {
            objt = null;
            rvalue = string.Empty;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(rvalue, objt.TestFun());
        }

    }
}
