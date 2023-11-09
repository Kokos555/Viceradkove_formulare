using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // button1
            Button button1 = new Button();   //založení instance tlačítka 
            button1.DialogResult = DialogResult.OK;//nastavení výsledku po zobrazení       formuláře pomocí ShowDialog
            button1.Location = new Point(40, 189);//umístění tlačítka, souřadnice x,y
            button1.Size = new Size(75, 23);//velikost tlačítka
            button1.Text = "Ulož";//popisek

            // button2
            Button button2 = new Button();//založení instance tlačítka 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(148, 188);
            button2.Size = new Size(75, 23);
            button2.Text = "Cancel";

            // button3
            Button button3 = new Button();
            button3.DialogResult = DialogResult.Yes;
            button3.Location = new Point(200,200);
            button3.Size = new Size(75, 23);
            button3.Text = "Font";

            // textBox1
            TextBox textBox = new TextBox();//založení instance TextBoxu  
            textBox.Location = new Point(49, 40);
            textBox.Size = new Size(188, 22);
            //textBox.Text = label1.Text;

            // Nabidka
            Form form2 = new Form();   //založení instance formuláře
            form2.Location = new Point(0, 1000);
            form2.Controls.Add(textBox);//přidání komponenty na formulář
            form2.Controls.Add(button2);
            form2.Controls.Add(button1);
            form2.Text = "Nabidka";

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.Yes)
                button1.Font = fontDialog.Font;


            if (form2.ShowDialog() == DialogResult.Yes)
            {
                
            }

        }
    }
}
