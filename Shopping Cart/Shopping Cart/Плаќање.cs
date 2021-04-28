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
using System.IO;

namespace Shopping_Cart
{
    public partial class Плаќање : Form
    {
        SqlConnection con = new SqlConnection();
        public Плаќање()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Users;Integrated Security=True";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void Плаќање_Load(object sender, EventArgs e)
        {
            var fn = "select FirstName from tblUser where Username='" + LogIn.trans0 + "'";
            var ln = "select LastName from tblUser where Username='" + LogIn.trans0 + "'";
            var adresa= "select Address from tblUser where Username = '" + LogIn.trans0 + "'";
            using (var cmd = new SqlCommand(fn, con))
            {
                con.Open();
                lblNameDB.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            using (var cmd1 = new SqlCommand(ln, con))
            {
                con.Open();
                lblSurnameDB.Text = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            using (var cmd2 = new SqlCommand(adresa, con))
            {
                con.Open();
                lblAdresaDB.Text = cmd2.ExecuteScalar().ToString();
                con.Close();
            }
            lblVoGotovo.Text = SC2.trans1;
        }

        private void rdoVisa_CheckedChanged(object sender, EventArgs e)
        {
            Картичка k = new Картичка();
            k.Show();
        }

        private void rdoMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            Картичка k = new Картичка();
            k.Show();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            string nacin = "";
            if (rdoMasterCard.Checked)
                nacin = "Master Card";
            else if (rdoVisa.Checked)
                nacin = "VISA";
            else if (rdoPayPall.Checked)
                nacin = "PayPall";


            if (rdoMasterCard.Checked || rdoVisa.Checked || rdoPayPall.Checked)
            {
                MessageBox.Show("Успешна трансакција. Ви благодариме што ги користите нашите услуги!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string fileName = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\" + LogIn.trans0 + ".txt";
                if (File.Exists(fileName))
                {
                    FileStream stream = new FileStream(fileName, FileMode.Append);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write("Име: " + lblNameDB.Text + "\n");
                        writer.Write("Презиме: " + lblSurnameDB.Text + "\n");
                        writer.Write("Адреса: " + lblAdresaDB.Text + "\n");
                        writer.Write("Износ: " + lblVoGotovo.Text + "\n");
                        writer.Write("Начин на плаќање: " + nacin + "\n");
                        writer.Write("Дата: " + DateTime.Now.ToLongDateString() + "\n\n\n");
                    }
                }
                else
                {
                    FileStream stream = new FileStream(fileName, FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write("Име: " + lblNameDB.Text + "\n");
                        writer.Write("Презиме: " + lblSurnameDB.Text + "\n");
                        writer.Write("Адреса: " + lblAdresaDB.Text + "\n");
                        writer.Write("Износ: " + lblVoGotovo.Text + "\n");
                        writer.Write("Начин на плаќање: " + nacin + "\n");
                        writer.Write("Дата: " + DateTime.Now.ToLongDateString() + "\n\n\n");
                    }
                }
                LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Ве молиме изберете начин на плаќање!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdoPayPall_CheckedChanged(object sender, EventArgs e)
        {
            PayPall pp = new PayPall();
            pp.Show();
        }
    }
}
