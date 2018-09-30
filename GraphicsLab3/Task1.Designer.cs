using System;

namespace GraphicsLab3
{
    partial class Task1
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
            this.part1 = new System.Windows.Forms.Button();
            this.part2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rFill = new System.Windows.Forms.TextBox();
            this.gFill = new System.Windows.Forms.TextBox();
            this.bFill = new System.Windows.Forms.TextBox();
            this.setColorFill = new System.Windows.Forms.Button();
            this.guideline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setColorBorder = new System.Windows.Forms.Button();
            this.bBorder = new System.Windows.Forms.TextBox();
            this.gBorder = new System.Windows.Forms.TextBox();
            this.rBorder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.labelPathForSecondPic = new System.Windows.Forms.Label();
            this.buttonSetPathToPic = new System.Windows.Forms.Button();
            this.textBoxPathToPic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // part1
            // 
            this.part1.BackColor = System.Drawing.Color.DimGray;
            this.part1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part1.Font = new System.Drawing.Font("Muller Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.part1.Location = new System.Drawing.Point(9, 12);
            this.part1.Margin = new System.Windows.Forms.Padding(0);
            this.part1.Name = "part1";
            this.part1.Size = new System.Drawing.Size(384, 36);
            this.part1.TabIndex = 0;
            this.part1.Text = "Часть 1";
            this.part1.UseVisualStyleBackColor = false;
            this.part1.Click += new System.EventHandler(this.Part1_Click);
            // 
            // part2
            // 
            this.part2.BackColor = System.Drawing.Color.Silver;
            this.part2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.part2.Font = new System.Drawing.Font("Muller Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part2.Location = new System.Drawing.Point(410, 12);
            this.part2.Name = "part2";
            this.part2.Size = new System.Drawing.Size(378, 36);
            this.part2.TabIndex = 1;
            this.part2.Text = "Часть 2";
            this.part2.UseVisualStyleBackColor = false;
            this.part2.Click += new System.EventHandler(this.Part2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 449);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(615, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            part1Components.Add(this.label1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(615, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            part1Components.Add(this.label2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(616, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            part1Components.Add(this.label3);
            // 
            // rFill
            // 
            this.rFill.Location = new System.Drawing.Point(653, 350);
            this.rFill.Name = "rFill";
            this.rFill.Size = new System.Drawing.Size(100, 20);
            this.rFill.TabIndex = 6;
            this.rFill.Text = "50";
            part1Components.Add(this.rFill);
            // 
            // gFill
            // 
            this.gFill.Location = new System.Drawing.Point(653, 377);
            this.gFill.Name = "gFill";
            this.gFill.Size = new System.Drawing.Size(100, 20);
            this.gFill.TabIndex = 7;
            this.gFill.Text = "50";
            part1Components.Add(this.gFill);
            // 
            // bFill
            // 
            this.bFill.Location = new System.Drawing.Point(653, 403);
            this.bFill.Name = "bFill";
            this.bFill.Size = new System.Drawing.Size(100, 20);
            this.bFill.TabIndex = 8;
            this.bFill.Text = "50";
            part1Components.Add(this.bFill);
            // 
            // setColorFill
            // 
            this.setColorFill.BackColor = System.Drawing.Color.DimGray;
            this.setColorFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setColorFill.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setColorFill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setColorFill.Location = new System.Drawing.Point(653, 439);
            this.setColorFill.Name = "setColorFill";
            this.setColorFill.Size = new System.Drawing.Size(83, 23);
            this.setColorFill.TabIndex = 9;
            this.setColorFill.Text = "Установить";
            this.setColorFill.UseVisualStyleBackColor = false;
            this.setColorFill.Click += new System.EventHandler(this.SetFillColor_Click);
            part1Components.Add(this.setColorFill);
            // 
            // guideline
            // 
            this.guideline.AutoSize = true;
            this.guideline.Font = new System.Drawing.Font("Muller Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guideline.Location = new System.Drawing.Point(287, 69);
            this.guideline.Name = "guideline";
            this.guideline.Size = new System.Drawing.Size(218, 16);
            this.guideline.TabIndex = 10;
            this.guideline.Text = "Обведите область заливки...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(638, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цвет для границы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(639, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цвет для заливки";
            part1Components.Add(this.label6);
            // 
            // pathForSecondPic
            // 
            this.labelPathForSecondPic.AutoSize = true;
            this.labelPathForSecondPic.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathForSecondPic.Location = new System.Drawing.Point(625, 321);
            this.labelPathForSecondPic.Name = "pathForSecondPic";
            this.labelPathForSecondPic.Size = new System.Drawing.Size(103, 12);
            this.labelPathForSecondPic.TabIndex = 12;
            this.labelPathForSecondPic.Text = "Путь к картинке для заливки";
            this.labelPathForSecondPic.Visible = false;
            this.labelPathForSecondPic.Enabled = false;
            part2Components.Add(this.labelPathForSecondPic);
            // 
            // setPathToPic
            // 
            this.buttonSetPathToPic.BackColor = System.Drawing.Color.DimGray;
            this.buttonSetPathToPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPathToPic.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetPathToPic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetPathToPic.Location = new System.Drawing.Point(653, 385);
            this.buttonSetPathToPic.Name = "setPathToPic";
            this.buttonSetPathToPic.Size = new System.Drawing.Size(83, 23);
            this.buttonSetPathToPic.TabIndex = 19;
            this.buttonSetPathToPic.Text = "Установить";
            this.buttonSetPathToPic.UseVisualStyleBackColor = false;
            this.buttonSetPathToPic.Visible = false;
            this.buttonSetPathToPic.Enabled = false;
            this.buttonSetPathToPic.Click += new System.EventHandler(this.setPathToPic_Click);
            part2Components.Add(this.buttonSetPathToPic);
            // 
            // pathToPic
            // 
            this.textBoxPathToPic.Location = new System.Drawing.Point(636, 350);
            this.textBoxPathToPic.Name = "pathToPic";
            this.textBoxPathToPic.Size = new System.Drawing.Size(117, 20);
            this.textBoxPathToPic.TabIndex = 18;
            //this.textBoxPathToPic.Text = "0";
            this.textBoxPathToPic.Visible = false;
            this.textBoxPathToPic.Enabled = false;
            part2Components.Add(this.textBoxPathToPic);
            // 
            // setColorBorder
            // 
            this.setColorBorder.BackColor = System.Drawing.Color.DimGray;
            this.setColorBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setColorBorder.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setColorBorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setColorBorder.Location = new System.Drawing.Point(653, 243);
            this.setColorBorder.Name = "setColorBorder";
            this.setColorBorder.Size = new System.Drawing.Size(83, 23);
            this.setColorBorder.TabIndex = 19;
            this.setColorBorder.Text = "Установить";
            this.setColorBorder.UseVisualStyleBackColor = false;
            this.setColorBorder.Click += new System.EventHandler(this.SetColorBorder_Click);
            // 
            // bBorder
            // 
            this.bBorder.Location = new System.Drawing.Point(653, 205);
            this.bBorder.Name = "bBorder";
            this.bBorder.Size = new System.Drawing.Size(100, 20);
            this.bBorder.TabIndex = 18;
            this.bBorder.Text = "0";
            // 
            // gBorder
            // 
            this.gBorder.Location = new System.Drawing.Point(653, 179);
            this.gBorder.Name = "gBorder";
            this.gBorder.Size = new System.Drawing.Size(100, 20);
            this.gBorder.TabIndex = 17;
            this.gBorder.Text = "0";
            // 
            // rBorder
            // 
            this.rBorder.Location = new System.Drawing.Point(653, 152);
            this.rBorder.Name = "rBorder";
            this.rBorder.Size = new System.Drawing.Size(100, 20);
            this.rBorder.TabIndex = 16;
            this.rBorder.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(616, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(615, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(615, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "R";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Black;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Muller Thin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(653, 499);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 23);
            this.clear.TabIndex = 20;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.setColorBorder);
            this.Controls.Add(this.bBorder);
            this.Controls.Add(this.gBorder);
            this.Controls.Add(this.rBorder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guideline);
            this.Controls.Add(this.setColorFill);
            this.Controls.Add(this.bFill);
            this.Controls.Add(this.gFill);
            this.Controls.Add(this.rFill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.part2);
            this.Controls.Add(this.part1);
            this.Controls.Add(this.labelPathForSecondPic);
            this.Controls.Add(this.buttonSetPathToPic);
            this.Controls.Add(this.textBoxPathToPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Task1";
            this.Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button part1;
        private System.Windows.Forms.Button part2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rFill;
        private System.Windows.Forms.TextBox gFill;
        private System.Windows.Forms.TextBox bFill;
        private System.Windows.Forms.Button setColorFill;
        private System.Windows.Forms.Label guideline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setColorBorder;
        private System.Windows.Forms.TextBox bBorder;
        private System.Windows.Forms.TextBox gBorder;
        private System.Windows.Forms.TextBox rBorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label labelPathForSecondPic;
        private System.Windows.Forms.TextBox textBoxPathToPic;
        private System.Windows.Forms.Button buttonSetPathToPic;
    }
}