namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Клас выполняющий алгоритм создания опримального расписания.
    /// </summary>
    class Algoritm
    {
        /// <summary>
        /// Двумерный массив содержащий расписание загруженное из таблици формы.
        /// </summary>
        private List<List<string>> tablica = new List<List<string>>();

        /// <summary>
        /// Выполняет функцию проверки
        /// </summary>
        /// <param name="s">Преподаватель</param>
        /// <param name="ur">Номер урока</param>
        /// <returns>Если совпадает то 0 иначе 1</returns>
        private int Proverka(string s, int ur)
        {
            foreach (List<string> i in this.tablica)
            {
                if (i[ur].ToString() == s)
                {
                    return 0;
                }
            }

            return 1;
        }

        /// <summary>
        /// Переменая пказывающая номер урока.
        /// </summary>
        private int a = 0;

        /// <summary>
        /// Метод перестановки уроков.
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        public void Perestanovka(Form1 f)
        {
            int ur;
            this.TablicaAdd(f);
            this.a = 0;

            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                    f.Tabl[i, j].Value = string.Empty;
                }
            }

            while (this.a <= 28)
            {
                for (int i = 0; i < 11; i++)
                {
                    ur = this.Poisk(i);
                    if (ur != -1)
                    {
                        for (int j = this.a + 6; j > ur; j--)
                        {
                            if (this.tablica[i][j] != string.Empty && this.Proverka(this.tablica[i][j], ur) == 1)
                            {
                                this.tablica[i][ur] = this.tablica[i][j];
                                this.tablica[i][j] = string.Empty;
                                break;
                            }
                        }
                    }
                }

                this.a = this.a + 7;
                this.Exp(f);
            }
        }

        /// <summary>
        /// Метод поиска свободного урока в классе.
        /// </summary>
        /// <param name="klass">Номер класса</param>
        /// <returns>Если есть сободный урок то номер урока i иначе -1</returns>
        private int Poisk(int klass)
        {
            for (int i = this.a; i < this.a + 7; i++)
            {
                if (this.tablica[klass][i].ToString() == string.Empty)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Метод считывания таблици формы в Tablica.
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        private void TablicaAdd(Form1 f)
        {
            this.tablica.Clear();
            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                this.tablica.Add(new List<string>());
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                    if (f.Tabl[i, j].Value == null)
                    {
                        f.Tabl[i, j].Value = string.Empty;
                    }

                    this.tablica[i - 2].Add(f.Tabl[i, j].Value.ToString());
                }
            }
        }

        /// <summary>
        /// Метод вывода отредактированного расписания в таблицу формы.
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        private void Exp(Form1 f)
        {
            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                    f.Tabl[i, j].Value = this.tablica[i - 2][j - 1];
                }
            }
        }
    }
}
