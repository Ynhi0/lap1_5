using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BT06
{

    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //tạo một bitmap mới với kích thước 400x400 pĩel
            bitmap = new Bitmap(390, 390);
            //thay đổi màu sắc của các pixel
            for (int x = 0; x < bitmap.Width; x++)
            {
                for(int y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(255, x % 256, y % 256, (x + y) % 256));
                }
            }
            //hiển thị Bitmap trên PictureBox'
            pictureBox1.Image = bitmap;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lưu bitmap vào tệp hình ảnh PNG
            bitmap.Save("Image.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Bitmap has been saved to 'image.png'. ");
        }
    }
}
