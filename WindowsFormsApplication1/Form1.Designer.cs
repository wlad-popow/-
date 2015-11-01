namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabl = new System.Windows.Forms.DataGridView();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.missing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.missing_teachers = new System.Windows.Forms.Label();
            this.tabl_znach = new System.Windows.Forms.ComboBox();
            this.del = new System.Windows.Forms.Button();
            this.klass_nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabl
            // 
            this.Tabl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Tabl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl.Location = new System.Drawing.Point(12, 12);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(1181, 380);
            this.Tabl.TabIndex = 0;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.button2);
            this.StartPanel.Controls.Add(this.button1);
            this.StartPanel.Location = new System.Drawing.Point(41, 269);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1641, 275);
            this.StartPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(812, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(802, 251);
            this.button2.TabIndex = 1;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(806, 251);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(1199, 81);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(254, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1199, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // missing
            // 
            this.missing.Location = new System.Drawing.Point(1202, 243);
            this.missing.Name = "missing";
            this.missing.Size = new System.Drawing.Size(254, 20);
            this.missing.TabIndex = 4;
            this.missing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.missing_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1202, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "введи отсутствующего преподавателя";
            // 
            // missing_teachers
            // 
            this.missing_teachers.AutoSize = true;
            this.missing_teachers.Location = new System.Drawing.Point(1326, 12);
            this.missing_teachers.Name = "missing_teachers";
            this.missing_teachers.Size = new System.Drawing.Size(0, 13);
            this.missing_teachers.TabIndex = 6;
            // 
            // tabl_znach
            // 
            this.tabl_znach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabl_znach.FormattingEnabled = true;
            this.tabl_znach.Location = new System.Drawing.Point(1199, 12);
            this.tabl_znach.Name = "tabl_znach";
            this.tabl_znach.Size = new System.Drawing.Size(121, 21);
            this.tabl_znach.TabIndex = 7;
            this.tabl_znach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabl_znach_MouseDown);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(1202, 39);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(88, 27);
            this.del.TabIndex = 8;
            this.del.Text = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // klass_nom
            // 
            this.klass_nom.Location = new System.Drawing.Point(1332, 12);
            this.klass_nom.Name = "klass_nom";
            this.klass_nom.Size = new System.Drawing.Size(100, 20);
            this.klass_nom.TabIndex = 9;
            this.klass_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.klass_nom_KeyDown);
            this.klass_nom.MouseEnter += new System.EventHandler(this.klass_nom_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 404);
            this.Controls.Add(this.klass_nom);
            this.Controls.Add(this.del);
            this.Controls.Add(this.tabl_znach);
            this.Controls.Add(this.missing_teachers);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missing);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.check);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox missing;
        public System.Windows.Forms.DataGridView Tabl;
        public System.Windows.Forms.ComboBox tabl_znach;
        private System.Windows.Forms.Button del;
        public System.Windows.Forms.Label missing_teachers;
        private System.Windows.Forms.TextBox klass_nom;

    }
}

