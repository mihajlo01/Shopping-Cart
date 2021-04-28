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
using System.Drawing;

namespace Shopping_Cart
{
    public partial class SC2 : Form
    {
        public SC2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Плаќање p = new Плаќање();
            p.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SC1 sc1 = new SC1();
            sc1.Show();
            this.Hide();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.eu.edu.mk/");
        }

        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridView1.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

        private void SC2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridView1.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Value = Convert.ToString(Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value));
            }
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lblSuma.Text = "Износ: " + sum.ToString() + "ден.";
            trans1 = lblSuma.Text.Substring(6);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Mihajlo\\source\\repos\\Shopping Cart\\Shopping Cart\\Производи\\mygrid.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridView1.Columns.Count);
                bw.Write(dataGridView1.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridView1.Rows)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; ++j)
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

        private void печатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));              
            }
        }

        private void btnOdzemi_Click(object sender, EventArgs e)
        {
            int min = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[1].Value.ToString() == "0")
                    continue;
                else
                    row.Cells[1].Value = Convert.ToString(Convert.ToInt32(row.Cells[1].Value)-1);
            }
        }
        public static string trans1 = "";
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Value = Convert.ToString(Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value));       
            }
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lblSuma.Text = "Износ: "+sum.ToString()+"ден.";
            trans1 = lblSuma.Text.Substring(6);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }
    }
}
