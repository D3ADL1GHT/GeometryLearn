using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeometryLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e){Close();}

        //Объемы геометрических тел
        private void Theory_btn1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form2.Show();
            form2.enableChoice(1);

            form1 = this;
            this.Hide();
        }
        private void Training_btn1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();

            form3.Show();
            form3.enableChoice(1);

            form1 = this;
            this.Hide();
        }
        private void Practice_btn1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form4 form4 = new Form4();

            form4.Show();
            form4.enableChoice(1);

            form1 = this;
            this.Hide();
        }

        //Площади геометрических тел
        private void Theory_btn2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form2.Show();
            form2.enableChoice(2);

            form1 = this;
            this.Hide();
        }

        private void Training_btn2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();

            form3.Show();
            form3.enableChoice(2);

            form1 = this;
            this.Hide();
        }

        private void Practice_btn2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
