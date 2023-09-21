using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P03
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
            while (listBox1.Items.Count < 10)
            {
                
                form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(form2.textBox1.Text); 

                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
