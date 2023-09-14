using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
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
            form2.textBox1.Text = label1.Text;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = form2.textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
        }
    }
}
