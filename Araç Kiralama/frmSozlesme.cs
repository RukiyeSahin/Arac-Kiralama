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
    public partial class frmSozlesme : Form
    {
        Arac_Kiralama arac = new Arac_Kiralama();
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            Bos_Araclar();
            Yenile();
        }

        private void Bos_Araclar()
        {
            string sorgu2 = "select * from arac where durum='BOŞ'";
            arac.Bos_Araclar(cmbAraclar, sorgu2);
        }

        private void Yenile()
        {
            string sozlesmeListele = "select * from sozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sozlesmeListele);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {   
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
            arac.Combodan_Getir(cmbAraclar, txtMarka, txtSeri, txtYil, txtRenk, sorgu2);
        }

        private void cmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(cmbKiraSekli, txtKiraUcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCıkıs.Text);
            int gun2 = gun.Days;
            txtGun.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraUcreti.Text)).ToString(); 
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           Temizle();
        }
        public void Temizle()
        {
            dateCıkıs.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            cmbKiraSekli.Text = " ";
            txtKiraUcreti.Text = " ";
            txtGun.Text = " ";
            txtTutar.Text = " ";
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sozlesme(tc, adsoyad, telefon, ehliyetno, e_tarih, e_yer, plaka, marka, seri, yil, renk, kirasekli, kiraucreti, gun, tutar, ctarih, dtarih) values (@tc, @adsoyad, @telefon, @ehliyetno, @e_tarih, @e_yer, @plaka, @marka, @seri, @yil, @renk, @kirasekli,@kiraucreti, @gun, @tutar, @ctarih, @dtarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@e_tarih", txtEhliyetTarih.Text);
            komut.Parameters.AddWithValue("@e_yer", txtEhliyetVerildigiYer.Text);
            komut.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komut.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@yil", txtYil.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komut.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            komut.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@ctarih", dateCıkıs.Text);
            komut.Parameters.AddWithValue("@dtarih", dateDonus.Text);
            arac.ekle_sil_guncelle(komut, sorgu2);

            string sorgu3 = "update arac set durum='DOLU' where plaka='"+cmbAraclar.Text+"'";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            arac.ekle_sil_guncelle(komut2, sorgu3);

            cmbAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();

            foreach (Control item in grpMusteriBilgileri.Controls) if (item is TextBox) item.Text = " ";
            foreach (Control item in grpAracBilgileri.Controls) if (item is TextBox) item.Text = " ";
            cmbAraclar.Text = " ";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");

            


        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in grpMusteriBilgileri.Controls) if (item is TextBox) item.Text = " ";
            string sorgu2 = "select * from musteri where tc like '%" + txtTcAra.Text + "%'";
            arac.Tc_Ara(txtTcAra, txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update sozlesme set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, plaka=@plaka, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where plaka=@plaka";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@e_tarih", txtEhliyetTarih.Text);
            komut.Parameters.AddWithValue("@e_yer", txtEhliyetVerildigiYer.Text);
            komut.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
            komut.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@yil", txtYil.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
            komut.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            komut.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@ctarih", dateCıkıs.Text);
            komut.Parameters.AddWithValue("@dtarih", dateDonus.Text);
            arac.ekle_sil_guncelle(komut, sorgu);
            cmbAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();

            foreach (Control item in grpMusteriBilgileri.Controls) if (item is TextBox) item.Text = " ";
            foreach (Control item in grpAracBilgileri.Controls) if (item is TextBox) item.Text = " ";
            cmbAraclar.Text = " ";
            Temizle();
            MessageBox.Show("Sözleşme Güncellendi");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtEhliyetNo.Text = satir.Cells[3].Value.ToString();
            txtEhliyetTarih.Text = satir.Cells[4].Value.ToString();
            txtEhliyetVerildigiYer.Text = satir.Cells[5].Value.ToString();
            cmbAraclar.Text = satir.Cells[6].Value.ToString();
            txtMarka.Text = satir.Cells[7].Value.ToString();
            txtSeri.Text = satir.Cells[8].Value.ToString();
            txtYil.Text = satir.Cells[9].Value.ToString();
            txtRenk.Text = satir.Cells[10].Value.ToString();
            cmbKiraSekli.Text = satir.Cells[11].Value.ToString();
            txtKiraUcreti.Text = satir.Cells[12].Value.ToString();
            txtGun.Text = satir.Cells[13].Value.ToString();
            txtTutar.Text = satir.Cells[14].Value.ToString();
            dateCıkıs.Text = satir.Cells[15].Value.ToString();
            dateDonus.Text = satir.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            //Gün Farkı Hesapla
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunFarki = bugun - donus;
            int _gunFarki = gunFarki.Days;
            int ucretFarki;
            //Ücret Farkı Hesapla
            ucretFarki = _gunFarki * ucret;
            txtEkstra.Text = ucretFarki.ToString();
            //Toplam tutar hesapla
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            //if(int.Parse(txtEkstra.Text)>=0 && int.Parse(txtEkstra.Text) < 0
            if ( txtEkstra.Text != "")
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int _toplamTutar = _gun * ucret;
                //Toplam tutar gün ve satış toplosuna aktarılacak

                /*string sil = "delete from sozlesme where plaka='"+satir.Cells["plaka"].Value.ToString()+"'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_guncelle(komut,sil);*/
                string durumGuncelle = "update arac set durum='BOŞ' where plaka='"+satir.Cells["plaka"].Value.ToString()+ "'";
                SqlCommand komut2 = new SqlCommand();
                arac.ekle_sil_guncelle(komut2, durumGuncelle);

                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2)";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut3.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut3.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut3.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut3.Parameters.AddWithValue("@seri", satir.Cells["seri"].Value.ToString());
                komut3.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                komut3.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut3.Parameters.AddWithValue("@gun", _gun);
                komut3.Parameters.AddWithValue("@tutar", _toplamTutar);
                komut3.Parameters.AddWithValue("@fiyat", tutar);
                komut3.Parameters.AddWithValue("@tarih1", satir.Cells["ctarih"].Value.ToString());
                komut3.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                arac.ekle_sil_guncelle(komut3, sorgu3);
                MessageBox.Show("Araç teslim edildi.");
                arac.ekle_sil_guncelle(komut3, sorgu3);


                string sorgu4 = "update sozlesme set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, plaka=@plaka, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where plaka=@plaka ";
                SqlCommand komut4 = new SqlCommand();
                komut4.Parameters.AddWithValue("@tc", txtTc.Text);
                komut4.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut4.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut4.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
                komut4.Parameters.AddWithValue("@e_tarih", txtEhliyetTarih.Text);
                komut4.Parameters.AddWithValue("@e_yer", txtEhliyetVerildigiYer.Text);
                komut4.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
                komut4.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut4.Parameters.AddWithValue("@seri", txtSeri.Text);
                komut4.Parameters.AddWithValue("@yil", txtYil.Text);
                komut4.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut4.Parameters.AddWithValue("@kirasekli", cmbKiraSekli.Text);
                komut4.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
                komut4.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
                komut4.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
                komut4.Parameters.AddWithValue("@ctarih", dateCıkıs.Text);
                komut4.Parameters.AddWithValue("@dtarih", dateDonus.Text);
                arac.ekle_sil_guncelle(komut4, sorgu4);

                cmbAraclar.Items.Clear();
                Bos_Araclar();
                Yenile();

                foreach (Control item in grpMusteriBilgileri.Controls) if (item is TextBox) item.Text = " ";
                foreach (Control item in grpAracBilgileri.Controls) if (item is TextBox) item.Text = " ";
                cmbAraclar.Text = " ";
                Temizle();

                txtEkstra.Text = " ";
            }

            else if( txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }

     /*   private void cmbAraclarSoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAraclarSoz.SelectedIndex == 0)
                {
                    Yenile();
                }
            }

            catch
            {

            }
        }*/
    }
}
