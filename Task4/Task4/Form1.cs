using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles = new List<string>();
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImagesFromFolder();
            ShowImage();
        }

        private void LoadImagesFromFolder()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (Directory.Exists(path))
            {
                imageFiles = Directory.GetFiles(path, "*.*")
                    .Where(file => file.ToLower().EndsWith(".jpg") ||
                                   file.ToLower().EndsWith(".jpeg") ||
                                   file.ToLower().EndsWith(".png") ||
                                   file.ToLower().EndsWith(".bmp"))
                    .ToList();
            }
        }

        private void ShowImage()
        {
            if (imageFiles.Count > 0)
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]);
                this.Text = $"Фото {currentIndex + 1} з {imageFiles.Count}";
            }
            else
            {
                MessageBox.Show("У папці немає зображень!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count == 0) return;

            currentIndex++;
            if (currentIndex >= imageFiles.Count) currentIndex = 0; 
            ShowImage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0) currentIndex = imageFiles.Count - 1;
            ShowImage();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img; 
            }
        }
    }
}