using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superproga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Name1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    throw;
                }
            }
        }
        private void Reform_Click(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            string str = "";
            for (int y = 0; y < bitmap.Height; y++)
            {
                str = "";
                for (int x = 0;  x < bitmap.Width;  x++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    int mean = (pixel.R + pixel.G + pixel.B)/3;
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, mean, mean, mean));
                    str += chek(mean);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Admin\Desktop\Foto.txt", true))
                {
                    writer.Write(str);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Admin\Desktop\Foto.txt", true))
                {
                    writer.Write("\n");
                }

            }
            pictureBox2.Image = bitmap;
        }




        static char chek(int i)
        {
            if (i < 25)
            {
                return '.';
            }
            else if (i < 51)
            {
                return ',';
            }
            else if (i < 76)
            {
                return ':';
            }
            else if (i < 102)
            {
                return '+';
            }
            else if (i < 127)
            {
                return '*';
            }
            else if (i < 153)
            {
                return '?';
            }
            else if (i < 178)
            {
                return '%';
            }
            else if (i < 204)
            {
                return 'S';
            }
            else if (i < 229)
            {
                return '#';
            }
            return '@';
        }
    }
}
