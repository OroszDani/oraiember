using GitConsoleEmber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmberGUI
{
    public partial class Form1 : Form
    {
        List<ember> Ember = new List<ember>();
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "";
            Ember.Add(new ember("Kiss Pista", 45, "Arany utca 1", 45000));
            Ember.Add(new ember("Józsi", 37, "Piros utca 1", 95000));
            Ember.Add(new ember("Kiss Pista", 45, "Arany utca 1", 45000));
            Ember.Add(new ember("Józsi", 36, "Piros utca 1", 96000));
            kiiras();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void kiiras()
        {
            foreach (var item in Ember)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textBox1.Text;
            int kor = int.Parse(textBox2.Text);
            string cim = textBox3.Text;
            int fizetes = int.Parse(textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Ember.Add(new ember(nev, kor, cim, fizetes));
            richTextBox1.Text = "";
            kiiras();
            
        }
    }
}
