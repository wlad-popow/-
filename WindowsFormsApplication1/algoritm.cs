using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class algoritm
    {
        List<List<string>> tablica = new List<List<string>>();
        // проверка уроков на совпадение
        static private int proverka(string s)
        {
            
            return 0;
        }

        // престановка уроков
        public void perestanovka(Form1 f)
        {
            tablica_add(f);
            for (int i = 1; i <= 11; i++)
            { 
                poisk(i);
            }
        }

        static private int poisk(int klass)
        {
            return 0;
        }

        private void tablica_add(Form1 f)
        {
            for (int i = 1; i < f.Tabl.RowCount; i++)
            {
                tablica.Add(new List<string>());
                for (int j = 2; j < f.Tabl.ColumnCount; j++)
                {
                    if (f.Tabl[j, i].Value == null)
                        continue;
                    tablica[i-1].Add(f.Tabl[j, i].Value.ToString());
                    //tablica[i - 1].Add("wertu");
                }
            }
        }

        private void exp(Form1 f)
        {
            // удалить содержимое ячеек
            for (int i = 1; i < f.Tabl.RowCount; i++)
            {
                for (int j = 2; j < f.Tabl.ColumnCount; j++)
                {
                    f.Tabl[j, i].Value = "";
                }
            }
            // вывести отредактированное расписание
            int x = 0, y = 0;
            f.Tabl.RowCount = tablica.Count;
            foreach (List<string> i in tablica)
            {
                f.Tabl.ColumnCount = i.Count;
                foreach (string u in i)
                {
                    f.Tabl.Rows[x].Cells[y].Value = u;
                    y++;
                }
                y = 0;
                x++;
            }
        }

    }
}
