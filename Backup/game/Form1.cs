using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }
        int speed =10;
        int result;
        bool top, left ;
  
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            pictureBox1.Location = new Point(0, rand.Next(this.Height));
            top = left = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > pictureBox2.Left) { timer1.Enabled = false; MessageBox.Show("شما باختید...امتیاز "+result.ToString()); result = 0; }
            if (pictureBox1.Left + pictureBox1.Width >= pictureBox2.Left &&
                pictureBox1.Left + pictureBox1.Width <= pictureBox2.Left + pictureBox2.Width
                && pictureBox1.Top + pictureBox1.Height >= pictureBox2.Top &&
                pictureBox1.Top + pictureBox1.Height <= pictureBox2.Top + pictureBox2.Height + pictureBox1.Height)
            {
                left = false;
                result += 1;
                this.Text = result.ToString();
            }
            if (left) pictureBox1.Left += speed; else pictureBox1.Left -= speed;
            if (top) pictureBox1.Top += speed; else pictureBox1.Top -= speed;
            if (pictureBox1.Top >= this.Height - 50) top = false;
            if (pictureBox1.Top <= 0) top = true;
            if (pictureBox1.Left <= 0) left = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Top = e.Y;
        }
    }
}
