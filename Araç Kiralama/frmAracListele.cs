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
    public partial class frmAracListele : Form
    {
        Arac_Kiralama aracKiralama = new Arac_Kiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            YeniAraclarListesi();
            try
            {
                cmbAraclar.SelectedIndex = 0;
            }
            catch
            {

            }
            
        }
        private void YeniAraclarListesi()
        {
            string aracListele = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
           
            dataGridView1.DataSource = aracKiralama.listele(adtr2, aracListele);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtPlaka.Text = satir.Cells["plaka"].Value.ToString();
            cmbMarka.Text = satir.Cells["marka"].Value.ToString();
            cmbSeri.Text = satir.Cells["seri"].Value.ToString();
            txtYil.Text = satir.Cells["yil"].Value.ToString();
            txtRenk.Text = satir.Cells["renk"].Value.ToString();
            txtKm.Text = satir.Cells["km"].Value.ToString();
            cmbYakit.Text = satir.Cells["yakit"].Value.ToString();
            txtKiraUcreti.Text = satir.Cells["kiraucreti"].Value.ToString();
            pictureBox1.ImageLocation = satir.Cells["resim"].Value.ToString();


        }

        private void btnResimDegistir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string aracGuncelle = "update arac set marka=@marka, seri=@seri, yil=@yil, renk=@renk, km=@km, yakit=@yakit, kiraucreti=@kiraucreti, resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut2.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@km", txtKm.Text);
            komut2.Parameters.AddWithValue("@yakit", cmbYakit.Text);
            //komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durum", "BOŞ");
            aracKiralama.ekle_sil_guncelle(komut2, aracGuncelle);
            cmbSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = " ";
            pictureBox1.ImageLocation = " ";
            YeniAraclarListesi();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sil = "delete from arac where plaka ='" + satir.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            aracKiralama.ekle_sil_guncelle(komut2,sil);
            YeniAraclarListesi();
            cmbSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = " ";
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                if (cmbMarka.SelectedIndex == 0)
                {
                    cmbSeri.Items.Add("Astra");
                    cmbSeri.Items.Add("Vectra");
                    cmbSeri.Items.Add("Corsa");
                }
                else if (cmbMarka.SelectedIndex == 1)
                {
                    cmbSeri.Items.Add("Megan");
                    cmbSeri.Items.Add("Clio");
                }
                else if (cmbMarka.SelectedIndex == 2)
                {
                    cmbSeri.Items.Add("Linea");
                    cmbSeri.Items.Add("Egea");
                }
                else if (cmbMarka.SelectedIndex == 3)
                {
                    cmbSeri.Items.Add("Fiesta");
                    cmbSeri.Items.Add("Focus");
                }

            }
            catch
            {

                throw;
            }
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex == 0)
            {
                YeniAraclarListesi();
            }
            else if (cmbAraclar.SelectedIndex == 1)
            {
                string aracListele = "select * from arac where durum='BOŞ' ";
                SqlDataAdapter adtr2 = new SqlDataAdapter();

                dataGridView1.DataSource = aracKiralama.listele(adtr2, aracListele);
            }
            else if (cmbAraclar.SelectedIndex == 2)
            {
                string aracListele = "select * from arac where durum='DOLU'";
                SqlDataAdapter adtr2 = new SqlDataAdapter();

                dataGridView1.DataSource = aracKiralama.listele(adtr2, aracListele);
            }
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}
