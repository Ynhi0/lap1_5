using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = " ";
            if(checkBox1.Checked == true)
            {
                str = checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                str = str + ", "+ checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                str = str+ ", " + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                str = str + ", " + checkBox4.Text + "\n";
            }
            if (checkBox5.Checked == true)
            {
                str = str + ", " + checkBox5.Text + "\n";
            }
            if(str.Length >0)
            {
                MessageBox.Show("Sở thích của bạn là: " + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào được chọn!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            if(radioButton1.Checked == true)
            {
                str = radioButton1.Text + "\n";
            }
            if(radioButton2.Checked == true)
            {
                str = radioButton2.Text + "\n";
            }
            if (radioButton3.Checked == true)
            {
                str =  radioButton3.Text + "\n";
            }
            if (radioButton4.Checked == true)
            {
                str =  radioButton4.Text + "\n";
            }
            if (radioButton5.Checked == true)
            {
                str = radioButton5.Text + "\n";
            }
            if(str.Length > 0)
            {
                MessageBox.Show("Màu yêu thích của bạn : " + str);
            }
            else
            {
                MessageBox.Show("Không có màu được chọn!");
            }
        }
    }
}
