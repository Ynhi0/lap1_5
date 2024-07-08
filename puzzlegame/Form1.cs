using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzlegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cats");
            comboBox1.Items.Add("Animation");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Nature");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn mở chương trình không?",
                "Hỏi người dùng",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.Cancel)
            {
                Dispose();
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng chương trình?",
                    "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
