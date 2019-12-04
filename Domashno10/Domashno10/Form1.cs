using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashno10
{
        
    public partial class Form1 : Form
    {
        int flag1;
        int x1, x2;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Dancho with Red.";
            textBox2.Text = "Nutfi with Blue";

            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
             flag1 = 0;

        }
        private async Task startAsync()
        {
            Random rnd = new Random();

            while (x1 < 500 || x2 < 500)
            {
                x1 += rnd.Next(1, 8);
                pictureBox1.Left = x1;
                label1.Text = x1.ToString();

                x2 += rnd.Next(1, 8);
                pictureBox2.Left = x2;
                label2.Text = x2.ToString();

                await Task.Delay(40);
            }

            if (x1 > x2)
            {
                MessageBox.Show(textBox1.Text + " is the winner!");
            }
            else if (x2 > x1)
            {
                MessageBox.Show(textBox2.Text + " is the winner!");
            }
            else
            {
                MessageBox.Show("It's a draw!");
            }
        }


            private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
             flag1 = 0;
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            startAsync();

        }
    }
}
