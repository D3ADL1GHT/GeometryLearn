using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryLearn
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        byte current_question_num = 1, right_answers_count = 0, failed_answers_count = 0;
        string failed_questions_list = "";

        byte[] failed_answers_numbers = new byte[5];
        string[] used_questions = new string[5];
        string[] failed_questions = new string[5];
        double[] used_answers = new double[5];
        double[] failed_answers = new double[5];
        double[] failed_user_answers = new double[5];

        //start first theme-----------------------------------------------
        private void questionChange1()
        {
            label3.Text = used_questions[current_question_num-1];
            numericUpDown1.Value = 0;
        }

        private void next_btn_1_Click(object sender, EventArgs e)
        {
            if (current_question_num < 5)
            {
                if ((double)numericUpDown1.Value == used_answers[current_question_num - 1]) right_answers_count++;
                else
                {
                    failed_answers_numbers[failed_answers_count] = current_question_num;
                    failed_questions[failed_answers_count] = used_questions[current_question_num - 1];
                    failed_answers[failed_answers_count] = used_answers[current_question_num - 1];
                    failed_user_answers[failed_answers_count] = (double)numericUpDown1.Value;
                    failed_answers_count++;
                }
                    current_question_num++;
                    questionChange1();
            }
            else
            {
                if ((double)numericUpDown1.Value == used_answers[current_question_num - 1]) right_answers_count++;
                else
                {
                    failed_answers_numbers[failed_answers_count] = current_question_num;
                    failed_questions[failed_answers_count] = used_questions[current_question_num - 1];
                    failed_answers[failed_answers_count] = used_answers[current_question_num - 1];
                    failed_user_answers[failed_answers_count] = (double)numericUpDown1.Value;
                    failed_answers_count++;
                }

                panel1.Enabled = false;
                panel1.Visible = false;

                if (failed_answers_count != 0) {
                    for (byte i = 0; i < failed_answers_count; i++) {
                        failed_questions_list += "Вопрос номер: " + failed_answers_numbers[i] + "\r\n" +
                            failed_questions[i] + "\r\nПравильный ответ: " + failed_answers[i] + "\r\nВаш ответ: " + failed_user_answers[i] + "\r\n\r\n";
                    }
                    textBox1.Text = failed_questions_list;
                    textBox1.Dock = DockStyle.Fill;
                    textBox1.Enabled = true;
                    textBox1.Visible = true;

                    final_btn.Enabled = true;
                    final_btn.Visible = true;
                    final_btn.BringToFront();

                    label3.Enabled = false;
                    label3.Visible = false;
                }
            }
            
        }

        //end first theme-------------------------------------------------

        //start second theme----------------------------------------------

        //end second theme------------------------------------------------

        private void final_btn_Click(object sender, EventArgs e)
        {
            byte user_score = 5;

            switch (failed_answers_count) { 
                case 0:
                    user_score = 5;
                    break;
                case 1:
                    user_score = 4;
                    break;
                case 2:
                    user_score = 3;
                    break;
                default:
                    user_score = 2;
                    break;
            }

            textBox1.Visible = false;
            textBox1.Enabled = false;

            label3.Enabled = true;
            label3.Visible = true;

            label3.Text = "Колличество правильных ответов: " + (5 - failed_answers_count) + "\n\nВаша оценка: " + user_score;

            final_btn.Enabled = false;
            final_btn.Visible = false;
        }


        private void questionChange2()
        {

        }

        public void enableChoice(byte choice)
        {
            if (choice == 1)
            {
                panel2.Visible = false;
                panel2.Enabled = false;
                panel1.Visible = true;
                panel1.Enabled = true;

                Random rand = new Random();

                byte count = 0, current_num = 0;
                byte[] used_nums = new byte[5];
                string[] questions = new string[9];
                double[] answers = new double[9];

                StreamReader sr = new StreamReader("src\\questions\\theme1\\practice\\practice_questions.txt");
                for (byte i = 0; i < 9; i++) {
                    questions[i] = Regex.Unescape(sr.ReadLine());
                    answers[i] = Convert.ToDouble(sr.ReadLine());
                }

                //Choosing 5 random questions
                for (;;) {
                    if (count < 5)
                    {
                        current_num = (byte)rand.Next(9);
                        if (!used_nums.Contains(current_num))
                        {
                            used_nums[count] = current_num;
                            count++;
                        }
                    }
                    else break;
                }

                //Writing randomly choosen questions into final arrays
                for (byte i = 0; i < 5; i++) {
                    used_questions[i] = questions[used_nums[i]];
                    used_answers[i] = answers[used_nums[i]];
                }


                questionChange1();
            }
            else if (choice == 2)
            {
                panel1.Visible = false;
                panel1.Enabled = false;
                panel2.Visible = true;
                panel2.Enabled = true;
                questionChange2();
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.Size.Width / 2 - panel1.Width / 2, this.Size.Height - panel1.Height * 2);
            panel2.Location = new Point(this.Size.Width / 2 - panel2.Width / 2, this.Size.Height - panel2.Height * 2);
            textBox1.Location = new Point(this.Size.Width / 2 - panel1.Width / 2, this.Size.Height / 2 - panel1.Height / 2);
        }
        private void Form4_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Size.Width / 2) - panel1.Width / 2, this.Size.Height - panel1.Height * 2);
            panel2.Location = new Point((this.Size.Width / 2) - panel2.Width / 2, this.Size.Height - panel2.Height * 2);
            textBox1.Location = new Point(this.Size.Width / 2 - panel1.Width / 2, this.Size.Height / 2 - panel1.Height / 2);
        }
        private void выходИзКонтрольнойРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
