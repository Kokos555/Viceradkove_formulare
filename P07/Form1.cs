using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form form2;
        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form();
            form2.ShowDialog();
        }
    }
}
