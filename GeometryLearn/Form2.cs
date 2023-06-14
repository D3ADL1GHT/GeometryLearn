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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        GeometryVolume gv = new GeometryVolume();

        int currentPageNum = 1;
        //string theory_Path = "F:/КП/src/img";
        string[] theory1_img_mas = { "src/img/theory1_num1.png", "src/img/theory1_num2.png", "src/img/theory1_num3.png", "src/img/theory1_num4.png"};
        string[] theory2_img_mas = { "src/img/theory2_num1.png", "src/img/theory2_num2.png", "src/img/theory2_num3.png", "src/img/theory2_num4.png"};

       

        //Start of First theme -----------------------------------------------------

        private void theoryChange1() 
        {
            pictureBox1.ImageLocation = theory1_img_mas[currentPageNum-1];
        }

        private void back_btn1_Click(object sender, EventArgs e)
        {
            if (currentPageNum == 1) currentPageNum = 4;
            else currentPageNum-=1;
            label_num1.Text = currentPageNum + "/4";
            theoryChange1();
        }
        private void next_btn1_Click(object sender, EventArgs e)
        {
            if (currentPageNum == 4) currentPageNum = 1;
            else currentPageNum += 1;
            label_num1.Text = currentPageNum + "/4";
            theoryChange1();
        }

        //End of first theme--------------------------------------------------------


        //Start of second theme-----------------------------------------------------

        private void theoryChange2()
        {
            pictureBox1.ImageLocation = theory2_img_mas[currentPageNum - 1];
        }

        private void back_btn2_Click(object sender, EventArgs e)
        {
            if (currentPageNum == 1) currentPageNum = 4;
            else currentPageNum -= 1;
            label_num2.Text = currentPageNum + "/4";
            theoryChange2();
        }
        private void next_btn2_Click(object sender, EventArgs e)
        {
            if (currentPageNum == 4) currentPageNum = 1;
            else currentPageNum += 1;
            label_num2.Text = currentPageNum + "/4";
            theoryChange2();
        }

        //End of second theme-------------------------------------------------------

        public void enableChoice(byte choice)
        {
            if (choice == 1)
            {
                panel2.Enabled = false;
                panel2.Visible = false;
                panel1.Enabled = true;
                panel1.Visible = true;
                theoryChange1();
            }
            else if (choice == 2)
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                panel2.Enabled = true;
                panel2.Visible = true;
                theoryChange2();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Size.Width / 2) - panel1.Width / 2, this.Size.Height - panel1.Height - 40);
            panel2.Location = new Point((this.Size.Width / 2) - panel2.Width / 2, this.Size.Height - panel2.Height - 40);
        }
        private void выходИзТеорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            form2 = this;
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Size.Width / 2) - panel1.Width / 2, this.Size.Height - panel1.Height - 40);
            panel2.Location = new Point((this.Size.Width / 2) - panel2.Width / 2, this.Size.Height - panel2.Height - 40);
        }
    }
}
