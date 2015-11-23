namespace WindowsFormsApplication1
{
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Класс формы программы.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Объект класса Input.
        /// </summary>
        Input input = new Input();

        /// <summary>
        /// Объект класса Tabl.
        /// </summary>
        Tabl t = new Tabl();

        /// <summary>
        /// Объект класса Algoritm.
        /// </summary>
        Algoritm alg = new Algoritm();

        public Form1()
        {
            InitializeComponent();

            Tabl.ColumnCount = 13;
            Tabl.RowCount = 35;

        }

        public void Toggle()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tabl_znach_MouseDown(object sender, MouseEventArgs e)
        {
            this.t.Inp(this);
            this.t.Spis(this);
        }

        private void DelClick(object sender, EventArgs e)
        {
            this.t.Dell(this);
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.input.Inp(this);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Toggle();
        }

        int b, a;
        int c = 0;

        public void ud()
        {
            for (; this.a < this.b; this.a++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Tabl[j, this.a].Value = null;
                }
            }
        }
        private void vos()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = this.c; j < this.b; j++)
                {
                    (Tabl[i, j].Value) = this.input.Tab[j][i];
                }
            }


        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.a = 1;
                this.b = 8;
                this.ud();
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        (Tabl[i, j].Value) = this.input.Tab[j][i];
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.a = 8;
                this.b = 15;
                this.ud();
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 8; j < 15; j++)
                    {
                        (Tabl[i, j].Value) = this.input.Tab[j][i];
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.a = 15;
                this.b = 22;
                this.ud();
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 15; j < 22; j++)
                    {
                        (Tabl[i, j].Value) = this.input.Tab[j][i];
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.a = 22;
                this.b = 29;
                this.ud();
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 22; j < 29; j++)
                    {
                        (Tabl[i, j].Value) = this.input.Tab[j][i];
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                this.a = 29;
                this.b = 36;
                this.ud();
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 29; j < 36; j++)
                    {
                        (Tabl[i, j].Value) = this.input.Tab[j][i];
                    }
                }
            }
        }

        private void Redaktor_Click(object sender, EventArgs e)
        {
            this.alg.Perestanovka(this);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бетка самой лучшей программы...");
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справка");
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
