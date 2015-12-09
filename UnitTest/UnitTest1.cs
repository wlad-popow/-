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
            Input inp = new Input();
            
            //получить день недели
            foreach (List<string> i in inp.tab)
            {
                foreach (string u in i)
                {
                    Assert.AreEqual("Понедельник", u);
                }
            }          
        }
        
        /// <summary>
        /// Проверка на совпадение уроков
        /// </summary>
        [TestMethod]
        public void Proverka()
        {
            Algoritm alg = new Algoritm();
            ////проверить не совпадают ли уроки у разных классов в строке
            for (int i = 3; i < 11; i++)
            {
            }                      
        }
    }
}
