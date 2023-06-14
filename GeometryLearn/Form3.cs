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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        byte answer_verified_flag = 0, current_question_num = 1, false_answers_count = 0;
        double[] answers1 = { 614.13, 2587.07, 94.5, 2.85, 913.7, 126.21, 423.9, 1084.65, 272.07 };
        double[] answers2 = { 600, 382, 142, 49.6, 80, 1017.36, 282.6, 769.3, 954.56 };

        string[] questions1 = { 
            "1)\tДано: куб со стороной 8,5 см.\r\nНайти: объем куба.\r\n", 
            "2)\tДано: правильная треугольная пирамида со стороной 28 см.\r\nНайти: объем пирамиды.\r\n",
            "3)\tДано: правильная четырехугольная пирамида со стороной 9см и высотой 3,5 см.\r\nНайти: объем пирамиды.\r\n",
            "4)\tДано: Шар с радиусом 88 см. \r\nНайти: Объем шара.\r\n",
            "5)\tДано: конус высотой 13,64 см и радиусом основания равным 8 см.\r\nНайти: объем конуса.\r\n",
            "6)\tДано: усеченный конус высотой 2 см, радиусом нижнего основания равным 6 см и радиусом верхнего основания 2,77 см.\r\nНайти: объем усеченного конуса.\r\n",
            "7)\tДано: цилиндр высотой 15 см и радиусом основания равным 3.\r\nНайти: объем цилиндра.\r\n",
            "8)\tДано: параллелепипед со сторонами 8 см, 17,36 см и 7,81 см.\r\nНайти: объем параллелепипеда.\r\n",
            "9)\tДано: усеченная пирамида высотой 13 см, площадью нижнего основания 24 см2 и площадью верхнего основания 18 см2.\r\nНайти: объем усеченной пирамиды.\r\n"
            };
        string[] questions2 = { 
            "1)\tДано: куб с длиной ребра 10 см.\r\nНайти: Площадь поверхности куба.\r\n",
            "2)\tДано: Длина прямоугольного параллелепипеда равна 7 см, ширина прямоугольного параллелепипеда равна 8 см, а высота прямоугольного параллелепипеда 9 см.\r\nНайти: Площадь поверхности прямоугольного параллелепипеда.\r\n",
            "3)\tДано: Высота боковой грани усеченной пирамиды равна 9 см, периметр верхнего основания 4см, а площадь 24 см², периметр нижнего основания 8 см, а площадь 64 см².\r\nНайти: Площадь поверхности усеченной пирамиды.\r\n",
            "4)\tДано: Высота правильной треугольной пирамиды равна 10 см, а сторона треугольника в основании – 5 см.\r\nНайти: Площадь поверхности правильной треугольной пирамиды.\r\n",
            "5)\tДано: Высота правильной четырехугольной пирамиды равна 8 см, а сторона квадрата в основании – 4 см. \r\nНайти: Площадь поверхности правильной четырехугольной пирамиды.\r\n",
            "6)\tДано: Шар c радиусом 9 см.\r\nНайти: Площадь поверхности шара.\r\n",
            "7)\tДано: Конус с радиусом 5см и высотой 12 см.\r\nНайти: Площадь поверхности конуса.\r\n",
            "8)\tДано: Усеченный конус с радиусом нижнего основания 10 см, радиус верхнего основания 5 см и образующей боковой поверхностью равной 8 см.\r\nНайти: Площадь поверхности усеченного конуса.\r\n",
            "9)\tДано: Высота цилиндра равна 11 см, а его радиус – 8 см.\r\nНайти: Площадь поверхности цилиндра.\r\n" 
        };
        //Start of First theme -----------------------------------------------------
        private void questionChange1() {
            if (current_question_num > 9) {
                panel2.Visible = false;
                panel2.Enabled = false;
                panel3.Visible = false;
                panel3.Enabled = false;

                label2.Text = "Вы завершили тренировку!";
                label2.Font = new Font("Times New Roman", 24);
            }
            else {
                label2.Text = questions1[current_question_num - 1];
            }
        }
        private async void verify_btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(numericUpDown1.Value) == answers1[current_question_num - 1])
            {
                answer_verified_flag = 1;
                //button1.Enabled = true;
                label1.Text = "Верно!";
                label1.ForeColor = Color.FromArgb(0, 192, 0);
                label1.Visible = true;
                await Task.Delay(2000);
                button1.Enabled = true;
                label1.Visible = false;
                
            }
            else {
                if (false_answers_count == 2) { 
                    right_answer_label.Text = "Подсказка.\nПравильный ответ: " + answers1[current_question_num - 1];
                    right_answer_label.Enabled = true;
                    right_answer_label.Visible = true;
                    right_answer_label.Location = new Point(panel2.Location.X, panel2.Location.Y - 60);
                }
                false_answers_count++;
                label1.Text = "Не верно!";
                label1.ForeColor = Color.FromArgb(192, 0, 0);
                label1.Visible = true;
                await Task.Delay(2000);
                label1.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (answer_verified_flag != 0)
            {
                //Действия после проверки ответа
                current_question_num++;
                questionChange1();
                button1.Enabled = false;
                false_answers_count = 0;
                answer_verified_flag = 0;
                right_answer_label.Enabled = false;
                right_answer_label.Visible = false;
                numericUpDown1.Value = 0;
            }
        }
        //End of first theme--------------------------------------------------------


        //Start of second theme-----------------------------------------------------
        private void questionChange2() {
            if (current_question_num > 9)
            {
                panel2.Visible = false;
                panel2.Enabled = false;
                panel3.Visible = false;
                panel3.Enabled = false;

                label2.Text = "Вы завершили тренировку!";
                label2.Font = new Font("Times New Roman", 24);
            }
            else
            {
                label2.Text = questions2[current_question_num - 1];
            }
        }
        private async void verify_btn2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(numericUpDown2.Value) == answers2[current_question_num - 1])
            {
                answer_verified_flag = 1;
                //button1.Enabled = true;
                label5.Text = "Верно!";
                label5.ForeColor = Color.FromArgb(0, 192, 0);
                label5.Visible = true;
                await Task.Delay(2000);
                next_btn2.Enabled = true;
                label5.Visible = false;

            }
            else
            {
                if (false_answers_count == 2)
                {
                    right_answer_label.Text = "Подсказка.\nПравильный ответ: " + answers2[current_question_num - 1];
                    right_answer_label.Enabled = true;
                    right_answer_label.Visible = true;
                    right_answer_label.Location = new Point(panel3.Location.X, panel3.Location.Y - 60);
                }
                false_answers_count++;
                label5.Text = "Не верно!";
                label5.ForeColor = Color.FromArgb(192, 0, 0);
                label5.Visible = true;
                await Task.Delay(2000);
                label5.Visible = false;
            }
        }
        private void next_btn2_Click(object sender, EventArgs e)
        {
            if (answer_verified_flag != 0)
            {
                //Действия после проверки ответа
                current_question_num++;
                questionChange2();
                next_btn2.Enabled = false;
                false_answers_count = 0;
                answer_verified_flag = 0;
                right_answer_label.Enabled = false;
                right_answer_label.Visible = false;
                numericUpDown2.Value = 0;
            }
        }
        //End of second theme-------------------------------------------------------

        public void enableChoice(byte choice)
        {
            if (choice == 1) {
                panel3.Visible = false;
                panel3.Enabled = false;
                panel2.Visible = true;
                panel2.Enabled = true;
                questionChange1();
            }
            else  if (choice == 2)
            {
                panel2.Visible = false;
                panel2.Enabled = false;
                panel3.Visible = true;
                panel3.Enabled = true;
                questionChange2();
            }
        }
        private void выходИзТренировкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void Form3_Resize(object sender, EventArgs e)
        {
            panel2.Location = new Point((this.Size.Width / 2) - panel2.Width / 2, this.Size.Height - panel2.Height * 2);
            panel3.Location = new Point((this.Size.Width / 2) - panel3.Width / 2, this.Size.Height - panel3.Height * 2);
            right_answer_label.Location = new Point(panel2.Location.X, panel2.Location.Y - 30);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point((this.Size.Width / 2) - panel2.Width / 2, this.Size.Height - panel2.Height * 2);
            panel3.Location = new Point((this.Size.Width / 2) - panel3.Width / 2, this.Size.Height - panel3.Height * 2);


        }
    }
}
