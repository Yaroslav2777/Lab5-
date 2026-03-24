using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            try
            {
                treeView.Nodes.Clear();
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        TreeNode node = new TreeNode(drive.Name)
                        {
                            Tag = drive.RootDirectory.FullName,
                            ImageKey = "folder",
                            SelectedImageKey = "folder"
                        };
                        node.Nodes.Add("");
                        treeView.Nodes.Add(node);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження дисків: " + ex.Message);
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode parentNode = e.Node;

            if (parentNode == null || parentNode.Tag == null) return;

            if (parentNode.Nodes.Count > 0 && parentNode.Nodes[0].Text == "")
            {
                parentNode.Nodes.Clear();
                string path = parentNode.Tag.ToString();

                try
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    foreach (DirectoryInfo subDir in dir.GetDirectories())
                    {
                        if ((subDir.Attributes & FileAttributes.Hidden) != 0 ||
                            (subDir.Attributes & FileAttributes.System) != 0)
                            continue;

                        TreeNode subNode = new TreeNode(subDir.Name)
                        {
                            Tag = subDir.FullName,
                            ImageKey = "folder",
                            SelectedImageKey = "folder"
                        };
                        subNode.Nodes.Add("");
                        parentNode.Nodes.Add(subNode);
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (Exception ex) { MessageBox.Show("Не вдалося відкрити папку: " + ex.Message); }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null)
                return;

            string path = e.Node.Tag.ToString();

            if (lblStatus != null)
                lblStatus.Text = $" Шлях: {path}";

            if (listView == null) return;
            listView.Items.Clear();

            try
            {
                if (!Directory.Exists(path)) return;

                DirectoryInfo dir = new DirectoryInfo(path);

                foreach (FileInfo file in dir.GetFiles())
                {
                    if ((file.Attributes & FileAttributes.Hidden) != 0) continue;

                    ListViewItem item = new ListViewItem(file.Name, "file");
                    long sizeInKb = file.Length / 1024;
                    item.SubItems.Add(sizeInKb.ToString());
                    item.SubItems.Add(file.LastWriteTime.ToString("dd.MM.yyyy HH:mm"));
                    listView.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                if (lblStatus != null) lblStatus.Text += " [Доступ обмежено]";
            }
            catch (Exception ex)
            {
                if (lblStatus != null) lblStatus.Text = $" Помилка: {ex.Message}";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}