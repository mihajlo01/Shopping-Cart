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
using System.Text.RegularExpressions;

namespace Shopping_Cart
{
    public partial class Промена_на_лозинка : Form
    {
        public Промена_на_лозинка()
        {
            InitializeComponent();
        }

        private void Промена_на_лозинка_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            txtUser.Text = LogIn.trans0;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool usernameCheck()
        {
            string conS = @"Data Source=MIHAJLO;Initial Catalog=Users;Integrated Security=True";
            SqlConnection con = new SqlConnection(conS);
            SqlCommand cmd = new SqlCommand("Select Username from tblUser where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", this.txtUser.Text);
            con.Open();
            var result = cmd.ExecuteScalar();
            bool a = false;
            if (result != null)
            {
                a = true;
            }
            return a;
        }
        public bool passCheck()
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            bool isval = hasNumber.IsMatch(txtConfirm.Text) && hasUpperChar.IsMatch(txtConfirm.Text) && hasMinimum8Chars.IsMatch(txtConfirm.Text);
            return isval;
        }
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == ""|| txtConfirm.Text == "")
                MessageBox.Show("Сите полиња треба да бидат пополнети!", "Грешка!");
            else if(txtPass.Text!=txtConfirm.Text)
                MessageBox.Show("Полињата \'New Password\' и \'Confirm Password\' треба да бидат исти!", "Грешка!");
            else if (passCheck() == false)
            {
                MessageBox.Show("Вашата лозинка мора да се содржи од:\n-барем една бројка\n-барем една голема буква\n-минималната должина да изнесува 8 карактери", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (usernameCheck() == false)
                MessageBox.Show("Корисничкото име не постои!", "Грешка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else 
            {
                string ConnectionString = @"Data Source=MIHAJLO;Initial Catalog=Users;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UPDATE tblUser SET Password=@Password WHERE Username=@Username", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@Username", txtUser.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtConfirm.Text);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно променета лозинка!", "Порака:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }
    }
}
