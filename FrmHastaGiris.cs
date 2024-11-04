using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlBaglantısı bgl = new sqlBaglantısı();
        Sorgular sorgu = new Sorgular();

        private void btngeridön_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }

        private void linkhastaüye_Click(object sender, EventArgs e)
        {
            FrmHastaKayit frm = new FrmHastaKayit();
            frm.Show();
            this.Hide();
        }

        private void btnhastagirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = bgl.sorguOlustur(sorgu.Hasta_Giris());
            komut.Parameters.AddWithValue("@p1", mskhastatc.Text);
            komut.Parameters.AddWithValue("@p2", txthastasifre.Text);
            SqlDataReader verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = mskhastatc.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Tc Veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }
    }
}
