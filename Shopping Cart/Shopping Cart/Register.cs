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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace Shopping_Cart
{
    public partial class Register : Form
    {
        string connectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Users;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
        public bool usernameCheck()
        {
            string conS= @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Users;Integrated Security=True";
            SqlConnection con = new SqlConnection(conS);
            SqlCommand cmd = new SqlCommand("Select Username from tblUser where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", this.txtUser.Text);
            con.Open();
            var result = cmd.ExecuteScalar();
            bool a = false;
            if (result != null)
            {
                a=true;
            }
            return a;
        }
        public bool passCheck()
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            bool isval = hasNumber.IsMatch(txtPass.Text) && hasUpperChar.IsMatch(txtPass.Text) && hasMinimum8Chars.IsMatch(txtPass.Text);
            return isval;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "" || txtLN.Text == "" || txtAdress.Text == "" || txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Сите полиња треба да бидат пополнети!", "Грешка!");
            else if (usernameCheck()==true)
            {
                MessageBox.Show("Корисничкото име веќе е регистрирано", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passCheck() == false)
            {
                MessageBox.Show("Вашата лозинка мора да се содржи од:\n-барем една бројка\n-барем една голема буква\n-минималната должина да изнесува 8 карактери", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFN.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLN.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAdress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Успешна регистрација на нов корисник!", "Порака:");
                    Clear();
                }
            }
        }
        void Clear()
        {
            txtFN.Text = txtLN.Text = txtAdress.Text = txtUser.Text = txtPass.Text = "";
        }

        private void cbUP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInfo.Checked && cbUP.Checked)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

        private void cbInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInfo.Checked && cbUP.Checked)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.e-tinex.mk/HtmlContent.aspx?Id=5&Lng=MK");
        }
    }
}
