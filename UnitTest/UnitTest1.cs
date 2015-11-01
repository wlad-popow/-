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
            //получить день недели
            Assert.AreEqual("Понедельник", f.Tabl[0,0].Value);
            //получить удаляемый урок
            tabl t = new tabl();
            missing mis = new missing();
            Assert.AreEqual(t.all_lessons[1], mis.ss[1]);
            //получить номер классов в котором удаляется урок
            Assert.AreEqual("7", urok.nom);
            //проверить удален ли урок
            Assert.AreEqual("",f.Tabl[5,1]);
            //проверить не совпадают ли уроки у разных классов в строке
            for (int i = 3; i < 11; i++ )
            {
                Assert.AreEqual(f.Tabl[2, 1], f.Tabl[i, 1]);
            }            
        }
    }
}
