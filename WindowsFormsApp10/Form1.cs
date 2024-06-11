using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int red, green, blue = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blue = trackBar2.Value;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            green = trackBar3.Value;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            red = trackBar6.Value;
            label3.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }


        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            blue = trackBar5.Value;
            label3.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            green = trackBar4.Value;
            label3.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }
    }
}
