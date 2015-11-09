using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class tabl
    {
        public HashSet<string> all_lessons = new HashSet<string>();

        public void inp(Form1 f)
        {
            for (int i = 1; i < f.Tabl.RowCount; i++)
            {
                for (int j = 2; j < f.Tabl.ColumnCount; j++)
                {
                    if (f.Tabl[j, i].Value != null && f.Tabl[j, i].Value.ToString() != "")
                    {
                    all_lessons.Add(f.Tabl[j, i].Value.ToString());
                    }
                }
            }
        }
        public void spis(Form1 f)
        {
            f.tabl_znach.Items.Clear();
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
