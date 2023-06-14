namespace GeometryLearn
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходИзТеорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_num1 = new System.Windows.Forms.Label();
            this.next_btn1 = new System.Windows.Forms.Button();
            this.back_btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_btn2 = new System.Windows.Forms.Button();
            this.label_num2 = new System.Windows.Forms.Label();
            this.next_btn2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзТеорииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходИзТеорииToolStripMenuItem
            // 
            this.выходИзТеорииToolStripMenuItem.Name = "выходИзТеорииToolStripMenuItem";
            this.выходИзТеорииToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.выходИзТеорииToolStripMenuItem.Text = "Выход из теории";
            this.выходИзТеорииToolStripMenuItem.Click += new System.EventHandler(this.выходИзТеорииToolStripMenuItem_Click);
            // 
            // label_num1
            // 
            this.label_num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_num1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_num1.Location = new System.Drawing.Point(234, 4);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(98, 47);
            this.label_num1.TabIndex = 3;
            this.label_num1.Text = "1/4";
            this.label_num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_btn1
            // 
            this.next_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn1.Location = new System.Drawing.Point(410, 4);
            this.next_btn1.Name = "next_btn1";
            this.next_btn1.Size = new System.Drawing.Size(145, 50);
            this.next_btn1.TabIndex = 4;
            this.next_btn1.Text = "Дальше";
            this.next_btn1.UseVisualStyleBackColor = true;
            this.next_btn1.Click += new System.EventHandler(this.next_btn1_Click);
            // 
            // back_btn1
            // 
            this.back_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn1.Location = new System.Drawing.Point(3, 4);
            this.back_btn1.Name = "back_btn1";
            this.back_btn1.Size = new System.Drawing.Size(145, 50);
            this.back_btn1.TabIndex = 5;
            this.back_btn1.Text = "Назад";
            this.back_btn1.UseVisualStyleBackColor = true;
            this.back_btn1.Click += new System.EventHandler(this.back_btn1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.back_btn1);
            this.panel1.Controls.Add(this.label_num1);
            this.panel1.Controls.Add(this.next_btn1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(172, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 59);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.back_btn2);
            this.panel2.Controls.Add(this.label_num2);
            this.panel2.Controls.Add(this.next_btn2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(172, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 59);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // back_btn2
            // 
            this.back_btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn2.Location = new System.Drawing.Point(3, 3);
            this.back_btn2.Name = "back_btn2";
            this.back_btn2.Size = new System.Drawing.Size(145, 50);
            this.back_btn2.TabIndex = 8;
            this.back_btn2.Text = "Назад";
            this.back_btn2.UseVisualStyleBackColor = true;
            this.back_btn2.Click += new System.EventHandler(this.back_btn2_Click);
            // 
            // label_num2
            // 
            this.label_num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_num2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_num2.Location = new System.Drawing.Point(234, 5);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(98, 47);
            this.label_num2.TabIndex = 6;
            this.label_num2.Text = "1/4";
            this.label_num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_btn2
            // 
            this.next_btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn2.Location = new System.Drawing.Point(410, 3);
            this.next_btn2.Name = "next_btn2";
            this.next_btn2.Size = new System.Drawing.Size(145, 50);
            this.next_btn2.TabIndex = 7;
            this.next_btn2.Text = "Дальше";
            this.next_btn2.UseVisualStyleBackColor = true;
            this.next_btn2.Click += new System.EventHandler(this.next_btn2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теория";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходИзТеорииToolStripMenuItem;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Button next_btn1;
        private System.Windows.Forms.Button back_btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button back_btn2;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Button next_btn2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}