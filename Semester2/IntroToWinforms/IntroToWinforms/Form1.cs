using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Color c = DoSomethingButton.BackColor;
            DoSomethingButton.MouseEnter += (o, e) => ChangeColor(Color.Blue);
            DoSomethingButton.MouseLeave += (o, e) => ChangeColor(c);
        }
        public void ChangeColor(Color c)
        {
            DoSomethingButton.BackColor = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FailSafeBox.Checked && dateTimePicker.Value<DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Random rand = new Random();

                for (int i = 0; i < pictureBox1.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Height; j++)
                    {
                        b.SetPixel(i, j, rand.Next(0, 2) == 0 ? Color.Red : Color.Blue);
                    }
                }
                pictureBox1.Image = b;
            }
            
        }

        private void FailSafeBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
        }
    }
}
