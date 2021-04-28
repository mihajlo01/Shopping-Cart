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
    public partial class Картичка : Form
    {
        public Картичка()
        {
            InitializeComponent();
        }

        private void txtBrKarticka_Enter(object sender, EventArgs e)
        {
            if (txtBrKarticka.Text == "XXXX-XXXX-XXXX-XXXX")
            {
                txtBrKarticka.Text = "";
                txtBrKarticka.ForeColor = Color.Black;
            }
        }

        private void txtBrKarticka_Leave(object sender, EventArgs e)
        {
            if (txtBrKarticka.Text == "")
            {
                txtBrKarticka.Text = "XXXX-XXXX-XXXX-XXXX";
                txtBrKarticka.ForeColor = Color.Silver;
            }
        }

        private void txtCVV_Enter(object sender, EventArgs e)
        {
            if (txtCVV.Text == "XXX")
            {
                txtCVV.Text = "";
                txtCVV.ForeColor = Color.Black;
            }
        }

        private void txtCVV_Leave(object sender, EventArgs e)
        {
            if (txtCVV.Text == "")
            {
                txtCVV.Text = "XXX";
                txtCVV.ForeColor = Color.Silver;
            }
        }

        private void txtBrIstek_Enter(object sender, EventArgs e)
        {
            if (txtBrIstek.Text == "XX/XX")
            {
                txtBrIstek.Text = "";
                txtBrIstek.ForeColor = Color.Black;
            }
        }

        private void txtBrIstek_Leave(object sender, EventArgs e)
        {
            if (txtBrIstek.Text == "")
            {
                txtBrIstek.Text = "XX/XX";
                txtBrIstek.ForeColor = Color.Silver;
            }
        }

        private void btnProdolzi_Click(object sender, EventArgs e)
        {
            if (txtBrKarticka.Text.Length < 16||txtBrKarticka.Text== "XXXX-XXXX-XXXX-XXXX")
                MessageBox.Show("Внесен е погрешен број на картичка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtCVV.Text.Length < 3 || txtCVV.Text == "XXX")
                MessageBox.Show("Внесен е погрешен CVV број!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtBrIstek.Text.Length < 4 || txtBrIstek.Text == "XX/XX")
                MessageBox.Show("Внесен е погрешен датум!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            /*else if (txtBrKarticka.Text == "" || txtCVV.Text == "" || txtBrIstek.Text == "")
                MessageBox.Show("Ве молиме пополнете ги сите полиња!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            else
                timer1.Start();
        }
        private void txtBrKarticka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtBrKarticka.MaxLength = 16;
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtCVV.MaxLength = 3;
        }

        private void txtBrIstek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtBrIstek.MaxLength = 5;
            if (txtBrIstek.TextLength == 2)
            {
                txtBrIstek.AppendText("/");
                if (e.KeyChar == (char)8)
                    txtBrIstek.Text = "";
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
