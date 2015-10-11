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
        public void inp(string text)
    {
        List<string> ss = new List<string>();
        string s = "";
        Form1 f = new Form1();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '\r')
            {
                i++;
                ss.Add(s);
                s = "";
            }
            else
            s += text[i];
        }
            //Console.WriteLine(s);
    }
    }
}
