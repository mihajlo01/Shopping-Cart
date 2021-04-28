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
    public partial class SC1 : Form
    {
        public SC1()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox1.ImageLocation = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Sliki\\IMG_0931.png";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridViewMoiProiz.Columns.Count);
                bw.Write(dataGridViewMoiProiz.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridViewMoiProiz.Rows)
                {
                    for (int j = 0; j < dataGridViewMoiProiz.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SC1_Load(object sender, EventArgs e)
        {

        }

        private void btnProdolzi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SC2 sc2 = new SC2();
            sc2.Show();
            this.Hide();          
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void зеленчукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Zelencuk";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void овошјеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Ovoshje";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void останатоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Ostanato";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void јакниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Jakni";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void долнаОблекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM DolnaObleka";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void машиниЗаПерењеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM MasiniZaPerenjeAlishta";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void малиАпаратиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM MaliAparati";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void десктопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM DesktopKompjuteri";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void лаптопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM LaptopKompjuteri";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void smatPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Proizvodi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Telefoni";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewPrikaz.DataSource = data;
        }

        private void tslAzbucen_Click(object sender, EventArgs e)
        {
            dataGridViewPrikaz.Sort(dataGridViewPrikaz.Columns[0], ListSortDirection.Ascending);
        }

        private void tslCenaNV_Click(object sender, EventArgs e)
        {
            dataGridViewPrikaz.Sort(dataGridViewPrikaz.Columns[2], ListSortDirection.Ascending);
        }

        private void tslCenaVN_Click(object sender, EventArgs e)
        {
            dataGridViewPrikaz.Sort(dataGridViewPrikaz.Columns[2], ListSortDirection.Descending);
        }
        int i = 0;
        private void btnDodadi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPrikaz.SelectedRows)
            {
                if (dataGridViewPrikaz.CurrentRow.Cells[3].Value.ToString() == "rasprodadeno"|| dataGridViewPrikaz.CurrentRow.Cells[3].Value.ToString() == "naskoro na zaliha")
                {
                    MessageBox.Show("Се извинуваме. Производот кој го избравте моментално е недостапен!", "Порака", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    continue;
                }
                else
                {
                    dataGridViewMoiProiz.Rows.Add();
                    dataGridViewMoiProiz.Rows[i].Cells[0].Value = dataGridViewPrikaz.CurrentRow.Cells[0].Value.ToString();
                    dataGridViewMoiProiz.Rows[i].Cells[1].Value = dataGridViewPrikaz.CurrentRow.Cells[1].Value.ToString();
                    dataGridViewMoiProiz.Rows[i].Cells[2].Value = dataGridViewPrikaz.CurrentRow.Cells[2].Value.ToString();
                    i++;
                }
            }
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridViewMoiProiz.Columns.Count);
                bw.Write(dataGridViewMoiProiz.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridViewMoiProiz.Rows)
                {
                    for (int j = 0; j < dataGridViewMoiProiz.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void btnCisti_Click(object sender, EventArgs e)
        {
            dataGridViewMoiProiz.Rows.Clear();
            i = 0;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMoiProiz.SelectedRows)
            {
                dataGridViewMoiProiz.Rows.RemoveAt(row.Index);
                i--;
            }
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridViewMoiProiz.Columns.Count);
                bw.Write(dataGridViewMoiProiz.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridViewMoiProiz.Rows)
                {
                    for (int j = 0; j < dataGridViewMoiProiz.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void новаЛистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMoiProiz.Rows.Clear();
            i = 0;
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.eu.edu.mk/");
        }

        private void btnDetali_Click(object sender, EventArgs e)
        {     
                foreach (DataGridViewRow row in dataGridViewPrikaz.SelectedRows)
                {
                string proizvod = row.Cells[0].Value.ToString();
                try
                {
                    string fileName = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\" + proizvod + ".txt";
                    StreamReader sr = new StreamReader(fileName);
                    string message = sr.ReadToEnd();
                    string caption = "Детали за производот: " + proizvod;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch
                {
                    string message = "Нема детали за производот!";
                    string caption = "Детали за производот: " + proizvod;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }     
        }

        int k = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Sliki\\" + k + ".png";
            k++;
            if (k == 5)
                k = 1;
        }

        private void моиНарачкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\" + LogIn.trans0+".txt"))
            {
                Нарачки n = new Нарачки();
                n.Show();

            }
            else
            {
                MessageBox.Show("Немате направено нарачка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void избришиКорисникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Дали сакате да продолжите со бришење на корисникот?", "Внимание!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string conS = @"Data Source=DESKTOP-MJM2BE9\MIHAJLO;Initial Catalog=Users;Integrated Security=True";
                SqlConnection con = new SqlConnection(conS);
                string query = "Delete from tblUser where Username= '" + LogIn.trans0 + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                con.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Корисникот е успешно избришан!", "Порака", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                string fileName = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\" + LogIn.trans0 + ".txt";
                if (File.Exists(fileName))
                    File.Delete(fileName);
                LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
            }
        }
    }
}
