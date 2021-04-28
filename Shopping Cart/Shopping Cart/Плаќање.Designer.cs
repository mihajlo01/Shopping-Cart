namespace Shopping_Cart
{
    partial class Плаќање
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.lblSurnameDB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblVoGotovo = new System.Windows.Forms.Label();
            this.btnPlati = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.rdoMasterCard = new System.Windows.Forms.RadioButton();
            this.lblAdresaDB = new System.Windows.Forms.Label();
            this.rdoPayPall = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име:";
            // 
            // lblNameDB
            // 
            this.lblNameDB.AutoSize = true;
            this.lblNameDB.Location = new System.Drawing.Point(83, 26);
            this.lblNameDB.Name = "lblNameDB";
            this.lblNameDB.Size = new System.Drawing.Size(0, 13);
            this.lblNameDB.TabIndex = 1;
            // 
            // lblSurnameDB
            // 
            this.lblSurnameDB.AutoSize = true;
            this.lblSurnameDB.Location = new System.Drawing.Point(83, 52);
            this.lblSurnameDB.Name = "lblSurnameDB";
            this.lblSurnameDB.Size = new System.Drawing.Size(0, 13);
            this.lblSurnameDB.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(24, 52);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Презиме:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(24, 79);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(42, 13);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Износ:";
            // 
            // lblVoGotovo
            // 
            this.lblVoGotovo.AutoSize = true;
            this.lblVoGotovo.Location = new System.Drawing.Point(79, 79);
            this.lblVoGotovo.Name = "lblVoGotovo";
            this.lblVoGotovo.Size = new System.Drawing.Size(0, 13);
            this.lblVoGotovo.TabIndex = 5;
            // 
            // btnPlati
            // 
            this.btnPlati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlati.Location = new System.Drawing.Point(125, 239);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(75, 23);
            this.btnPlati.TabIndex = 10;
            this.btnPlati.Text = "ПЛАТИ";
            this.btnPlati.UseVisualStyleBackColor = true;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(44, 239);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 11;
            this.btnLeave.Text = "ОТКАЖИ";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Адреса: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Изберете начин на плаќање:";
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Location = new System.Drawing.Point(25, 161);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(49, 17);
            this.rdoVisa.TabIndex = 14;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "VISA";
            this.rdoVisa.UseVisualStyleBackColor = true;
            this.rdoVisa.CheckedChanged += new System.EventHandler(this.rdoVisa_CheckedChanged);
            // 
            // rdoMasterCard
            // 
            this.rdoMasterCard.AutoSize = true;
            this.rdoMasterCard.Location = new System.Drawing.Point(25, 184);
            this.rdoMasterCard.Name = "rdoMasterCard";
            this.rdoMasterCard.Size = new System.Drawing.Size(79, 17);
            this.rdoMasterCard.TabIndex = 15;
            this.rdoMasterCard.TabStop = true;
            this.rdoMasterCard.Text = "MasterCard";
            this.rdoMasterCard.UseVisualStyleBackColor = true;
            this.rdoMasterCard.CheckedChanged += new System.EventHandler(this.rdoMasterCard_CheckedChanged);
            // 
            // lblAdresaDB
            // 
            this.lblAdresaDB.AutoSize = true;
            this.lblAdresaDB.Location = new System.Drawing.Point(83, 105);
            this.lblAdresaDB.Name = "lblAdresaDB";
            this.lblAdresaDB.Size = new System.Drawing.Size(0, 13);
            this.lblAdresaDB.TabIndex = 16;
            // 
            // rdoPayPall
            // 
            this.rdoPayPall.AutoSize = true;
            this.rdoPayPall.Location = new System.Drawing.Point(25, 208);
            this.rdoPayPall.Name = "rdoPayPall";
            this.rdoPayPall.Size = new System.Drawing.Size(63, 17);
            this.rdoPayPall.TabIndex = 17;
            this.rdoPayPall.TabStop = true;
            this.rdoPayPall.Text = "Pay Pall";
            this.rdoPayPall.UseVisualStyleBackColor = true;
            this.rdoPayPall.CheckedChanged += new System.EventHandler(this.rdoPayPall_CheckedChanged);
            // 
            // Плаќање
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 289);
            this.Controls.Add(this.rdoPayPall);
            this.Controls.Add(this.lblAdresaDB);
            this.Controls.Add(this.rdoMasterCard);
            this.Controls.Add(this.rdoVisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnPlati);
            this.Controls.Add(this.lblVoGotovo);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblSurnameDB);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblNameDB);
            this.Controls.Add(this.lblName);
            this.Name = "Плаќање";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плаќање";
            this.Load += new System.EventHandler(this.Плаќање_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameDB;
        private System.Windows.Forms.Label lblSurnameDB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblVoGotovo;
        private System.Windows.Forms.Button btnPlati;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.RadioButton rdoMasterCard;
        private System.Windows.Forms.Label lblAdresaDB;
        private System.Windows.Forms.RadioButton rdoPayPall;
    }
}