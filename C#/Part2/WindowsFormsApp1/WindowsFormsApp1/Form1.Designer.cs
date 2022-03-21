
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.tbT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9,
            this.c10,
            this.c11,
            this.c12,
            this.c13,
            this.c14,
            this.c15});
            this.dgv.Location = new System.Drawing.Point(59, 93);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1081, 150);
            this.dgv.TabIndex = 1;
            //this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            //this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_CellValidating);
            // 
            // c1
            // 
            this.c1.Frozen = true;
            this.c1.HeaderText = "0";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 50;
            // 
            // c2
            // 
            this.c2.Frozen = true;
            this.c2.HeaderText = "1";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.Width = 50;
            // 
            // c3
            // 
            this.c3.Frozen = true;
            this.c3.HeaderText = "2";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.Width = 50;
            // 
            // c4
            // 
            this.c4.Frozen = true;
            this.c4.HeaderText = "3";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.Width = 50;
            // 
            // c5
            // 
            this.c5.Frozen = true;
            this.c5.HeaderText = "4";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.Width = 50;
            // 
            // c6
            // 
            this.c6.Frozen = true;
            this.c6.HeaderText = "5";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            this.c6.Width = 50;
            // 
            // c7
            // 
            this.c7.Frozen = true;
            this.c7.HeaderText = "6";
            this.c7.MinimumWidth = 6;
            this.c7.Name = "c7";
            this.c7.Width = 50;
            // 
            // c8
            // 
            this.c8.Frozen = true;
            this.c8.HeaderText = "7";
            this.c8.MinimumWidth = 6;
            this.c8.Name = "c8";
            this.c8.Width = 50;
            // 
            // c9
            // 
            this.c9.Frozen = true;
            this.c9.HeaderText = "8";
            this.c9.MinimumWidth = 6;
            this.c9.Name = "c9";
            this.c9.Width = 50;
            // 
            // c10
            // 
            this.c10.Frozen = true;
            this.c10.HeaderText = "9";
            this.c10.MinimumWidth = 6;
            this.c10.Name = "c10";
            this.c10.Width = 50;
            // 
            // c11
            // 
            this.c11.Frozen = true;
            this.c11.HeaderText = "10";
            this.c11.MinimumWidth = 6;
            this.c11.Name = "c11";
            this.c11.Width = 50;
            // 
            // c12
            // 
            this.c12.Frozen = true;
            this.c12.HeaderText = "11";
            this.c12.MinimumWidth = 6;
            this.c12.Name = "c12";
            this.c12.Width = 50;
            // 
            // c13
            // 
            this.c13.Frozen = true;
            this.c13.HeaderText = "12";
            this.c13.MinimumWidth = 6;
            this.c13.Name = "c13";
            this.c13.Width = 50;
            // 
            // c14
            // 
            this.c14.Frozen = true;
            this.c14.HeaderText = "13";
            this.c14.MinimumWidth = 6;
            this.c14.Name = "c14";
            this.c14.Width = 50;
            // 
            // c15
            // 
            this.c15.Frozen = true;
            this.c15.HeaderText = "14";
            this.c15.MinimumWidth = 6;
            this.c15.Name = "c15";
            this.c15.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнение массива";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "2.1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "2.2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(374, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите число";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(374, 342);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 22);
            this.tbC.TabIndex = 9;
            this.tbC.Validating += new System.ComponentModel.CancelEventHandler(this.tbC_Validating);
            // 
            // tmr
            // 
            this.tmr.Tag = "-1";
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(320, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "Заполнение по таймеру";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(566, 32);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(142, 22);
            this.tbT.TabIndex = 11;
            this.tbT.Validating += new System.ComponentModel.CancelEventHandler(this.tbT_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Скорость изменения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c9;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10;
        private System.Windows.Forms.DataGridViewTextBoxColumn c11;
        private System.Windows.Forms.DataGridViewTextBoxColumn c12;
        private System.Windows.Forms.DataGridViewTextBoxColumn c13;
        private System.Windows.Forms.DataGridViewTextBoxColumn c14;
        private System.Windows.Forms.DataGridViewTextBoxColumn c15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.Label label2;
    }
}

