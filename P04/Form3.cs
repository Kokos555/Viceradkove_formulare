using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form2 form2;

        private void button1_Click(object sender, EventArgs e)
        {
            form2.listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                for (int i = 0; i < form2.listBox1.Items.Count; i++)
                {
                    sw.WriteLine(form2.listBox1.Items[i].ToString());
                }
            }
        }
    }
}
