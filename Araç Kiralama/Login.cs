using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmLogin : Form
    {   Arac_Kiralama login = new Arac_Kiralama();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }       

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtSifreKayit.Text == txtSifreTekrar.Text)
            {
                string loginn = "insert into login (kullaniciadi, sifre) values (@kullaniciadi, @sifre)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@kullaniciadi", txtKullaniciKayit.Text);
                komut2.Parameters.AddWithValue("@sifre", txtSifreKayit.Text);
                login.ekle_sil_guncelle(komut2, loginn);
                MessageBox.Show("Kullanıcı Başarıyla Kaydedildi");
                txtKullaniciKayit.Clear();
                txtSifreKayit.Clear();
                txtSifreTekrar.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen aynı şifre girin");
                txtKullaniciKayit.Clear();
                txtSifreKayit.Clear();
                txtSifreTekrar.Clear();
            }
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {

            login.giris(txtKullaniciAdi,txtSifre);
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            //this.Hide();
            /*string kullaniciEkle = "select * from login  where kullaniciadi ='" + txtKullaniciAdi.Text + "' and sifre='" + txtSifre.Text + "'";
            SqlCommand komut2 = new SqlCommand();
            login.ekle_sil_guncelle(komut2, kullaniciEkle);
            MessageBox.Show("Giriş Başarılı");
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();*/

        }

        private void linkLblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum sifremiUnuttum = new frmSifremiUnuttum();
            sifremiUnuttum.ShowDialog();
            this.Hide();


        }
    }
}
