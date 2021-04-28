namespace Shopping_Cart
{
    partial class Картичка
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrKarticka = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtBrIstek = new System.Windows.Forms.TextBox();
            this.btnProdolzi = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внесете информации за вашата картичка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Број на картичка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CVV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата на истекување:";
            // 
            // txtBrKarticka
            // 
            this.txtBrKarticka.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBrKarticka.Location = new System.Drawing.Point(129, 34);
            this.txtBrKarticka.Name = "txtBrKarticka";
            this.txtBrKarticka.Size = new System.Drawing.Size(144, 20);
            this.txtBrKarticka.TabIndex = 4;
            this.txtBrKarticka.Text = "XXXX-XXXX-XXXX-XXXX";
            this.txtBrKarticka.Enter += new System.EventHandler(this.txtBrKarticka_Enter);
            this.txtBrKarticka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrKarticka_KeyPress);
            this.txtBrKarticka.Leave += new System.EventHandler(this.txtBrKarticka_Leave);
            // 
            // txtCVV
            // 
            this.txtCVV.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCVV.Location = new System.Drawing.Point(129, 58);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(65, 20);
            this.txtCVV.TabIndex = 5;
            this.txtCVV.Text = "XXX";
            this.txtCVV.Enter += new System.EventHandler(this.txtCVV_Enter);
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            this.txtCVV.Leave += new System.EventHandler(this.txtCVV_Leave);
            // 
            // txtBrIstek
            // 
            this.txtBrIstek.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBrIstek.Location = new System.Drawing.Point(129, 82);
            this.txtBrIstek.Name = "txtBrIstek";
            this.txtBrIstek.Size = new System.Drawing.Size(65, 20);
            this.txtBrIstek.TabIndex = 6;
            this.txtBrIstek.Text = "XX/XX";
            this.txtBrIstek.Enter += new System.EventHandler(this.txtBrIstek_Enter);
            this.txtBrIstek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrIstek_KeyPress);
            this.txtBrIstek.Leave += new System.EventHandler(this.txtBrIstek_Leave);
            // 
            // btnProdolzi
            // 
            this.btnProdolzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdolzi.Location = new System.Drawing.Point(216, 104);
            this.btnProdolzi.Name = "btnProdolzi";
            this.btnProdolzi.Size = new System.Drawing.Size(101, 35);
            this.btnProdolzi.TabIndex = 7;
            this.btnProdolzi.Text = "ПРОДОЛЖИ";
            this.btnProdolzi.UseVisualStyleBackColor = true;
            this.btnProdolzi.Click += new System.EventHandler(this.btnProdolzi_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 115);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 18);
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Картичка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 151);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProdolzi);
            this.Controls.Add(this.txtBrIstek);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtBrKarticka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Картичка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картичка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrKarticka;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtBrIstek;
        private System.Windows.Forms.Button btnProdolzi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}