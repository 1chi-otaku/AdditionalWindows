using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HM3
{
    public partial class Form2 : Form
    {
        public Form1 parent { get; set; }

        public string GetText()
        {
            return textBox1.Text;
        }
        public void SetText(string str)
        {
            textBox1.Text = str;
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
