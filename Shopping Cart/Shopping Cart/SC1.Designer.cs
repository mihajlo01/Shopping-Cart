namespace Shopping_Cart
{
    partial class SC1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yourCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиНарачкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаЛистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленчукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.овошјеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.останатоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.јакниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долнаОблекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машиниЗаПерењеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.малиАпаратиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десктопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лаптопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smatPhonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMoiProizvodi = new System.Windows.Forms.GroupBox();
            this.dataGridViewMoiProiz = new System.Windows.Forms.DataGridView();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolichina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.dataGridViewPrikaz = new System.Windows.Forms.DataGridView();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDetali = new System.Windows.Forms.Button();
            this.btnCisti = new System.Windows.Forms.Button();
            this.btnProdolzi = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslAzbucen = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslCenaNV = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslCenaVN = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.избришиКорисникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbMoiProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoiProiz)).BeginInit();
            this.gbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourCartToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.заНасToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yourCartToolStripMenuItem
            // 
            this.yourCartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиНарачкиToolStripMenuItem,
            this.новаЛистаToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.yourCartToolStripMenuItem.Name = "yourCartToolStripMenuItem";
            this.yourCartToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.yourCartToolStripMenuItem.Text = "Моја Кошничка";
            // 
            // моиНарачкиToolStripMenuItem
            // 
            this.моиНарачкиToolStripMenuItem.Name = "моиНарачкиToolStripMenuItem";
            this.моиНарачкиToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.моиНарачкиToolStripMenuItem.Text = "Мои нарачки";
            this.моиНарачкиToolStripMenuItem.Click += new System.EventHandler(this.моиНарачкиToolStripMenuItem_Click);
            // 
            // новаЛистаToolStripMenuItem
            // 
            this.новаЛистаToolStripMenuItem.Name = "новаЛистаToolStripMenuItem";
            this.новаЛистаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новаЛистаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.новаЛистаToolStripMenuItem.Text = "Нова листа";
            this.новаЛистаToolStripMenuItem.Click += new System.EventHandler(this.новаЛистаToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToolStripMenuItem.Text = "Зачувај";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Излез";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.textileToolStripMenuItem,
            this.homeProductsToolStripMenuItem,
            this.computersToolStripMenuItem,
            this.smatPhonesToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.productsToolStripMenuItem.Text = "Производи";
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зеленчукToolStripMenuItem,
            this.овошјеToolStripMenuItem,
            this.останатоToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.foodToolStripMenuItem.Text = "Јадење";
            // 
            // зеленчукToolStripMenuItem
            // 
            this.зеленчукToolStripMenuItem.Name = "зеленчукToolStripMenuItem";
            this.зеленчукToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.зеленчукToolStripMenuItem.Text = "Зеленчук";
            this.зеленчукToolStripMenuItem.Click += new System.EventHandler(this.зеленчукToolStripMenuItem_Click);
            // 
            // овошјеToolStripMenuItem
            // 
            this.овошјеToolStripMenuItem.Name = "овошјеToolStripMenuItem";
            this.овошјеToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.овошјеToolStripMenuItem.Text = "Овошје";
            this.овошјеToolStripMenuItem.Click += new System.EventHandler(this.овошјеToolStripMenuItem_Click);
            // 
            // останатоToolStripMenuItem
            // 
            this.останатоToolStripMenuItem.Name = "останатоToolStripMenuItem";
            this.останатоToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.останатоToolStripMenuItem.Text = "Останато";
            this.останатоToolStripMenuItem.Click += new System.EventHandler(this.останатоToolStripMenuItem_Click);
            // 
            // textileToolStripMenuItem
            // 
            this.textileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.јакниToolStripMenuItem,
            this.долнаОблекаToolStripMenuItem});
            this.textileToolStripMenuItem.Name = "textileToolStripMenuItem";
            this.textileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.textileToolStripMenuItem.Text = "Текстил";
            // 
            // јакниToolStripMenuItem
            // 
            this.јакниToolStripMenuItem.Name = "јакниToolStripMenuItem";
            this.јакниToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.јакниToolStripMenuItem.Text = "Јакни";
            this.јакниToolStripMenuItem.Click += new System.EventHandler(this.јакниToolStripMenuItem_Click);
            // 
            // долнаОблекаToolStripMenuItem
            // 
            this.долнаОблекаToolStripMenuItem.Name = "долнаОблекаToolStripMenuItem";
            this.долнаОблекаToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.долнаОблекаToolStripMenuItem.Text = "Долна облека";
            this.долнаОблекаToolStripMenuItem.Click += new System.EventHandler(this.долнаОблекаToolStripMenuItem_Click);
            // 
            // homeProductsToolStripMenuItem
            // 
            this.homeProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.машиниЗаПерењеToolStripMenuItem,
            this.малиАпаратиToolStripMenuItem});
            this.homeProductsToolStripMenuItem.Name = "homeProductsToolStripMenuItem";
            this.homeProductsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.homeProductsToolStripMenuItem.Text = "Бела Техника";
            // 
            // машиниЗаПерењеToolStripMenuItem
            // 
            this.машиниЗаПерењеToolStripMenuItem.Name = "машиниЗаПерењеToolStripMenuItem";
            this.машиниЗаПерењеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.машиниЗаПерењеToolStripMenuItem.Text = "Машини за перење алишта";
            this.машиниЗаПерењеToolStripMenuItem.Click += new System.EventHandler(this.машиниЗаПерењеToolStripMenuItem_Click);
            // 
            // малиАпаратиToolStripMenuItem
            // 
            this.малиАпаратиToolStripMenuItem.Name = "малиАпаратиToolStripMenuItem";
            this.малиАпаратиToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.малиАпаратиToolStripMenuItem.Text = "Мали апарати";
            this.малиАпаратиToolStripMenuItem.Click += new System.EventHandler(this.малиАпаратиToolStripMenuItem_Click);
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.десктопToolStripMenuItem,
            this.лаптопToolStripMenuItem});
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.computersToolStripMenuItem.Text = "Компјутери";
            // 
            // десктопToolStripMenuItem
            // 
            this.десктопToolStripMenuItem.Name = "десктопToolStripMenuItem";
            this.десктопToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.десктопToolStripMenuItem.Text = "Десктоп";
            this.десктопToolStripMenuItem.Click += new System.EventHandler(this.десктопToolStripMenuItem_Click);
            // 
            // лаптопToolStripMenuItem
            // 
            this.лаптопToolStripMenuItem.Name = "лаптопToolStripMenuItem";
            this.лаптопToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.лаптопToolStripMenuItem.Text = "Лаптоп";
            this.лаптопToolStripMenuItem.Click += new System.EventHandler(this.лаптопToolStripMenuItem_Click);
            // 
            // smatPhonesToolStripMenuItem
            // 
            this.smatPhonesToolStripMenuItem.Name = "smatPhonesToolStripMenuItem";
            this.smatPhonesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.smatPhonesToolStripMenuItem.Text = "Телефони";
            this.smatPhonesToolStripMenuItem.Click += new System.EventHandler(this.smatPhonesToolStripMenuItem_Click);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.заНасToolStripMenuItem.Text = "За нас";
            this.заНасToolStripMenuItem.Click += new System.EventHandler(this.заНасToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem1,
            this.избришиКорисникToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logOutToolStripMenuItem.Text = "Корисник";
            // 
            // gbMoiProizvodi
            // 
            this.gbMoiProizvodi.Controls.Add(this.dataGridViewMoiProiz);
            this.gbMoiProizvodi.Location = new System.Drawing.Point(14, 294);
            this.gbMoiProizvodi.Name = "gbMoiProizvodi";
            this.gbMoiProizvodi.Size = new System.Drawing.Size(354, 186);
            this.gbMoiProizvodi.TabIndex = 1;
            this.gbMoiProizvodi.TabStop = false;
            this.gbMoiProizvodi.Text = "Мои производи";
            // 
            // dataGridViewMoiProiz
            // 
            this.dataGridViewMoiProiz.AllowUserToAddRows = false;
            this.dataGridViewMoiProiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoiProiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proizvod,
            this.Kolichina,
            this.Cena});
            this.dataGridViewMoiProiz.Location = new System.Drawing.Point(-2, 19);
            this.dataGridViewMoiProiz.Name = "dataGridViewMoiProiz";
            this.dataGridViewMoiProiz.Size = new System.Drawing.Size(345, 160);
            this.dataGridViewMoiProiz.TabIndex = 1;
            // 
            // Proizvod
            // 
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            // 
            // Kolichina
            // 
            this.Kolichina.HeaderText = "Kolichina";
            this.Kolichina.Name = "Kolichina";
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.Controls.Add(this.dataGridViewPrikaz);
            this.gbPrikaz.Location = new System.Drawing.Point(12, 56);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(488, 186);
            this.gbPrikaz.TabIndex = 2;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Приказ на производи";
            // 
            // dataGridViewPrikaz
            // 
            this.dataGridViewPrikaz.AllowUserToResizeColumns = false;
            this.dataGridViewPrikaz.AllowUserToResizeRows = false;
            this.dataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikaz.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewPrikaz.Name = "dataGridViewPrikaz";
            this.dataGridViewPrikaz.Size = new System.Drawing.Size(476, 160);
            this.dataGridViewPrikaz.TabIndex = 0;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(43, 248);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 40);
            this.btnDodadi.TabIndex = 3;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(157, 248);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 40);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Избриши";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDetali
            // 
            this.btnDetali.Location = new System.Drawing.Point(381, 248);
            this.btnDetali.Name = "btnDetali";
            this.btnDetali.Size = new System.Drawing.Size(75, 40);
            this.btnDetali.TabIndex = 5;
            this.btnDetali.Text = "Детали за производ";
            this.btnDetali.UseVisualStyleBackColor = true;
            this.btnDetali.Click += new System.EventHandler(this.btnDetali_Click);
            // 
            // btnCisti
            // 
            this.btnCisti.Location = new System.Drawing.Point(268, 248);
            this.btnCisti.Name = "btnCisti";
            this.btnCisti.Size = new System.Drawing.Size(75, 40);
            this.btnCisti.TabIndex = 6;
            this.btnCisti.Text = "Исчисти листа";
            this.btnCisti.UseVisualStyleBackColor = true;
            this.btnCisti.Click += new System.EventHandler(this.btnCisti_Click);
            // 
            // btnProdolzi
            // 
            this.btnProdolzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdolzi.Location = new System.Drawing.Point(236, 486);
            this.btnProdolzi.Name = "btnProdolzi";
            this.btnProdolzi.Size = new System.Drawing.Size(121, 35);
            this.btnProdolzi.TabIndex = 7;
            this.btnProdolzi.Text = "ПРОДОЛЖИ";
            this.btnProdolzi.UseVisualStyleBackColor = true;
            this.btnProdolzi.Click += new System.EventHandler(this.btnProdolzi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tslAzbucen,
            this.toolStripSeparator2,
            this.tslCenaNV,
            this.toolStripSeparator3,
            this.tslCenaVN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Подреди:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslAzbucen
            // 
            this.tslAzbucen.Name = "tslAzbucen";
            this.tslAzbucen.Size = new System.Drawing.Size(31, 22);
            this.tslAzbucen.Text = "А-Ш";
            this.tslAzbucen.Click += new System.EventHandler(this.tslAzbucen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslCenaNV
            // 
            this.tslCenaNV.Name = "tslCenaNV";
            this.tslCenaNV.Size = new System.Drawing.Size(127, 22);
            this.tslCenaNV.Text = "Цена Ниска-> Висока";
            this.tslCenaNV.Click += new System.EventHandler(this.tslCenaNV_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslCenaVN
            // 
            this.tslCenaVN.Name = "tslCenaVN";
            this.tslCenaVN.Size = new System.Drawing.Size(130, 22);
            this.tslCenaVN.Text = "Цена Висока -> Ниска";
            this.tslCenaVN.Click += new System.EventHandler(this.tslCenaVN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created by Avram";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // избришиКорисникToolStripMenuItem
            // 
            this.избришиКорисникToolStripMenuItem.Name = "избришиКорисникToolStripMenuItem";
            this.избришиКорисникToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.избришиКорисникToolStripMenuItem.Text = "Избриши корисник";
            this.избришиКорисникToolStripMenuItem.Click += new System.EventHandler(this.избришиКорисникToolStripMenuItem_Click);
            // 
            // SC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnProdolzi);
            this.Controls.Add(this.btnCisti);
            this.Controls.Add(this.btnDetali);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.gbMoiProizvodi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SC1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.SC1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMoiProizvodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoiProiz)).EndInit();
            this.gbPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yourCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленчукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem овошјеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem останатоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem јакниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долнаОблекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машиниЗаПерењеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem малиАпаратиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smatPhonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десктопToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лаптопToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMoiProizvodi;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDetali;
        private System.Windows.Forms.Button btnCisti;
        private System.Windows.Forms.Button btnProdolzi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslAzbucen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslCenaNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslCenaVN;
        private System.Windows.Forms.DataGridView dataGridViewMoiProiz;
        private System.Windows.Forms.DataGridView dataGridViewPrikaz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolichina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.ToolStripMenuItem новаЛистаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem моиНарачкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem избришиКорисникToolStripMenuItem;
    }
}