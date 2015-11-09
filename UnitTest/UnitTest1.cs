using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Open()
        {
            input inp = new input();
            
            //получить день недели
            foreach (List<string> i in inp.tab)
            {
                foreach (string u in i)
                {
                    Assert.AreEqual("Понедельник", u);
                }
            }          
        }

        [TestMethod]
        public void delete()
        {
            Form1 f = new Form1();
            //получить удаляемый урок
            tabl t = new tabl();
            //проверить удален ли урок
            Assert.AreEqual("",f.Tabl[5,1]);                    
        }

        [TestMethod]
        public void klass()
        {
            //получить номер классов в котором удаляется урок
            //Assert.AreEqual("7", urok.nom);                     
        }

        [TestMethod]
        public void proverka()
        {
            Form1 f = new Form1();
            //проверить не совпадают ли уроки у разных классов в строке
            for (int i = 3; i < 11; i++ )
            {
                Assert.AreEqual(f.Tabl[2, 1], f.Tabl[i, 1]);
            }                      
        }
    }
}

            
           
            