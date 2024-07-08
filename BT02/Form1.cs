using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text)+
                Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mở chương trình",
                "Hỏi người dùng", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);

            textBox3.Text = result.ToString();
        }
    }
}
