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
        test_match t = new test_match();
        List<string> ss = new List<string>();
        public int inp(string text)
    {
            int flag=1;
            if (t.testMatch(ss, text) == true)
                flag = 1;
            else
                flag = 0;
        ss.Add(text);
        return flag;
            //Console.WriteLine(s);
    }
    }
}
