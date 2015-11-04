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
            this.check = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.missing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.missing_teachers = new System.Windows.Forms.Label();
            this.tabl_znach = new System.Windows.Forms.ComboBox();
            this.del = new System.Windows.Forms.Button();
            this.klass_nom = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabl
            // 
            this.Tabl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Tabl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl.Location = new System.Drawing.Point(12, 39);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(1029, 353);
            this.Tabl.TabIndex = 0;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(1072, 99);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(254, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1072, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // missing
            // 
            this.missing.Location = new System.Drawing.Point(1072, 185);
            this.missing.Name = "missing";
            this.missing.Size = new System.Drawing.Size(254, 20);
            this.missing.TabIndex = 4;
            this.missing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.missing_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1072, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "введи отсутствующего преподавателя";
            // 
            // missing_teachers
            // 
            this.missing_teachers.AutoSize = true;
            this.missing_teachers.Location = new System.Drawing.Point(1199, 39);
            this.missing_teachers.Name = "missing_teachers";
            this.missing_teachers.Size = new System.Drawing.Size(0, 13);
            this.missing_teachers.TabIndex = 6;
            // 
            // tabl_znach
            // 
            this.tabl_znach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabl_znach.FormattingEnabled = true;
            this.tabl_znach.Location = new System.Drawing.Point(1072, 39);
            this.tabl_znach.Name = "tabl_znach";
            this.tabl_znach.Size = new System.Drawing.Size(121, 21);
            this.tabl_znach.TabIndex = 7;
            this.tabl_znach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabl_znach_MouseDown);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(1072, 66);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(88, 27);
            this.del.TabIndex = 8;
            this.del.Text = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // klass_nom
            // 
            this.klass_nom.Location = new System.Drawing.Point(1205, 39);
            this.klass_nom.Name = "klass_nom";
            this.klass_nom.Size = new System.Drawing.Size(100, 20);
            this.klass_nom.TabIndex = 9;
            this.klass_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.klass_nom_KeyDown);
            this.klass_nom.MouseEnter += new System.EventHandler(this.klass_nom_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.открытьToolStripMenuItem.Text = "Создать...";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть...";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 404);
            this.Controls.Add(this.klass_nom);
            this.Controls.Add(this.del);
            this.Controls.Add(this.tabl_znach);
            this.Controls.Add(this.missing_teachers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missing);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.check);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox missing;
        public System.Windows.Forms.DataGridView Tabl;
        public System.Windows.Forms.ComboBox tabl_znach;
        private System.Windows.Forms.Button del;
        public System.Windows.Forms.Label missing_teachers;
        private System.Windows.Forms.TextBox klass_nom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

    }
}

