using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Спочатку відкрийте зображення.");
                return;
            }

            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    grayImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox1.Image = grayImage;
            originalImage = grayImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Немає зображення для збереження.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage.Save(saveFileDialog1.FileName);
                MessageBox.Show("Зображення збережено.");
            }
        }
    }
}
