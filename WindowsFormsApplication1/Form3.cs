using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.textBox1.Text = "Версия 1.0" + Environment.NewLine + "Авторы: UpturnedChair" + Environment.NewLine + "All rights ignored";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
