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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu = new Sorgular();

        private void btnuyekaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut =bgl.sorguOlustur(sorgu.Sisteme_Hasta_Ekle());

            komut.Parameters.AddWithValue("@h1",textüyead.Text);
            komut.Parameters.AddWithValue("@h2",textüyesoyad.Text);
            komut.Parameters.AddWithValue("@h3",msküyetc.Text);
            komut.Parameters.AddWithValue("@h4",maskedtelefon.Text);
            komut.Parameters.AddWithValue("@h5",textüyesifre.Text);
            komut.Parameters.AddWithValue("@h6",comboüyecinsiyet.Text);
            komut.ExecuteNonQuery();//insert,delete,update gibi veri tabanı üzerinde değişik lik yapan sorgularda kullanılan fonksiyon
            bgl.baglanti().Close();
            //
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz: " + textüyesifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Close();
        }

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris= new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }
    }
}
