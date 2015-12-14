//// Основные алгоритмы
//// <copyright>All rights ignored</copyright>
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс, выполняющий алгоритм создания опримального расписания.
    /// </summary>
    public class Algoritm
    {
        /// <summary>
        /// Переменая пказывающая номер урока.
        /// </summary>
        private int a = 0;

        /// <summary>
        /// Двумерный массив, содержащий расписание, загруженное из таблици формы.
        /// </summary>
        private List<List<string>> tablica = new List<List<string>>();

        /// <summary>
        /// Метод перестановки уроков.
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        public void Perestanovka(Form1 f)
        {
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
                for (int fo = 0; fo < 3; fo++)
                {
                    for (int fok = 0; fok < 7; fok++)
                    {
                        this.AlgBeta();
                        this.AlgBetaT();
                        this.DopAlg();
                    }

                    this.AlgOkna();
                }

                this.a = this.a + 7;
            }

            this.Exp(f);
        }

        /// <summary>
        /// Алгоритм перестановки уроков бета версии.
        /// </summary>
        private void AlgBeta()
        {
            int ur;
            for (int i = 0; i < 11; i++)
            {
                if (this.ProwerkaKlassa(i) < 0)
                {
                    ur = this.Poisk(i, 0);
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
            }
        }

        /// <summary>
        /// Перевернутый алгоритм перестановки уроков бета версии.
        /// </summary>
        private void AlgBetaT()
        {
            int ur;
            for (int i = 0; i < 11; i++)
            {
                if (this.ProwerkaKlassa(i) < 0)
                {
                    ur = this.Poisk(i, 0);
                    if (ur != -1)
                    {
                        for (int j = this.a; j > ur; j++)
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
            }
        }

        /// <summary>
        /// Дополнительный алгоритм перестановки уроков.
        /// </summary>
        private void DopAlg()
        {
            int ur;
            for (int i = 0; i < 11; i++)
            {
                if (this.ProwerkaKlassa(i) < 0)
                {
                    ur = this.Poisk(i, 0);
                    if (ur != -1)
                    {
                        for (int j = this.a; j < ur; j++)
                        {
                            if (this.tablica[i][j] != string.Empty)
                            {
                                ur = this.Poisk(i, j);
                                if (ur != -1)
                                {
                                    if (this.Proverka(this.tablica[i][j], ur) == 1)
                                    {
                                        this.tablica[i][ur] = this.tablica[i][j];
                                        this.tablica[i][j] = string.Empty;
                                        this.AlgBeta();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Алгоритм перестановки уроков создающий свободные уроки.
        /// </summary>
        private void AlgOkna()
        {
            int ur;
            for (int i = 0; i < 11; i++)
            {
                for (int fok = 0; fok < 7; fok++)
                {
                    if (this.ProwerkaKlassa(i) < 0)
                    {
                        ur = this.Poisk(i, 0);
                        if (ur != -1)
                        {
                            for (int j = this.a; j < this.a + 7; j++)
                            {
                                if (this.tablica[i][j] != string.Empty)
                                {
                                    ur = this.Poisk(i, j - this.a);
                                    if (ur != -1)
                                    {
                                        if (this.Proverka(this.tablica[i][j], ur) == 1)
                                        {
                                            this.tablica[i][ur] = this.tablica[i][j];
                                            this.tablica[i][j] = string.Empty;
                                            break;
                                        }
                                        else
                                        {
                                            if (ur + 1 < this.a + 7)
                                            {
                                                ur = this.Poisk(i, ur + 1);
                                            }

                                            if (ur != -1)
                                            {
                                                if (this.Proverka(this.tablica[i][j], ur) == 1)
                                                {
                                                    this.tablica[i][ur] = this.tablica[i][j];
                                                    this.tablica[i][j] = string.Empty;
                                                    break;
                                                }
                                                else
                                                {
                                                    if (ur + 1 < this.a + 7)
                                                    {
                                                        ur = this.Poisk(i, ur + 1);
                                                    }

                                                    if (ur != -1)
                                                    {
                                                        if (this.Proverka(this.tablica[i][j], ur) == 1)
                                                        {
                                                            this.tablica[i][ur] = this.tablica[i][j];
                                                            this.tablica[i][j] = string.Empty;
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Проверка класса на наличие окна.
        /// </summary>
        /// <param name="klass">Номер класса</param>
        /// <returns>Возвращает меньше нуля если есть окно, иначе возвращает 1,
        /// либо 0 в тех случаях если первые уроки свободны или последних уроков нет</returns>
        private int ProwerkaKlassa(int klass)
        {
            int okno = 1;
            for (int i = this.a; i < this.a + 7; i++)
            {
                if (this.tablica[klass][i].ToString() != string.Empty)
                {
                    if (i + 1 < this.a + 7 && this.tablica[klass][i + 1].ToString() == string.Empty)
                    {
                        okno--;
                    }
                }
                else
                {
                    if (i + 1 < this.a + 7 && this.tablica[klass][i + 1].ToString() != string.Empty && okno == 0)
                    {
                        okno--;
                    }
                }
            }

            return okno;
        }

        /// <summary>
        /// Выполняет функцию проверки
        /// </summary>
        /// <param name="s">Переменная преподавателя</param>
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
        /// Метод поиска свободного урока в классе.
        /// </summary>
        /// <param name="klass">Номер класса</param>
        /// <param name="nomUr">Номер урока</param>
        /// <returns>Если есть сободный урок то номер урока i иначе -1</returns>
        private int Poisk(int klass, int nomUr)
        {
            for (int i = this.a + nomUr; i < this.a + 7; i++)
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
