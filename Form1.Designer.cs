namespace WinForm_Phantucoban
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Ketqua = new System.Windows.Forms.TextBox();
            this.Button_Del = new System.Windows.Forms.Button();
            this.Button_Chia = new System.Windows.Forms.Button();
            this.Button_Nhan = new System.Windows.Forms.Button();
            this.Button_Tru = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Cong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.R_But_F_Orange = new System.Windows.Forms.RadioButton();
            this.R_But_F_Blue = new System.Windows.Forms.RadioButton();
            this.R_But_F_Red = new System.Windows.Forms.RadioButton();
            this.R_But_B_Red = new System.Windows.Forms.RadioButton();
            this.R_But_B_Blue = new System.Windows.Forms.RadioButton();
            this.R_But_B_Orange = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CheckBox_Game = new System.Windows.Forms.CheckBox();
            this.CheckBox_Hoc = new System.Windows.Forms.CheckBox();
            this.CheckBox_Tien = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBox_Ketqua);
            this.groupBox1.Controls.Add(this.Button_Del);
            this.groupBox1.Controls.Add(this.Button_Chia);
            this.groupBox1.Controls.Add(this.Button_Nhan);
            this.groupBox1.Controls.Add(this.Button_Tru);
            this.groupBox1.Controls.Add(this.Button_Exit);
            this.groupBox1.Controls.Add(this.Button_Cong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculater_Lable_Button_Textbox";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số thứ 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số thứ 1";
            // 
            // TextBox_Ketqua
            // 
            this.TextBox_Ketqua.Location = new System.Drawing.Point(91, 153);
            this.TextBox_Ketqua.Name = "TextBox_Ketqua";
            this.TextBox_Ketqua.Size = new System.Drawing.Size(115, 20);
            this.TextBox_Ketqua.TabIndex = 7;
            this.TextBox_Ketqua.TextChanged += new System.EventHandler(this.TextBox_Ketqua_TextChanged);
            // 
            // Button_Del
            // 
            this.Button_Del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Del.Location = new System.Drawing.Point(283, 116);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.Size = new System.Drawing.Size(45, 23);
            this.Button_Del.TabIndex = 5;
            this.Button_Del.Text = "Del";
            this.Button_Del.UseVisualStyleBackColor = true;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Button_Chia
            // 
            this.Button_Chia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Chia.Location = new System.Drawing.Point(221, 116);
            this.Button_Chia.Name = "Button_Chia";
            this.Button_Chia.Size = new System.Drawing.Size(45, 23);
            this.Button_Chia.TabIndex = 1;
            this.Button_Chia.Text = "/";
            this.Button_Chia.UseVisualStyleBackColor = true;
            this.Button_Chia.Click += new System.EventHandler(this.Button_Chia_Click);
            // 
            // Button_Nhan
            // 
            this.Button_Nhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Nhan.Location = new System.Drawing.Point(153, 116);
            this.Button_Nhan.Name = "Button_Nhan";
            this.Button_Nhan.Size = new System.Drawing.Size(45, 23);
            this.Button_Nhan.TabIndex = 4;
            this.Button_Nhan.Text = "*";
            this.Button_Nhan.UseVisualStyleBackColor = true;
            this.Button_Nhan.Click += new System.EventHandler(this.Button_Nhan_Click);
            // 
            // Button_Tru
            // 
            this.Button_Tru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Tru.Location = new System.Drawing.Point(88, 116);
            this.Button_Tru.Name = "Button_Tru";
            this.Button_Tru.Size = new System.Drawing.Size(45, 23);
            this.Button_Tru.TabIndex = 3;
            this.Button_Tru.Text = "-";
            this.Button_Tru.UseVisualStyleBackColor = true;
            this.Button_Tru.Click += new System.EventHandler(this.Button_Tru_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(253, 151);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 23);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "EXIT";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Cong
            // 
            this.Button_Cong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cong.Location = new System.Drawing.Point(23, 116);
            this.Button_Cong.Name = "Button_Cong";
            this.Button_Cong.Size = new System.Drawing.Size(45, 23);
            this.Button_Cong.TabIndex = 0;
            this.Button_Cong.Text = "+";
            this.Button_Cong.UseVisualStyleBackColor = true;
            this.Button_Cong.Click += new System.EventHandler(this.D_Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RadioButton";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(208, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CheckBox";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 24);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "PREVIEW";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.R_But_F_Red);
            this.groupBox4.Controls.Add(this.R_But_F_Blue);
            this.groupBox4.Controls.Add(this.R_But_F_Orange);
            this.groupBox4.Location = new System.Drawing.Point(8, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(74, 116);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ForeColor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.R_But_B_Orange);
            this.groupBox5.Controls.Add(this.R_But_B_Blue);
            this.groupBox5.Controls.Add(this.R_But_B_Red);
            this.groupBox5.Location = new System.Drawing.Point(97, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(74, 116);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BackColor";
            // 
            // R_But_F_Orange
            // 
            this.R_But_F_Orange.AutoSize = true;
            this.R_But_F_Orange.Location = new System.Drawing.Point(5, 19);
            this.R_But_F_Orange.Name = "R_But_F_Orange";
            this.R_But_F_Orange.Size = new System.Drawing.Size(60, 17);
            this.R_But_F_Orange.TabIndex = 0;
            this.R_But_F_Orange.TabStop = true;
            this.R_But_F_Orange.Text = "Orange";
            this.R_But_F_Orange.UseVisualStyleBackColor = true;
            this.R_But_F_Orange.CheckedChanged += new System.EventHandler(this.R_But_F_Orange_CheckedChanged);
            // 
            // R_But_F_Blue
            // 
            this.R_But_F_Blue.AutoSize = true;
            this.R_But_F_Blue.Location = new System.Drawing.Point(5, 48);
            this.R_But_F_Blue.Name = "R_But_F_Blue";
            this.R_But_F_Blue.Size = new System.Drawing.Size(46, 17);
            this.R_But_F_Blue.TabIndex = 1;
            this.R_But_F_Blue.TabStop = true;
            this.R_But_F_Blue.Text = "Blue";
            this.R_But_F_Blue.UseVisualStyleBackColor = true;
            // 
            // R_But_F_Red
            // 
            this.R_But_F_Red.AutoSize = true;
            this.R_But_F_Red.Location = new System.Drawing.Point(5, 78);
            this.R_But_F_Red.Name = "R_But_F_Red";
            this.R_But_F_Red.Size = new System.Drawing.Size(45, 17);
            this.R_But_F_Red.TabIndex = 2;
            this.R_But_F_Red.TabStop = true;
            this.R_But_F_Red.Text = "Red";
            this.R_But_F_Red.UseVisualStyleBackColor = true;
            // 
            // R_But_B_Red
            // 
            this.R_But_B_Red.AutoSize = true;
            this.R_But_B_Red.Location = new System.Drawing.Point(9, 78);
            this.R_But_B_Red.Name = "R_But_B_Red";
            this.R_But_B_Red.Size = new System.Drawing.Size(45, 17);
            this.R_But_B_Red.TabIndex = 5;
            this.R_But_B_Red.TabStop = true;
            this.R_But_B_Red.Text = "Red";
            this.R_But_B_Red.UseVisualStyleBackColor = true;
            // 
            // R_But_B_Blue
            // 
            this.R_But_B_Blue.AutoSize = true;
            this.R_But_B_Blue.Location = new System.Drawing.Point(9, 48);
            this.R_But_B_Blue.Name = "R_But_B_Blue";
            this.R_But_B_Blue.Size = new System.Drawing.Size(46, 17);
            this.R_But_B_Blue.TabIndex = 4;
            this.R_But_B_Blue.TabStop = true;
            this.R_But_B_Blue.Text = "Blue";
            this.R_But_B_Blue.UseVisualStyleBackColor = true;
            // 
            // R_But_B_Orange
            // 
            this.R_But_B_Orange.AutoSize = true;
            this.R_But_B_Orange.Location = new System.Drawing.Point(9, 19);
            this.R_But_B_Orange.Name = "R_But_B_Orange";
            this.R_But_B_Orange.Size = new System.Drawing.Size(60, 17);
            this.R_But_B_Orange.TabIndex = 3;
            this.R_But_B_Orange.TabStop = true;
            this.R_But_B_Orange.Text = "Orange";
            this.R_But_B_Orange.UseVisualStyleBackColor = true;
            this.R_But_B_Orange.CheckedChanged += new System.EventHandler(this.R_But_B_Orange_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kết quả";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CheckBox_Tien);
            this.groupBox6.Controls.Add(this.CheckBox_Hoc);
            this.groupBox6.Controls.Add(this.CheckBox_Game);
            this.groupBox6.Location = new System.Drawing.Point(23, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 135);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Game";
            // 
            // CheckBox_Game
            // 
            this.CheckBox_Game.AutoSize = true;
            this.CheckBox_Game.Location = new System.Drawing.Point(19, 39);
            this.CheckBox_Game.Name = "CheckBox_Game";
            this.CheckBox_Game.Size = new System.Drawing.Size(54, 17);
            this.CheckBox_Game.TabIndex = 0;
            this.CheckBox_Game.Text = "Game";
            this.CheckBox_Game.UseVisualStyleBackColor = true;
            this.CheckBox_Game.CheckedChanged += new System.EventHandler(this.CheckBox_Game_CheckedChanged);
            // 
            // CheckBox_Hoc
            // 
            this.CheckBox_Hoc.AutoSize = true;
            this.CheckBox_Hoc.Location = new System.Drawing.Point(19, 69);
            this.CheckBox_Hoc.Name = "CheckBox_Hoc";
            this.CheckBox_Hoc.Size = new System.Drawing.Size(46, 17);
            this.CheckBox_Hoc.TabIndex = 1;
            this.CheckBox_Hoc.Text = "Học";
            this.CheckBox_Hoc.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Tien
            // 
            this.CheckBox_Tien.AutoSize = true;
            this.CheckBox_Tien.Location = new System.Drawing.Point(19, 99);
            this.CheckBox_Tien.Name = "CheckBox_Tien";
            this.CheckBox_Tien.Size = new System.Drawing.Size(47, 17);
            this.CheckBox_Tien.TabIndex = 2;
            this.CheckBox_Tien.Text = "Tiền";
            this.CheckBox_Tien.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Cong;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Tru;
        private System.Windows.Forms.Button Button_Del;
        private System.Windows.Forms.Button Button_Chia;
        private System.Windows.Forms.Button Button_Nhan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Ketqua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton R_But_B_Orange;
        private System.Windows.Forms.RadioButton R_But_B_Blue;
        private System.Windows.Forms.RadioButton R_But_B_Red;
        private System.Windows.Forms.RadioButton R_But_F_Red;
        private System.Windows.Forms.RadioButton R_But_F_Blue;
        private System.Windows.Forms.RadioButton R_But_F_Orange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox CheckBox_Tien;
        private System.Windows.Forms.CheckBox CheckBox_Hoc;
        private System.Windows.Forms.CheckBox CheckBox_Game;
    }
}

