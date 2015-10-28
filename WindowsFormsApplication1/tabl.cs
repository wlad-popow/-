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
                    Console.WriteLine(f.Tabl[i, j].Value.ToString());
                }
            }
        }
    }
}
