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
        missing miss = new missing();
        input input = new input();
        tabl t = new tabl();

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

        private void check_Click(object sender, EventArgs e)
        {
            miss.inp(missing.Text);
            t.inp(this);
        }

        private void missing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (miss.inp(missing.Text) == 1)
                {
                    missing_teachers.Text += missing.Text + "\r\n";
                }
                missing.Text = "";
            }
        }




        private void tabl_znach_MouseDown(object sender, MouseEventArgs e)
        {
            t.spis(this);
        }

        private void del_Click(object sender, EventArgs e)
        {
            t.dell(this);
        }

        private void klass_nom_MouseEnter(object sender, EventArgs e)
        {
            ToolTip to = new ToolTip();
            to.SetToolTip(klass_nom,"Введите номера классов через запятую.");
            
        }

        private void klass_nom_KeyDown(object sender, KeyEventArgs e)
        {
            t.dell(this);
            klass_nom.Text = "";
            
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            input.inp(this);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        int  b;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                b = 8;
                for (int i = 1; i < b; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Tabl[j, i].Value = "";
                    }
                }}
            else
               input.inp(this); 
        }



    }
}
