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
    public partial class frmAracKayit : Form
    { Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
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
                else if (cmbMarka.SelectedIndex==2)
                {
                    cmbSeri.Items.Add("Linea");
                    cmbSeri.Items.Add("Egea");
                }
                else if (cmbMarka.SelectedIndex==3 )
                {
                    cmbSeri.Items.Add("Fiesta");
                    cmbSeri.Items.Add("Focus");
                }

            }
            catch {

                throw;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string aracKayit = "insert into arac (plaka, marka, seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durum) values (@plaka, @marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim, @tarih,@durum)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut2.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@km", txtKm.Text);
            komut2.Parameters.AddWithValue("@yakit", cmbYakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@resim",pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durum", "BOŞ");
            arackiralama.ekle_sil_guncelle(komut2, aracKayit);
            cmbSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = " ";
            pictureBox1.ImageLocation = " ";



        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}
