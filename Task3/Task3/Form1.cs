using System;
using System.IO; 
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public Form1()
        {
            InitializeComponent();
            LoadImagesToList();
        }

        private void LoadImagesToList()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(folderPath);
                FileInfo[] files = d.GetFiles("*.*");

                foreach (FileInfo file in files)
                {
                    string ext = file.Extension.ToLower();
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
                    {
                        listBox1.Items.Add(file.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні списку: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFileName = listBox1.SelectedItem.ToString();
                string fullPath = Path.Combine(folderPath, selectedFileName);

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose(); 
                pictureBox1.Image = Image.FromFile(fullPath);
            }
        }
    }
}