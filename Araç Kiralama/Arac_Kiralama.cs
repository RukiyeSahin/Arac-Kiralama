using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public class Arac_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7OBJFB;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open(); //bağlantıyı açtık
            komut.Connection = baglanti;
            komut.CommandText = sorgu; //srg den alınacak
            komut.ExecuteNonQuery();  //işlemi onaylama
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            return tablo;
            baglanti.Close();

        }
        public SqlDataReader giris(TextBox kullaniciadi, TextBox sifre)
        {
            baglanti.Open();          
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;        
            komut.CommandText = "select * from login  where kullaniciadi ='" +kullaniciadi.Text + "' and sifre='"+sifre.Text+"'";
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                MessageBox.Show("Giriş Başarılı");                
                frmAnasayfa anasayfa = new frmAnasayfa();
                anasayfa.ShowDialog();
                frmLogin login = new frmLogin();
                login.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı veya şifre yanlış");
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            baglanti.Close();
            return read;
        }

       /*public SqlDataReader sifreGuncelle(TextBox kullaniciadi, TextBox sifre,TextBox sifre2 )
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from login where kullaniciadi=@kullaniciadi";
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read() == true)
            {
               if(sifre.Text== sifre2.Text)
                {
                    komut.CommandText = "update login set kullaniciadi= @kullaniciadi, sifre=@sifre where kullaniciadi=@kullaniciadi";
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.Lütfen tekrar giriş yapınız.");
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                komut.CommandText = "update login set kullaniciadi= @kullaniciadi, sifre=@sifre where kullaniciadi=@kullaniciadi";
               
                MessageBox.Show("Şifreniz başarıyla değiştirildi.Lütfen tekrar giriş yapınız. ");
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı veya şifre yanlış");
            }
            baglanti.Close();
            return read;
        }*/

        /* public void yeniKullanici(TextBox kullaniciadi, TextBox sifre)
         {
             baglanti.Open();
             SqlCommand komut = new SqlCommand();
             komut.CommandText = "insert into  login ";
         }
     */

        public void Bos_Araclar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        public void Tc_Ara(TextBox tcara,TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
        public void Ucret_Hesapla(ComboBox cmbKiraSekli, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cmbKiraSekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString())*1).ToString();
                if (cmbKiraSekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.8).ToString();
                if (cmbKiraSekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.7).ToString();
            }
            baglanti.Close();
        }

        public void Combodan_Getir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil , TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }

        public void Satis_Hesapla(TextBox txt)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satis",baglanti);
            txt.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "TL";
            
            baglanti.Close();


        }
    }
}
