using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class test_match
    {
        public bool testMatch(List<string> a, string b)
        {
            int kol = 0;
            bool flag = true;
            foreach (string g in a)
            {
                if (g.Length == b.Length)
                {
                    for (int i = 0; i < g.Length; i++)
                    {
                        if (g[i] == b[i])
                            kol++;
                    }
                    if (kol == g.Length)
                    {
                        a.Remove(b);
                        flag = false;
                        break;
                    }
                    kol = 0;
                }
            }
            return flag;
        }
    }
}
