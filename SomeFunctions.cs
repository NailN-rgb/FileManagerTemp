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
    class SomeFunctions
    {


        public static void GettingListDerictories(string filePath, ListView listView1)
        {
            listView1.Clear();

            try
            {
                string[] directories = Directory.GetDirectories(filePath);
                string[] files = Directory.GetFiles(filePath);

                AddingElementsToList(directories, listView1);
                AddingElementsToList(directories, listView1);
            }
            catch (Exception e)
            {
                string tmptext = "Произошла ошибка, возможно имя папки задано неверно";
                MessageBox.Show(tmptext, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddingElementsToList(string[] str, ListView listView1)
        {
            for (int i = 0; i < str.Length; i++)
            {
                string[] divitedstring = str[i].Split(('\\'));
                listView1.Items.Add(divitedstring[divitedstring.Length - 1]);
            }
        }

        public static void FileFinding(string filePath, ListView listView1, TreeView treeNode1)
        {
            
        }
    }
}
