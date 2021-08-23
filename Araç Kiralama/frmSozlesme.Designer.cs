namespace Araç_Kiralama
{
    partial class frmSozlesme
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
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEhliyetVerildigiYer = new System.Windows.Forms.TextBox();
            this.txtEhliyetTarih = new System.Windows.Forms.TextBox();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAracBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.cmbKiraSekli = new System.Windows.Forms.ComboBox();
            this.dateDonus = new System.Windows.Forms.DateTimePicker();
            this.dateCıkıs = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAracTeslim = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cmbAraclarSoz = new System.Windows.Forms.ComboBox();
            this.grpMusteriBilgileri.SuspendLayout();
            this.grpAracBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.label18);
            this.grpMusteriBilgileri.Controls.Add(this.txtTcAra);
            this.grpMusteriBilgileri.Controls.Add(this.label6);
            this.grpMusteriBilgileri.Controls.Add(this.txtEhliyetVerildigiYer);
            this.grpMusteriBilgileri.Controls.Add(this.txtEhliyetTarih);
            this.grpMusteriBilgileri.Controls.Add(this.txtEhliyetNo);
            this.grpMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.txtAdSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.txtTc);
            this.grpMusteriBilgileri.Controls.Add(this.label5);
            this.grpMusteriBilgileri.Controls.Add(this.label4);
            this.grpMusteriBilgileri.Controls.Add(this.label3);
            this.grpMusteriBilgileri.Controls.Add(this.label2);
            this.grpMusteriBilgileri.Controls.Add(this.label1);
            this.grpMusteriBilgileri.ForeColor = System.Drawing.Color.White;
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(33, 51);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(341, 385);
            this.grpMusteriBilgileri.TabIndex = 0;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "TC Ara";
            // 
            // txtTcAra
            // 
            this.txtTcAra.BackColor = System.Drawing.Color.Silver;
            this.txtTcAra.Location = new System.Drawing.Point(152, 70);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(183, 22);
            this.txtTcAra.TabIndex = 13;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ehliyet Verildiği Yer";
            // 
            // txtEhliyetVerildigiYer
            // 
            this.txtEhliyetVerildigiYer.BackColor = System.Drawing.Color.Silver;
            this.txtEhliyetVerildigiYer.Location = new System.Drawing.Point(152, 330);
            this.txtEhliyetVerildigiYer.Name = "txtEhliyetVerildigiYer";
            this.txtEhliyetVerildigiYer.Size = new System.Drawing.Size(183, 22);
            this.txtEhliyetVerildigiYer.TabIndex = 11;
            // 
            // txtEhliyetTarih
            // 
            this.txtEhliyetTarih.BackColor = System.Drawing.Color.Silver;
            this.txtEhliyetTarih.Location = new System.Drawing.Point(152, 281);
            this.txtEhliyetTarih.Name = "txtEhliyetTarih";
            this.txtEhliyetTarih.Size = new System.Drawing.Size(183, 22);
            this.txtEhliyetTarih.TabIndex = 10;
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.BackColor = System.Drawing.Color.Silver;
            this.txtEhliyetNo.Location = new System.Drawing.Point(152, 237);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(183, 22);
            this.txtEhliyetNo.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.Silver;
            this.txtTelefon.Location = new System.Drawing.Point(152, 195);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(183, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Silver;
            this.txtAdSoyad.Location = new System.Drawing.Point(152, 147);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(183, 22);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.Silver;
            this.txtTc.Location = new System.Drawing.Point(152, 104);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(183, 22);
            this.txtTc.TabIndex = 6;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // grpAracBilgileri
            // 
            this.grpAracBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpAracBilgileri.Controls.Add(this.btnTemizle);
            this.grpAracBilgileri.Controls.Add(this.btnHesapla);
            this.grpAracBilgileri.Controls.Add(this.cmbKiraSekli);
            this.grpAracBilgileri.Controls.Add(this.dateDonus);
            this.grpAracBilgileri.Controls.Add(this.dateCıkıs);
            this.grpAracBilgileri.Controls.Add(this.txtTutar);
            this.grpAracBilgileri.Controls.Add(this.txtGun);
            this.grpAracBilgileri.Controls.Add(this.txtKiraUcreti);
            this.grpAracBilgileri.Controls.Add(this.txtRenk);
            this.grpAracBilgileri.Controls.Add(this.txtYil);
            this.grpAracBilgileri.Controls.Add(this.txtSeri);
            this.grpAracBilgileri.Controls.Add(this.txtMarka);
            this.grpAracBilgileri.Controls.Add(this.cmbAraclar);
            this.grpAracBilgileri.Controls.Add(this.label17);
            this.grpAracBilgileri.Controls.Add(this.label16);
            this.grpAracBilgileri.Controls.Add(this.label15);
            this.grpAracBilgileri.Controls.Add(this.label14);
            this.grpAracBilgileri.Controls.Add(this.label13);
            this.grpAracBilgileri.Controls.Add(this.label12);
            this.grpAracBilgileri.Controls.Add(this.label11);
            this.grpAracBilgileri.Controls.Add(this.label10);
            this.grpAracBilgileri.Controls.Add(this.label9);
            this.grpAracBilgileri.Controls.Add(this.label8);
            this.grpAracBilgileri.Controls.Add(this.label7);
            this.grpAracBilgileri.ForeColor = System.Drawing.Color.White;
            this.grpAracBilgileri.Location = new System.Drawing.Point(404, 51);
            this.grpAracBilgileri.Name = "grpAracBilgileri";
            this.grpAracBilgileri.Size = new System.Drawing.Size(633, 385);
            this.grpAracBilgileri.TabIndex = 1;
            this.grpAracBilgileri.TabStop = false;
            this.grpAracBilgileri.Text = "Araç Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(379, 317);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(108, 39);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Black;
            this.btnHesapla.Location = new System.Drawing.Point(509, 317);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(108, 39);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // cmbKiraSekli
            // 
            this.cmbKiraSekli.BackColor = System.Drawing.Color.Silver;
            this.cmbKiraSekli.FormattingEnabled = true;
            this.cmbKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.cmbKiraSekli.Location = new System.Drawing.Point(451, 40);
            this.cmbKiraSekli.Name = "cmbKiraSekli";
            this.cmbKiraSekli.Size = new System.Drawing.Size(166, 24);
            this.cmbKiraSekli.TabIndex = 23;
            this.cmbKiraSekli.SelectedIndexChanged += new System.EventHandler(this.cmbKiraSekli_SelectedIndexChanged);
            // 
            // dateDonus
            // 
            this.dateDonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDonus.Location = new System.Drawing.Point(451, 269);
            this.dateDonus.Name = "dateDonus";
            this.dateDonus.Size = new System.Drawing.Size(166, 22);
            this.dateDonus.TabIndex = 22;
            // 
            // dateCıkıs
            // 
            this.dateCıkıs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCıkıs.Location = new System.Drawing.Point(451, 223);
            this.dateCıkıs.Name = "dateCıkıs";
            this.dateCıkıs.Size = new System.Drawing.Size(166, 22);
            this.dateCıkıs.TabIndex = 21;
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.Color.Silver;
            this.txtTutar.Location = new System.Drawing.Point(451, 177);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(166, 22);
            this.txtTutar.TabIndex = 20;
            // 
            // txtGun
            // 
            this.txtGun.BackColor = System.Drawing.Color.Silver;
            this.txtGun.Location = new System.Drawing.Point(451, 131);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(166, 22);
            this.txtGun.TabIndex = 19;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.BackColor = System.Drawing.Color.Silver;
            this.txtKiraUcreti.Location = new System.Drawing.Point(451, 85);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(166, 22);
            this.txtKiraUcreti.TabIndex = 18;
            // 
            // txtRenk
            // 
            this.txtRenk.BackColor = System.Drawing.Color.Silver;
            this.txtRenk.Location = new System.Drawing.Point(102, 244);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(160, 22);
            this.txtRenk.TabIndex = 17;
            // 
            // txtYil
            // 
            this.txtYil.BackColor = System.Drawing.Color.Silver;
            this.txtYil.Location = new System.Drawing.Point(102, 195);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(160, 22);
            this.txtYil.TabIndex = 16;
            // 
            // txtSeri
            // 
            this.txtSeri.BackColor = System.Drawing.Color.Silver;
            this.txtSeri.Location = new System.Drawing.Point(102, 146);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(160, 22);
            this.txtSeri.TabIndex = 15;
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.Color.Silver;
            this.txtMarka.Location = new System.Drawing.Point(102, 97);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(160, 22);
            this.txtMarka.TabIndex = 14;
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.BackColor = System.Drawing.Color.Silver;
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(102, 46);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(160, 24);
            this.cmbAraclar.TabIndex = 11;
            this.cmbAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbAraclar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 505);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(803, 864);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 43);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(932, 863);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 44);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.BackColor = System.Drawing.Color.Black;
            this.btnAracTeslim.ForeColor = System.Drawing.Color.White;
            this.btnAracTeslim.Location = new System.Drawing.Point(674, 868);
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(108, 39);
            this.btnAracTeslim.TabIndex = 3;
            this.btnAracTeslim.Text = "Araç Teslim";
            this.btnAracTeslim.UseVisualStyleBackColor = false;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.BackColor = System.Drawing.Color.Silver;
            this.txtEkstra.Location = new System.Drawing.Point(227, 466);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(183, 22);
            this.txtEkstra.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(34, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Alacak / Verecek Durumu";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Black;
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(33, 868);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(88, 39);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cmbAraclarSoz
            // 
            this.cmbAraclarSoz.BackColor = System.Drawing.Color.Silver;
            this.cmbAraclarSoz.FormattingEnabled = true;
            this.cmbAraclarSoz.Items.AddRange(new object[] {
            "Araclar"});
            this.cmbAraclarSoz.Location = new System.Drawing.Point(866, 466);
            this.cmbAraclarSoz.Name = "cmbAraclarSoz";
            this.cmbAraclarSoz.Size = new System.Drawing.Size(171, 24);
            this.cmbAraclarSoz.TabIndex = 31;
            // 
            // frmSozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Araç_Kiralama.Properties.Resources._1ba3c03b51e1463d81b49099a39a233c0212201717052503764_0__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 937);
            this.Controls.Add(this.cmbAraclarSoz);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAracTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAracBilgileri);
            this.Controls.Add(this.grpMusteriBilgileri);
            this.DoubleBuffered = true;
            this.Name = "frmSozlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme ";
            this.Load += new System.EventHandler(this.frmSozlesme_Load);
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.grpAracBilgileri.ResumeLayout(false);
            this.grpAracBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.TextBox txtEhliyetVerildigiYer;
        private System.Windows.Forms.TextBox txtEhliyetTarih;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAracBilgileri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateDonus;
        private System.Windows.Forms.DateTimePicker dateCıkıs;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbKiraSekli;
        private System.Windows.Forms.Button btnAracTeslim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ComboBox cmbAraclarSoz;
    }
}