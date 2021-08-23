using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }


        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMusteriEkleme_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();

        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            frmAracKayit kayit = new frmAracKayit();
            kayit.ShowDialog();
        }

        private void btnAracListeleme_Click(object sender, EventArgs e)
        {
            frmAracListele listele = new frmAracListele();
            listele.ShowDialog();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            frmSozlesme sozlesme = new frmSozlesme();
            sozlesme.ShowDialog();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }
    }
}
