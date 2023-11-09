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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            DialogResult test = form3.ShowDialog();
            if (test == DialogResult.OK)
            {
                listBox1.Items.Clear();
            }
            else if (test == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter("test.txt"))
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i].ToString());
                    }
                }
            }
            else
            {
                form3.Close();
            }
        }
    }
}
