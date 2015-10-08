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

        public bool Spanel {
            get { return StartPanel.Visible; }
        set{
            StartPanel.Visible = value;
        }
        }
        public Form1()
        {
            InitializeComponent();

            Tabl.ColumnCount = 11;
            Tabl.RowCount = 7;

            Spanel = true;
        }

        public void Toggle()
        {
            Spanel = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                sr.Close();
                Toggle();
            }
        }
    }
}
