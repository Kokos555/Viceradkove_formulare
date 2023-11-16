using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form form;


        Button nastav;
        private void button1_Click(object sender, EventArgs e)
        {
            nastav.TextAlign = button1.TextAlign;
            nastav.ForeColor = button1.ForeColor;
            nastav.BackColor = button1.BackColor;
            nastav.Text = button1.Text;
            nastav.Height = button1.Height;
            nastav.Width = button1.Width;
            nastav.Font = button1.Font;

            //nastav = button1;

            if (form.ShowDialog() == DialogResult.OK)
            {
                button1.TextAlign = nastav.TextAlign;
                button1.ForeColor = nastav.ForeColor;
                button1.BackColor = nastav.BackColor;
                button1.Text = nastav.Text;
                button1.Height = nastav.Height;
                button1.Width = nastav.Width;
                button1.Font = nastav.Font;

                //button1 = nastav;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    nastav.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    nastav.TextAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    nastav.TextAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    nastav.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    nastav.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    nastav.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    nastav.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    nastav.TextAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    nastav.TextAlign = ContentAlignment.BottomRight;
                    break;
            }
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            nastav.Height = Convert.ToInt32((sender as NumericUpDown).Value);
        }

        //private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    nastav.Width = Convert.ToInt32((sender as NumericUpDown).Value);
        //}

        private void Button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) nastav.BackColor = colorDialog.Color;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) nastav.ForeColor = colorDialog.Color;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK) nastav.Font = fontDialog.Font;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            nastav.Text = (sender as TextBox).Text;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            form = new Form();
            form.Size = new Size(450, 300);
            //
            Label label = new Label();
            label.Text = "text:";
            label.Location = new Point(10, 10);
            label.Width = 30;
            //
            TextBox textBox = new TextBox();
            textBox.Location = new Point(45, 10);
            textBox.TextChanged += TextBox_TextChanged;
            //
            Button button = new Button();
            button.Text = "font";
            button.Location = new Point(50 + textBox.Width, 10);
            button.Click += Button_Click;
            //
            Button button2 = new Button();
            button2.Text = "barvaF";
            button2.Location = new Point(55 + textBox.Width + button.Width, 10);
            button2.Click += Button2_Click;
            //
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Location = new Point(10, 40);
            comboBox.Width = 90;
            comboBox.Items.Add("TopLeft");
            comboBox.Items.Add("TopCenter");
            comboBox.Items.Add("TopRight");
            comboBox.Items.Add("MiddleLeft");
            comboBox.Items.Add("MiddleCenter");
            comboBox.Items.Add("MiddleRight");
            comboBox.Items.Add("BottomLeft");
            comboBox.Items.Add("BottomCenter");
            comboBox.Items.Add("BottomRight");
            comboBox.SelectedIndex = 4;
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            //
            Button button3 = new Button();
            button3.Text = "barvaB";
            button3.Location = new Point(60 + textBox.Width + button.Width + button2.Width, 10);
            button3.Click += Button3_Click;
            //

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Width = 50;
            numericUpDown.Minimum = button.Width;
            numericUpDown.Maximum = 1000;
            numericUpDown.Location = new Point(90 + button3.Width, 40);
            // numericUpDown.ValueChanged += NumericUpDown_ValueChanged;

            //
            NumericUpDown numericUpDown2 = new NumericUpDown();
            numericUpDown2.Width = 50;
            numericUpDown2.Minimum = button.Height;
            numericUpDown2.Maximum = 1000;
            numericUpDown2.Location = new Point(145 + button3.Width, 40);
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
            //
            Button ok = new Button();
            ok.DialogResult = DialogResult.OK;
            ok.Location = new System.Drawing.Point(40, 189);
            ok.Size = new System.Drawing.Size(75, 23);
            ok.Text = "Ulož";

            // 
            nastav = new Button();
            nastav.Location = new System.Drawing.Point(140, 100);
            nastav.Size = new System.Drawing.Size(75, 23);
            nastav.Text = "";

            Button cancel = new Button();
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new System.Drawing.Point(148, 188);
            cancel.Size = new System.Drawing.Size(75, 23);
            cancel.Text = "Cancel";
            //
            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(button);
            form.Controls.Add(button2);
            form.Controls.Add(button3);
            form.Controls.Add(ok);
            form.Controls.Add(cancel);
            form.Controls.Add(nastav);
            form.Controls.Add(numericUpDown);
            form.Controls.Add(numericUpDown2);
            form.Controls.Add(comboBox);

            numericUpDown.ValueChanged += delegate
            {
                nastav.Width = Convert.ToInt32(numericUpDown.Value);
            };
        }
    }
}

