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
        Color backcolor = Form1.DefaultBackColor;
        private void button1_Click_1(object sender, EventArgs e)
        {
            int vyska = ((int)numericUpDown2.Value);
            int sirka = ((int)numericUpDown1.Value);

            

            form2 = new Form();
            form2.Text = textBox1.Text;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                backcolor = colorDialog.Color;

            form2.Size = new Size(vyska, sirka);
            if (radioButton2.Checked)
            {
                form2.MinimizeBox = false;
                form2.MaximizeBox = false;
                form2.FormBorderStyle = FormBorderStyle.FixedSingle;
            }

            form2.BackColor = backcolor;
            form2.Show();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
