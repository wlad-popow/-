using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Необходимо добавлять комментарии к функциям в коде

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        input input = new input();
        tabl t = new tabl();
        algoritm alg = new algoritm();

      //  public bool Spanel {
       //     get { return StartPanel.Visible; }
      //  set{
       //     StartPanel.Visible = value;
       // }
       // }
        public Form1()
        {
            InitializeComponent();

            Tabl.ColumnCount = 13;
            Tabl.RowCount = 35;

            //Spanel = true;
        }

        public void Toggle()
        {
          //  Spanel = false;
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void tabl_znach_MouseDown(object sender, MouseEventArgs e)
        {
            t.inp(this);
            t.spis(this);
        }

        private void del_Click(object sender, EventArgs e)
        {
            t.dell(this);
        }
        
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            input.inp(this);            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        int  b, a;

        public void ud(){
         for (; a < b; a++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Tabl[j, a].Value = "";
                    }
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                a = 1;
                b = 8;
                ud();
               }
            else
               input.inp(this); 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                a = 8;
                b = 15;
                ud();
            }
            else
                input.inp(this); 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                a = 15;
                b = 22;
                ud();
            }
            else
                input.inp(this); 
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                a = 22;
                b = 29;
                ud();
            }
            else
                input.inp(this); 
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                a = 29;
                b = 36;
                ud();
            }
            else
                input.inp(this); 
        }

        private void Redaktor_Click(object sender, EventArgs e)
        {
            alg.perestanovka(this);
        }
    }
}
