namespace Araç_Kiralama
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnAracListeleme = new System.Windows.Forms.Button();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnSatislar);
            this.panel1.Controls.Add(this.btnSozlesme);
            this.panel1.Controls.Add(this.btnAracListeleme);
            this.panel1.Controls.Add(this.btnAracKayit);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 84);
            this.panel1.TabIndex = 4;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(712, 18);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(101, 49);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.Black;
            this.btnSatislar.Location = new System.Drawing.Point(595, 18);
            this.btnSatislar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(101, 49);
            this.btnSatislar.TabIndex = 12;
            this.btnSatislar.Text = "Satışlar";
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.BackColor = System.Drawing.Color.Black;
            this.btnSozlesme.Location = new System.Drawing.Point(473, 18);
            this.btnSozlesme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(101, 49);
            this.btnSozlesme.TabIndex = 11;
            this.btnSozlesme.Text = "Sözleşme";
            this.btnSozlesme.UseVisualStyleBackColor = false;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // btnAracListeleme
            // 
            this.btnAracListeleme.BackColor = System.Drawing.Color.Black;
            this.btnAracListeleme.Location = new System.Drawing.Point(356, 18);
            this.btnAracListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAracListeleme.Name = "btnAracListeleme";
            this.btnAracListeleme.Size = new System.Drawing.Size(101, 49);
            this.btnAracListeleme.TabIndex = 10;
            this.btnAracListeleme.Text = "Araç Listeleme";
            this.btnAracListeleme.UseVisualStyleBackColor = false;
            this.btnAracListeleme.Click += new System.EventHandler(this.btnAracListeleme_Click);
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.BackColor = System.Drawing.Color.Black;
            this.btnAracKayit.Location = new System.Drawing.Point(240, 18);
            this.btnAracKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(101, 49);
            this.btnAracKayit.TabIndex = 9;
            this.btnAracKayit.Text = "Araç Kayıt";
            this.btnAracKayit.UseVisualStyleBackColor = false;
            this.btnAracKayit.Click += new System.EventHandler(this.btnAracKayit_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.BackColor = System.Drawing.Color.Black;
            this.btnMusteriListeleme.Location = new System.Drawing.Point(133, 18);
            this.btnMusteriListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(101, 49);
            this.btnMusteriListeleme.TabIndex = 8;
            this.btnMusteriListeleme.Text = "Müşteri Listeleme";
            this.btnMusteriListeleme.UseVisualStyleBackColor = false;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.btnMusteriListeleme_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.BackColor = System.Drawing.Color.Black;
            this.btnMusteriEkleme.Location = new System.Drawing.Point(11, 18);
            this.btnMusteriEkleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(101, 49);
            this.btnMusteriEkleme.TabIndex = 7;
            this.btnMusteriEkleme.Text = "Müşteri Ekleme";
            this.btnMusteriEkleme.UseVisualStyleBackColor = false;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.btnMusteriEkleme_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::Araç_Kiralama.Properties.Resources.Bugatti_La_Voiture_Noire_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnAracListeleme;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.Button btnMusteriEkleme;
    }
}

