namespace WindowsFormsApplication1
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mailto = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.caption = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.smtpServer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Прикрепить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mailto
            // 
            this.mailto.Location = new System.Drawing.Point(264, 74);
            this.mailto.Name = "mailto";
            this.mailto.Size = new System.Drawing.Size(100, 20);
            this.mailto.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(265, 36);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 5;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(264, 9);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 20);
            this.from.TabIndex = 6;
            // 
            // caption
            // 
            this.caption.Location = new System.Drawing.Point(264, 131);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(100, 20);
            this.caption.TabIndex = 7;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(10, 178);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(482, 153);
            this.message.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес получателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Адрес отправителя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль к почтовому ящику отправителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тема письма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сообщение";
            // 
            // smtpServer
            // 
            this.smtpServer.FormattingEnabled = true;
            this.smtpServer.Items.AddRange(new object[] {
            "@mail.ru",
            "@yandex.ru"});
            this.smtpServer.Location = new System.Drawing.Point(264, 100);
            this.smtpServer.Name = "smtpServer";
            this.smtpServer.Size = new System.Drawing.Size(100, 21);
            this.smtpServer.TabIndex = 16;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 372);
            this.Controls.Add(this.smtpServer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.from);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mailto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mailto;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox caption;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox smtpServer;
    }
}