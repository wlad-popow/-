﻿namespace WindowsFormsApplication1
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
            this.Tabl = new System.Windows.Forms.DataGridView();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.missing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabl
            // 
            this.Tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl.Location = new System.Drawing.Point(12, 12);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(1342, 201);
            this.Tabl.TabIndex = 0;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.button2);
            this.StartPanel.Controls.Add(this.button1);
            this.StartPanel.Location = new System.Drawing.Point(12, 12);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1617, 257);
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
            this.check.Location = new System.Drawing.Point(1360, 161);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(254, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1360, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // missing
            // 
            this.missing.Location = new System.Drawing.Point(1360, 28);
            this.missing.Multiline = true;
            this.missing.Name = "missing";
            this.missing.Size = new System.Drawing.Size(254, 127);
            this.missing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1360, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отсутствующие преподаватели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 276);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missing);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.check);
            this.Controls.Add(this.button4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabl;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox missing;

    }
}

