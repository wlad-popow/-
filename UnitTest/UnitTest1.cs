using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Windows.Forms;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestButton1()
        {
            Form1 f = new Form1();
            f.Toggle();
            Assert.AreEqual(false,f.Spanel);
        }

        [TestMethod]
        public void TestButton2()
        {
            Form1 f = new Form1();
            f.Toggle();
            Assert.AreEqual(false,f.Spanel);
        }

        [TestMethod]
        public void Open()
        {
            Form1 f = new Form1();
        }
    }
}
