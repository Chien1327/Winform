using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Phantucoban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.R_But_F_Orange.CheckedChanged += new System.EventHandler(this.R_But_F_Orange_CheckedChanged);
            this.R_But_F_Blue.CheckedChanged += new System.EventHandler(this.R_But_F_Orange_CheckedChanged);
            this.R_But_F_Red.CheckedChanged += new System.EventHandler(this.R_But_F_Orange_CheckedChanged);
            // 
            this.R_But_B_Orange.CheckedChanged += new System.EventHandler(this.R_But_B_Orange_CheckedChanged);
            this.R_But_B_Blue.CheckedChanged += new System.EventHandler(this.R_But_B_Orange_CheckedChanged);
            this.R_But_B_Red.CheckedChanged += new System.EventHandler(this.R_But_B_Orange_CheckedChanged);
            //
            this.CheckBox_Game.CheckedChanged += new System.EventHandler(this.CheckBox_Game_CheckedChanged);
            this.CheckBox_Hoc.CheckedChanged += new System.EventHandler(this.CheckBox_Game_CheckedChanged);
            this.CheckBox_Tien.CheckedChanged += new System.EventHandler(this.CheckBox_Game_CheckedChanged);
        }

        private void D_Button1_Click(object sender, EventArgs e) // Nút Cộng
        {
            int Result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            TextBox_Ketqua.Text = Result.ToString();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Tru_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            TextBox_Ketqua.Text = Result.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
            {
                e.Handled = true;
            }
        }

        private void TextBox_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Nhan_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            TextBox_Ketqua.Text = Result.ToString();
        }

        private void Button_Chia_Click(object sender, EventArgs e)
        {
            Double Result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            TextBox_Ketqua.Text = Result.ToString();
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            TextBox_Ketqua.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void R_But_F_Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (R_But_F_Orange.Checked == true)
            {
                textBox3.ForeColor = Color.Orange;
            }
            else if (R_But_F_Blue.Checked == true)
            {
                textBox3.ForeColor = Color.Blue;
            }
            else if (R_But_F_Red.Checked == true)
            {
                textBox3.ForeColor = Color.Red;
            }
            else
            {
                textBox3.ForeColor = Color.Black;
            }
        }

        private void R_But_B_Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (R_But_B_Orange.Checked)
            {
                textBox3.BackColor = Color.Orange;
            }
            else if (R_But_B_Blue.Checked)
            {
                textBox3.BackColor = Color.Blue;
            }
            else if (R_But_B_Red.Checked)
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
        }

        private void CheckBox_Game_CheckedChanged(object sender, EventArgs e)
        {
            // Đảm bảo rằng chỉ một CheckBox được chọn tại một thời điểm
            if (CheckBox_Game.Checked && CheckBox_Hoc.Checked)
            {
                // Nếu cả CheckBox_Game và CheckBox_Hoc đều được chọn
                CheckBox_Tien.Checked = false;
            }
            else if (CheckBox_Hoc.Checked && CheckBox_Tien.Checked)
            {
                // Nếu cả CheckBox_Hoc và CheckBox_Tien đều được chọn
                CheckBox_Game.Checked = false;
            }
            else if (CheckBox_Game.Checked && CheckBox_Tien.Checked)
            {
                // Nếu cả CheckBox_Game và CheckBox_Tien đều được chọn
                CheckBox_Hoc.Checked = false;
            }
        }
    }
}
