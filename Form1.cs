using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace przegladaniePlikow
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) LoadDirectory(treeView, dialog.SelectedPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(DirectoryNode(new DirectoryInfo(path)));
        }

        private static TreeNode DirectoryNode(DirectoryInfo directoryInfo)
        {
            var result = new TreeNode(directoryInfo.Name);
            result.Tag = directoryInfo;

            foreach (var directory in directoryInfo.GetDirectories())
                result.Nodes.Add(DirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                result.Nodes.Add(FileNode(file));

            return result;
        }

        private static TreeNode FileNode(FileInfo fileInfo)
        {
            var result = new TreeNode(fileInfo.Name);
            result.Tag = fileInfo;
            return result;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var fileInfo = (FileSystemInfo)e.Node.Tag;
            toolStripStatusLabel.Text = fileInfo.DosAttributes();

            if(fileInfo is DirectoryInfo)
            {
                var dir = (DirectoryInfo)fileInfo;
                FileInfo[] fis = dir.GetFiles();

                double size = 0;
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }

                toolStripStatusLabel.Text += "    Size of dir: " + size;
            }

            if (fileInfo is FileInfo)
            {
                var file = (FileInfo)fileInfo;

                toolStripStatusLabel.Text += "    Size of file: " + file.Length;

                try
                {
                    textBox.Text = "";
                    using (StreamReader sr = new StreamReader(fileInfo.FullName))
                    {
                        textBox.Text += sr.ReadToEnd();
                    }
                }
                catch (IOException ex) { }
            }
        }

        private void deleteTSMenuItem_Click(object sender, EventArgs e)
        {
            var node = treeView.SelectedNode;
            if (node == null) return;

            var info = (FileSystemInfo)node.Tag;
            if (info is DirectoryInfo)
            {
                DirectoryInfo dir = new DirectoryInfo(info.FullName);
               
                FileInfo[] fis = dir.GetFiles();

                DirectoryInfo[] dis = dir.GetDirectories();
                foreach (FileInfo fi in fis)
                {
                    string path = fi.FullName;
                    FileAttributes attributes = File.GetAttributes(path);
                    attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                    File.SetAttributes(path, attributes);
                    fi.Delete();
                }

                foreach (DirectoryInfo di in dis)
                {
                    string path = di.FullName;
                    FileAttributes attributes = File.GetAttributes(path);
                    attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                    File.SetAttributes(path, attributes);
                    di.Delete();
                }

                Directory.Delete(dir.FullName);
            }
            else
                info.Delete();

            node.Remove();
        }



        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }






        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // treeView.LabelEdit = true;
            var node = treeView.SelectedNode;
            string path = node.FullPath;

            var fileInfo = (FileSystemInfo)node.Tag;

            if (fileInfo is DirectoryInfo)
            {
                var dir = (DirectoryInfo)fileInfo;
                FileInfo[] fis = dir.GetFiles();

                double size = 0;
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }

                MessageBox.Show(size.ToString());
            }

            if (fileInfo is FileInfo)
            {
                var file = (FileInfo)fileInfo;

              //  toolStripStatusLabel.Text += "    Size of file: " + file.Length;

                MessageBox.Show(file.Length.ToString());

            }


            //if (node == null) return;

            //node.BeginEdit();

            //treeView.LabelEdit = false;

        }

        private void treeView_NMClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) treeView.SelectedNode = e.Node;
        }

        private void createTSMenuItem_Click(object sender, EventArgs e)
        {
            var parent = treeView.SelectedNode;
            if (parent == null || !(parent.Tag is DirectoryInfo)) return;  //sprawdzenie czy klikamy w folder

            Form2 form2 = new Form2(this);
            form2.Show(this);
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
