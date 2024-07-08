using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_BuiThiYenNhi_2251012103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mở chương trình",
                "Hỏi Người Dùng", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + textBox1.Text);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình",
                "Hỏi Người Dùng", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)

            //Lưu ý: bật KeyPreview == true trước khi chạy Form

            {


                textBox1.Text = "Hello Freetuts.net !!!";

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                MessageBox.Show("Bạn vừa click chuột trái");

            }

            if (e.Button == MouseButtons.Right)

            {

                MessageBox.Show("Bạn vừa click chuột phải");

            }

            if (e.Button == MouseButtons.Middle)

            {

                MessageBox.Show("Bạn vừa click chuột giữa");

            }
        }
    }
}
