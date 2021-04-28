using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shopping_Cart
{
    public partial class Нарачки : Form
    {
        public Нарачки()
        {
            InitializeComponent();
        }

        private void ПоследнаНарачка_Load(object sender, EventArgs e)
        {
                timer1.Start();
                using (StreamReader sr = new StreamReader("C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\" + LogIn.trans0 + ".txt"))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
        }
    }
}
