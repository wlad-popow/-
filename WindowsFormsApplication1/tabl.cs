using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class tabl
    {
        public List<string> all_lessons = new List<string>();
        test_match t = new test_match();

        public void inp(Form1 f)
        {
            for (int i = 2; i < 13; i++ )
            {
                for (int j = 1; j < 36; j++)
                {
                    t.testMatch(all_lessons, f.Tabl[i, j].Value.ToString());
                    all_lessons.Add(f.Tabl[i, j].Value.ToString());
                    //Console.WriteLine(f.Tabl[i, j].Value.ToString());
                }
            }
        }
        public void spis(Form1 f)
        {
            foreach (string a in all_lessons)
            {
                f.tabl_znach.Items.Add(a);
            }
        }

        public void dell(Form1 f)
        {
            string s="";

            if (f.tabl_znach.SelectedItem != null)
                s = f.tabl_znach.SelectedItem.ToString();
            else
                return;
            
            for (int i = 0; i < f.Tabl.RowCount; i++)
            {
                for (int j = 0; j < f.Tabl.ColumnCount; j++)
                {
                    if (f.Tabl[j, i].Value != null)
                    {
                        if (s == f.Tabl[j, i].Value.ToString())
                        {
                            f.Tabl[j, i].Value = "";
                        }
                    }
                }
            }

            s = "";            
            all_lessons.Remove(f.tabl_znach.SelectedItem.ToString());
            f.missing_teachers.Text += f.tabl_znach.SelectedItem.ToString() + "\r\n";
            f.tabl_znach.SelectedItem = "";
            f.tabl_znach.Items.Clear();
            this.spis(f);
        }

        private int klass (string s)
        {
            s.Split(',', '.');
            for (int i=0; i < s.Length; i++)
            {
                
            }
            return 0;
        }
    }
}
