using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shopping_Cart
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public LogIn()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            con.ConnectionString= @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Users;Integrated Security=True";
        }
        public static string trans0 = "";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string check = "select count(*) from tblUser where Username='" + txtUser.Text + "' and Password='" + txtPass.Text + "'";
            SqlCommand com = new SqlCommand(check, con);
            con.Open();
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {
                MessageBox.Show("Успешна најава!", "Порака:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SC1 ss = new SC1();
                ss.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Погрешно внесени податоци. Ве молиме обидете се повторно!", "Порака:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            trans0 = txtUser.Text;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void llblPromena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Промена_на_лозинка pl = new Промена_на_лозинка();
            pl.Show();
        }
    }
}
