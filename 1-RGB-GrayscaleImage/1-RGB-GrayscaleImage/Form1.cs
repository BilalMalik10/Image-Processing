using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_RGB_GrayscaleImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
                textBox1.Text = openFile.FileName.ToString();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Bitmap grayScaleImg = new Bitmap(bmp.Width, bmp.Height);
            int avg = 0;
            for (int row = 0; row < bmp.Width; row++)
            {
                for (int col = 0; col < bmp.Height; col++)
                {
                    avg = 0;
                    Color pixel = bmp.GetPixel(row,col);

                    avg = (pixel.R + pixel.G + pixel.B) / 3;
                    grayScaleImg.SetPixel(row, col, Color.FromArgb(avg, avg, avg));

                }
            }
            pictureBox1.Image = grayScaleImg;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
