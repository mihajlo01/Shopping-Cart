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
    public partial class PayPall : Form
    {
        public PayPall()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                    MessageBox.Show("Ве молиме пополнете ги сите полиња!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    progressBar1.Visible = true;
                    this.timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
            }
            else
                this.progressBar1.Increment(8);
        }
    }
}
