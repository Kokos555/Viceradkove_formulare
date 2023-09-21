using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form3;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = textBox1.Text;
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form3.IsDisposed)
            {
                form3 = new Form2();
            }
            form3.label1.Text = textBox1.Text;
            form3.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form3 = new Form2();
            
        }
    }
}
