using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class algoritm
    {
        //TODO: сделать экспорт по проверенным классам, используя сделанные проверки сделать перестройку уроков.

        List<List<string>> tablica = new List<List<string>>();
        // проверка уроков на совпадение
        private int proverka(string s, int ur)
        {
            foreach (List<string> i in tablica)
            {                
                if (i[ur].ToString() == s)//значит есть совпадение в строке
                {
                    return 0;
                }
            }
            return 1;
        }

        // престановка уроков
        public void perestanovka(Form1 f)
        {
            int ur;
            tablica_add(f);


            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                    f.Tabl[i, j].Value = "";
                }
            }

            for (int x = 0; x < 7; x++)
            {                
                for (int i = 0; i < 11; i++)
                {
                    ur = poisk(i);
                    if (ur != -1)
                    {
                        for (int j = 6; j > ur; j--)
                        {
                            if (tablica[i][j] != "" && proverka(tablica[i][j], ur) == 1)
                            {
                                tablica[i][ur] = tablica[i][j];
                                tablica[i][j] = "";
                                break;
                            }
                        }
                    }
                }
                exp(f);
            }
        }

        private int poisk(int klass)
        {
            for (int i = 0; i < tablica.Count; i++ )
            {
                //Console.Write(i[klass].ToString() + "\r\n");
                //string s = tablica[klass][i].ToString();
                if (tablica[klass][i].ToString() == "")
                {
                    return i;
                }
                if (i == 7)
                {
                    return -1;
                }
            }
            return -1;
        }

        private void tablica_add(Form1 f)
        {
            tablica.Clear();
            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                tablica.Add(new List<string>());
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                    if (f.Tabl[i, j].Value == null)
                        f.Tabl[i, j].Value="";
                    tablica[i-2].Add(f.Tabl[i, j].Value.ToString());
                }
            }
        }

        private void exp(Form1 f)
        {
            // вывести отредактированное расписание
            for (int i = 2; i < f.Tabl.ColumnCount; i++)
            {
                for (int j = 1; j < f.Tabl.RowCount; j++)
                {
                //    if (proverka(f.Tabl[i, j].Value.ToString(), j - 1) == 1)
                //    {
                //        f.Tabl[i, j].Value = tablica[i - 2][j - 1];
                //    }
                    f.Tabl[i, j].Value = tablica[i - 2][j - 1];
                }
            }
        }

    }
}
