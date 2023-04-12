using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM2
{
    public partial class Form1 : Form
    {
        public Settings settings { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        public ComboBox.ObjectCollection GetCombo()
        {
            return comboBox1.Items;
        }
        public void SetCombo(ComboBox combo)
        {
            comboBox1 = combo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(comboBox1.Text))
            {
                listBox1.Items.Add(comboBox1.Text);
            }
            Price_Check(sender, e);
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            Price_Check(sender, e);
        }
        public void Price_Check(object sender, EventArgs e)
        {
            double price = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string[] subs = listBox1.Items[i].ToString().Split('|');
                price += Convert.ToDouble(subs[1]);
            }
            label1.Text = price.ToString();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.mainMenu = this;
            settings.SetCombo(comboBox1.Items);
            DialogResult res = settings.ShowDialog();
            if (res == DialogResult.OK)
            {
                comboBox1.Items.Clear();
                foreach (var item in settings.GetCombo())
                {
                    comboBox1.Items.Add(item);
                }
            }
            Price_Check(sender, e);
        }
    }
}
