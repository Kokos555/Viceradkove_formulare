using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (form2.IsDisposed)
            {
                form2 = new Form2();
            }
            form2.Show();

            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                form2.listBox1.Items.Add(textBox1.Lines[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form2.listBox1.Items.Clear();
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                form2.listBox1.Items.Add(textBox1.Lines[i]);
            }
        }
    }
}
