using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Почетна : Form
    {
        public Почетна()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Почетна_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Sliki\\123.png";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }
    }
}
