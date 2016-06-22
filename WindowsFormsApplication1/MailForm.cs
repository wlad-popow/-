using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MailForm : Form
    {
        public static bool flag = false;
       // private string filename;

        public MailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string smtp = "";
            string from1, pass1, to1, tt, tema;

            if (smtpServer.SelectedIndex == 0)
            {
                smtp = "smtp.mail.ru";
            }
            else
            {
                if (smtpServer.SelectedIndex == 1)
                {
                    smtp = "smtp.yandex.ru";
                }
            }
            from1 = from.Text;
            pass1 = password.Text;
            to1 = mailto.Text;
            tema = caption.Text;
            tt = message.Text;
            
            MailMessage mail = new MailMessage(from1, to1, tema, tt);
            SmtpClient client = new SmtpClient(smtp);
            client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential(from1, pass1);
            client.EnableSsl = true;

            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel (*.XLS;*.XLSX)|*.XLS;*.XLSX";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                filename = openFileDialog1.FileName;
                sr.Close();
            }
            else
            {
                return;
            }

            Attachment attachData = new Attachment(filename);
            mail.Attachments.Add(attachData);
            client.Send(mail);
             MessageBox.Show("Письмо отправлено");
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
         /*   string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel (*.XLS;*.XLSX)|*.XLS;*.XLSX";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                filename = openFileDialog1.FileName;
                sr.Close();
            }
            else
            {
                return;
            }*/
        }
    }
}
