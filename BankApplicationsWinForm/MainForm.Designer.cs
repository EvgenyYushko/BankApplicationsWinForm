namespace BankApplicationsWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelPer = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bSkip = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bPut = new System.Windows.Forms.Button();
            this.bWithdraw = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.labelPer);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 58);
            this.panel1.TabIndex = 0;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(251, 34);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(48, 13);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "labelDay";
            // 
            // labelPer
            // 
            this.labelPer.AutoSize = true;
            this.labelPer.Location = new System.Drawing.Point(5, 34);
            this.labelPer.Name = "labelPer";
            this.labelPer.Size = new System.Drawing.Size(45, 13);
            this.labelPer.TabIndex = 1;
            this.labelPer.Text = "labelPer";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfo.Location = new System.Drawing.Point(3, 8);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(47, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "labelInfo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.bRefresh);
            this.panel2.Controls.Add(this.bSkip);
            this.panel2.Controls.Add(this.bClose);
            this.panel2.Controls.Add(this.bPut);
            this.panel2.Controls.Add(this.bWithdraw);
            this.panel2.Controls.Add(this.bOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 176);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(133, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(76, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "сумма:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(76, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "проценты:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(76, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "дни:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 154);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRefresh.Location = new System.Drawing.Point(329, 115);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 34);
            this.bRefresh.TabIndex = 10;
            this.bRefresh.Text = "bRefresh";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSkip
            // 
            this.bSkip.Location = new System.Drawing.Point(6, 125);
            this.bSkip.Name = "bSkip";
            this.bSkip.Size = new System.Drawing.Size(109, 23);
            this.bSkip.TabIndex = 4;
            this.bSkip.Text = "Пропустить день";
            this.bSkip.UseVisualStyleBackColor = true;
            this.bSkip.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.bSkip.Click += new System.EventHandler(this.bSkip_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(6, 96);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(109, 23);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Закрыть счет";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bPut
            // 
            this.bPut.Location = new System.Drawing.Point(6, 67);
            this.bPut.Name = "bPut";
            this.bPut.Size = new System.Drawing.Size(109, 23);
            this.bPut.TabIndex = 2;
            this.bPut.Text = "Добавить на счет";
            this.bPut.UseVisualStyleBackColor = true;
            this.bPut.Click += new System.EventHandler(this.bPut_Click);
            // 
            // bWithdraw
            // 
            this.bWithdraw.Location = new System.Drawing.Point(6, 38);
            this.bWithdraw.Name = "bWithdraw";
            this.bWithdraw.Size = new System.Drawing.Size(109, 23);
            this.bWithdraw.TabIndex = 1;
            this.bWithdraw.Text = "Вывести средства";
            this.bWithdraw.UseVisualStyleBackColor = true;
            this.bWithdraw.Click += new System.EventHandler(this.bWithdraw_Click);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(6, 9);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(109, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Открыть счет";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 235);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bPut;
        private System.Windows.Forms.Button bWithdraw;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bSkip;
        public System.Windows.Forms.Label labelPer;
        public System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

