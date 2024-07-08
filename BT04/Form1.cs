using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            // Thêm các tùy chọn vào ComboBox
            comboBox1.Items.Add("Tài Liệu");
            comboBox1.Items.Add("Dụng cụ học tập");
            comboBox1.Items.Add("Balo");
            comboBox1.SelectedIndex = 0;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // Thêm giá trị từ ComboBox vào ListBox
            if (comboBox1.SelectedItem != null && !String.IsNullOrEmpty(textBox1.Text))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    string item = textBox1.Text + " - " + comboBox1.SelectedItem;
                    listBox1.Items.Add(item);
                    textBox2.Text = listBox1.Items.Count.ToString();
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //xóa tất cả các thông tin trong listbox
            listBox1.Items.Clear();
            textBox2.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa thông tin đang chọn
            int a = Convert.ToInt32(textBox2.Text);
            if(listBox1.SelectedItems.Count !=0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            textBox2.Text = (a - 1).ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Xóa thông tin đầu tiên
            int a = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(0);
            textBox2.Text = (a - 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //xóa thông tin cuối
            int a = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            textBox2.Text = (a - 1).ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn mở chương trình",
                    "Hỏi người dùng", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question)== DialogResult.Cancel)
            {
                Dispose();
            }
        }
    }
}
