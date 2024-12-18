namespace age_calculater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            yrs = new Label();
            wks = new Label();
            label6 = new Label();
            label7 = new Label();
            hrs = new Label();
            label9 = new Label();
            mon = new Label();
            dys = new Label();
            label12 = new Label();
            min = new Label();
            label14 = new Label();
            sec = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 19);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "currentyear";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(402, 115);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 69);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "birthyear";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 203);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "years";
            // 
            // yrs
            // 
            yrs.AutoSize = true;
            yrs.Location = new Point(255, 203);
            yrs.Name = "yrs";
            yrs.Size = new Size(50, 20);
            yrs.TabIndex = 6;
            yrs.Text = "label4";
            // 
            // wks
            // 
            wks.AutoSize = true;
            wks.Location = new Point(478, 203);
            wks.Name = "wks";
            wks.Size = new Size(50, 20);
            wks.TabIndex = 8;
            wks.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 203);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 7;
            label6.Text = "weeks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(625, 203);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 10;
            label7.Text = "hours";
            // 
            // hrs
            // 
            hrs.AutoSize = true;
            hrs.Location = new Point(701, 203);
            hrs.Name = "hrs";
            hrs.Size = new Size(50, 20);
            hrs.TabIndex = 9;
            hrs.Text = "label8";
            hrs.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(180, 270);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 12;
            label9.Text = "month";
            // 
            // mon
            // 
            mon.AutoSize = true;
            mon.Location = new Point(251, 270);
            mon.Name = "mon";
            mon.Size = new Size(58, 20);
            mon.TabIndex = 11;
            mon.Text = "label10";
            mon.Click += label10_Click;
            // 
            // dys
            // 
            dys.AutoSize = true;
            dys.Location = new Point(477, 279);
            dys.Name = "dys";
            dys.Size = new Size(58, 20);
            dys.TabIndex = 14;
            dys.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(402, 279);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 13;
            label12.Text = "days";
            // 
            // min
            // 
            min.AutoSize = true;
            min.Location = new Point(700, 279);
            min.Name = "min";
            min.Size = new Size(58, 20);
            min.TabIndex = 16;
            min.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(625, 279);
            label14.Name = "label14";
            label14.Size = new Size(61, 20);
            label14.TabIndex = 15;
            label14.Text = "minutes";
            // 
            // sec
            // 
            sec.AutoSize = true;
            sec.Location = new Point(899, 233);
            sec.Name = "sec";
            sec.Size = new Size(58, 20);
            sec.TabIndex = 18;
            sec.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(824, 233);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 17;
            label16.Text = "seconds";
            label16.Click += label16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 450);
            Controls.Add(sec);
            Controls.Add(label16);
            Controls.Add(min);
            Controls.Add(label14);
            Controls.Add(dys);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(mon);
            Controls.Add(label7);
            Controls.Add(hrs);
            Controls.Add(wks);
            Controls.Add(label6);
            Controls.Add(yrs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label yrs;
        private Label wks;
        private Label label6;
        private Label label7;
        private Label hrs;
        private Label label9;
        private Label mon;
        private Label dys;
        private Label label12;
        private Label min;
        private Label label14;
        private Label sec;
        private Label label16;
    }
}
