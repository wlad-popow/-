//-----------------------------------------------------------------------
// <copyright file="tabl.cs" company="UpturnedChair">
//     Copyright (c) UpturnedChair. All rights reserved.
// </copyright>
// <author>wlad-popow</author>
//-----------------------------------------------------------------------

//// Работа с таблицей
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс работы с таблицей
    /// </summary>
    public class Tabl
    {
        /// <summary>
        /// Список уникальных преподавателей
        /// </summary>
        private HashSet<string> allLessons = new HashSet<string>();

        /// <summary>
        /// Метод добавления значений в All_lessons
        /// </summary>
        /// <param name="f">Главная форма программы</param>        
        public void Inp(Form1 f)
        {
            for (int i = 1; i < f.Tabl.RowCount; i++)
            {
                for (int j = 2; j < f.Tabl.ColumnCount; j++)
                {
                    if (f.Tabl[j, i].Value != null && f.Tabl[j, i].Value.ToString() != string.Empty)
                    {
                        this.allLessons.Add(f.Tabl[j, i].Value.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Метод добавления значений в ComboBox
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        public void Spis(Form1 f)
        {
            f.TablZnach.Items.Clear();
            foreach (string a in this.allLessons)
            {
                f.TablZnach.Items.Add(a);
            }
        }

        /// <summary>
        /// Метод удаления содержимого ячеек схожих по значению с ComboBox
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        public void Dell(Form1 f)
        {
            string s = string.Empty;

            if (f.TablZnach.SelectedItem != null)
            {
                s = f.TablZnach.SelectedItem.ToString();
            }
            else
            {
                return;
            }

            for (int i = 0; i < f.Tabl.RowCount; i++)
            {
                for (int j = 0; j < f.Tabl.ColumnCount; j++)
                {
                    if (f.Tabl[j, i].Value != null)
                    {
                        if (s == f.Tabl[j, i].Value.ToString())
                        {
                            f.Tabl[j, i].Value = string.Empty;
                        }
                    }
                }
            }

            s = string.Empty;
            this.allLessons.Remove(f.TablZnach.SelectedItem.ToString());
            f.missing_teachers.Text += f.TablZnach.SelectedItem.ToString() + "\r\n";
            f.TablZnach.SelectedItem = string.Empty;
        }
    }
}
