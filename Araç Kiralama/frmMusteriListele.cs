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
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama musteri_listeleme = new Arac_Kiralama();

        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        public void YenileListele()
        {
            string listele = "select * from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = musteri_listeleme.listele(adtr2, listele);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-POSTA";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

            string listele = "select * from musteri where tc like '%"+txtAra.Text+"%'";//girilen tc kısmı nerede olursa olsun 
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = musteri_listeleme.listele(adtr2, listele);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            txtEposta.Text = satir.Cells[4].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string guncelle = "update musteri set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, eposta=@eposta where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@eposta", txtEposta.Text);
            musteri_listeleme.ekle_sil_guncelle(komut2,guncelle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sil = "delete from musteri where tc='" + satir.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            musteri_listeleme.ekle_sil_guncelle(komut2, sil);
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
    
}
