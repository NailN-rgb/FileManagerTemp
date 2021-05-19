using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FIleManager
{
    public partial class Form1 : Form
    {
        private string filePath = "C:";
        private bool inListedMode = false;
        private string selectedItemName = "";
        public static bool isFile = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            fileWayTextBox.Text = filePath;
            LoadFiles();

            mainTree.AfterSelect += mainTreeElementSelection;
        }

        public void LoadFiles()
        {
            DriveInfo[] lDrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in lDrives)
            {
                TreeNode tn = new TreeNode(item.Name);
                mainTree.Nodes.Add(tn);

                GetDirectories(tn, tn.FullPath);
            }
        }

        public static void GetDirectories(TreeNode treeND, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(treeND.FullPath);

                string[] files = Directory.GetFiles(treeND.FullPath);

                DirectoryInfo dInfo = new DirectoryInfo(treeND.FullPath);

                if (!dInfo.Exists)
                {
                    isFile = true;
                }

                
                for(int i = 0; i < dirs.Length; i++)
                {
                    string[] temp = dirs[i].Split('\\');

                    TreeNode newTreeND = new TreeNode(temp[temp.Length - 1]);

                    treeND.Nodes.Add(newTreeND);

                    if(newTreeND.Index < 20)
                    { 
                        GetDirectories(newTreeND, newTreeND.FullPath);
                    }
                }

                for (int i = 0; i < dirs.Length; i++)
                {
                    string[] tmp = dirs[i].Split('\\');

                    TreeNode ntr = new TreeNode(tmp[tmp.Length - 1]);

                    treeND.Nodes.Add(ntr);
                }

                isFile = false;
            }
            catch (Exception e)
            {

            }
        }

        public void mainTreeElementSelection(object sender, TreeViewEventArgs e)
        {
            string newWay = e.Node.FullPath.Replace("\\\\", "\\");
            fileWayTextBox.Text = newWay;
            SomeFunctions.GettingListDerictories(e.Node.FullPath, listView1);
        }




        private void loadButton()
        {
            filePath = fileWayTextBox.Text;
            LoadFiles();
            isFile = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            loadButton();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + selectedItemName);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                fileWayTextBox.Text = filePath + "/" + selectedItemName;
            }
            else
            {
                isFile = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inListedMode)
            {
                listView1.View = View.LargeIcon;
                inListedMode = false;
            }
            else
            {
                listView1.View = View.List;
                inListedMode = true;
            }
        }

        private void TextBoxKey_UP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SomeFunctions.FileFinding(fileWayTextBox.Text, listView1, mainTree);
            }
        }
    }
}
