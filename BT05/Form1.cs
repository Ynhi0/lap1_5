using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar<='9')|| e.KeyChar == (char)8)
            {
                e.Handled = true;
            }
            
        }
        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                if(!string.IsNullOrWhiteSpace(textBox1.Text) &&
                    !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = (char)0;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.AutomaticDelay = 100;
            toolTip1.ShowAlways = true;
            toolTip2.AutomaticDelay = 100;
            toolTip2.ShowAlways = true;
            toolTip1.ToolTipTitle = "Hướng Dẫn Sử Dụng";
            toolTip1.SetToolTip(textBox1, "Chỉ nhập được ký tự a-z và 0-9");
            toolTip2.SetToolTip(textBox2, "Chỉ được nhập kí tự từ 0-9");
            helpProvider1.HelpNamespace = 
                "https://plpsoft.vn/30236-Bai-tap-C-Bai-5-Su-dung-ToolTip-HelpProvider-ErrorProvider-trong-C-windows-Form";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình"
                , "Hỏi Người Dùng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

     
    }
}
