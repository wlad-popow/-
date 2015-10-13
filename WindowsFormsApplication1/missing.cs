using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    class missing
    {
        List<string> ss = new List<string>();
        public int inp(string text)
    {
        int kol=0,flag=1;
        foreach(string g in ss)
        {
            if (g.Length == text.Length)
            {
                for (int i = 0; i < g.Length; i++)
                {
                    if (g[i] == text[i])
                        kol++;
                }
                if (kol == g.Length)
                {
                    ss.Remove(text);
                    flag = 0;
                    break;
                }
                kol = 0;
            }
        }
        ss.Add(text);
        return flag;
            //Console.WriteLine(s);
    }
    }
}
