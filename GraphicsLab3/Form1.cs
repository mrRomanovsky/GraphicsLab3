using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(textBox1.Text);
            var task2 = new Task2();
            task2.DrawImage(image);
            task2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Task1(textBox1.Text);
            form.Show();
        }
    }
}