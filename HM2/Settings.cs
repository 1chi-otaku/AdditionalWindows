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
using ComboBox = System.Windows.Forms.ComboBox;

namespace HM2
{
    public partial class Settings : Form
    {
        public Form1 mainMenu { get; set; }
        public ComboBox.ObjectCollection GetCombo()
        {
            return comboBox1.Items;
        }
        public void SetCombo(ComboBox.ObjectCollection combo)
        {
            foreach (var item in combo)
            {
                comboBox1.Items.Add(item);
            }
        }
       
        public Settings()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                comboBox1.Items.Add((string)textBox1.Text + " | " + numericUpDown1.Value.ToString());
            }
            textBox1.Text = "";
            numericUpDown1.Value = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Length > 1) { 
                numericUpDown2.Enabled = true;
                textBox2.Enabled = true;
                button2.Enabled = true; 
            }
            else
            {
                numericUpDown2.Enabled = false;
                textBox2.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                comboBox1.Items[comboBox1.SelectedIndex] = textBox2.Text + " | " + Convert.ToString(numericUpDown2.Value);
                textBox2.Text = "";
                numericUpDown2.Value = 0;
            }
        }
    }
}
