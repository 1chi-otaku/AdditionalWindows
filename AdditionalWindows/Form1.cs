using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalWindows
{
    public partial class Form1 : Form
    {
        string pathToFolder = "C:\\";
        string fileExtension = ".txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileExtension = textBox2.Text;
            listBox1.Items.Clear();
            string[] astrFiles = Directory.GetFiles(pathToFolder);
            foreach (string file in astrFiles)
            {
                if (file.EndsWith(fileExtension))
                {
                    listBox1.Items.Add(file);
                }
                
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                pathToFolder = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
