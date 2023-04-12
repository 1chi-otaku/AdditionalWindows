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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HM3
{
    public partial class Form1 : Form
    {
        public string str { get; set; }
        Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
            str = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\"; 
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled= true;
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                str = sr.ReadToEnd();
                textBox1.Text = str;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.parent = this;
            form2.SetText(str);
            DialogResult res = form2.ShowDialog();
            if (res == DialogResult.OK)
            {
               textBox1.Text = form2.GetText();
               str = textBox1.Text;
            }
        }
    }
}
