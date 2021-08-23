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
    public partial class frmMusteriEkle : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ekle = "insert into musteri(tc,adsoyad,telefon,adres,eposta) values (@tc,@adsoyad,@telefon,@adres,@eposta)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@eposta", txtEposta.Text);
            arac_kiralama.ekle_sil_guncelle(komut2, ekle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";


        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}
