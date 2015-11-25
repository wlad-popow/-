////Юнит тесты
namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using WindowsFormsApplication1;

    /// <summary>
    /// Юнит тесты
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Метод открытия урока
        /// </summary>
        [TestMethod]
        public void Open()
        {
            input inp = new input();
            
            ////получить день недели
            foreach (List<string> i in inp.tab)
            {
                foreach (string u in i)
                {
                    Assert.AreEqual("Понедельник", u);
                }
            }          
        }

        /// <summary>
        /// Метод удаления уроков
        /// </summary>
        [TestMethod]
        public void Delete()
        {
            Form1 f = new Form1();
            ////получить удаляемый урок
            Tabl t = new Tabl();
            ////проверить удален ли урок
            Assert.AreEqual(null, f.Tabl[5, 1]);                    
        }

        /// <summary>
        /// Метод проверки
        /// </summary>
        [TestMethod]
        public void Klass()
        {
            ////получить номер классов в котором удаляется урок
            ////Assert.AreEqual("7", urok.nom);                     
        }

        /// <summary>
        /// Проверка на совпадение уроков
        /// </summary>
        [TestMethod]
        public void Proverka()
        {
            Form1 f = new Form1();
            ////проверить не совпадают ли уроки у разных классов в строке
            for (int i = 3; i < 11; i++)
            {
                Assert.AreEqual(f.Tabl[2, 1], f.Tabl[i, 1]);
            }                      
        }
    }
}
