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
    public partial class frmSifremiUnuttum : Form
    {
        Arac_Kiralama sifreYenile = new Arac_Kiralama();
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == txtSifre2.Text)
             {
                //sifreYenile.sifreGuncelle(txtKullanici, txtSifre, txtSifre2);
                 string sifreGuncelle = "update login set kullaniciadi= @kullaniciadi, sifre=@sifre where kullaniciadi=@kullaniciadi";
                 SqlCommand komut2 = new SqlCommand();
                 komut2.Parameters.AddWithValue("@kullaniciadi", txtKullanici.Text);
                 komut2.Parameters.AddWithValue("@sifre", txtSifre.Text);
                 sifreYenile.ekle_sil_guncelle(komut2, sifreGuncelle);
                 MessageBox.Show("Şifreniz başarıyla değiştirildi.Lütfen tekrar giriş yapınız.");
                 frmLogin login = new frmLogin();
                 login.ShowDialog();
             }
            else
            {
                MessageBox.Show("Lütfen aynı şifreler girin");
            }
            
        }
    }
}
