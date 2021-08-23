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
    public partial class frmSatis : Form
    {
        Arac_Kiralama arac = new Arac_Kiralama();

        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            string satis = "select* from satis";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, satis);
            arac.Satis_Hesapla(txtHesap);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}
