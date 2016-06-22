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
        public MailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string smtp = "";
            string file = "C:\\1.txt";

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
            
            MailMessage mail = new MailMessage("от кого", "кому", "Тема письма", "Тело письма");// в первых 2 параметрах должен быть емайл полностью типа : wlad-popow@mail.ru
            SmtpClient client = new SmtpClient(smtp);
            client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential("uzername", "password");// в первом параметре должено быть емайл полностью типа : wlad-popow@mail.ru и пароль от почты отправителя
            client.EnableSsl = true;

            mail.Attachments.Add(new Attachment("C:\\1.txt"));//путь к файлу...
            client.Send(mail);
            MessageBox.Show("yes");
        }
    }
}
