using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 test;
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Clear();
            this.ActiveControl = textBox1;
            this.AcceptButton = button1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
