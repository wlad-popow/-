﻿using System;
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

        public bool Spanel {
            get { return StartPanel.Visible; }
        set{
            StartPanel.Visible = value;
        }
        }
        public Form1()
        {
            InitializeComponent();

            Tabl.ColumnCount = 13;
            Tabl.RowCount = 35;

            Spanel = true;
        }

        public void Toggle()
        {
            Spanel = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.inp(this);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
