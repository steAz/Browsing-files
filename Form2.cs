using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przegladaniePlikow
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FileAttributes atrrs = 0;
            if (checkBoxII.Checked)
                atrrs = atrrs | FileAttributes.Archive;
            if (checkBoxIII.Checked)
                atrrs = atrrs | FileAttributes.Hidden;
            if (checkBox.Checked)
                atrrs = atrrs | FileAttributes.ReadOnly;
            if (checkBoxIV.Checked)
                atrrs = atrrs | FileAttributes.System;

            var parent = form1.treeView.SelectedNode; parent.Expand();
            parent.Expand();

            var node = new TreeNode(this.textBoxName.Text);
            parent.Nodes.Add(node);
           // node.BeginEdit();

            // jesli chcemy utworzyc plik
            if (radioButton.Checked && !Regex.IsMatch(this.textBoxName.Text, @"[a-zA-Z0-9_~-]{1,8}\.(txt|php|htm)")) {
                node.Remove();
                MessageBox.Show("Zly format dodawanego pliku");
                return;
            }

            if (this.textBoxName.Text == "") {
                node.Remove();
                MessageBox.Show("Nie podano nazwy");
                return;
            }
            node.Text = this.textBoxName.Text;

            var par = (DirectoryInfo)node.Parent.Tag;
            string newPath = Path.Combine(par.FullName, node.Text);
            if (File.Exists(newPath) || Directory.Exists(newPath)) {
                node.Remove();
                MessageBox.Show("Plik/Katalog o takiej nazwie istnieje");
                return;
            }

            bool isFile = false;
            try {
                if (radioButton.Checked) {
                    isFile = true;
                    FileStream fs = File.Create(newPath);
                    fs.Close();
                    FileInfo fi = new FileInfo(newPath);
                    fi.Attributes = atrrs;
                }
                else {
                    isFile = false;
                    DirectoryInfo di = Directory.CreateDirectory(newPath);
                    di.Attributes = atrrs;
                }
            }
            catch (IOException ex) {
                MessageBox.Show("Zapisanie pliku/folderu na dysku nie udalo sie");
                node.Remove();
            }

            if (isFile)
                node.Tag = new FileInfo(newPath);
            else
                node.Tag = new DirectoryInfo(newPath);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
