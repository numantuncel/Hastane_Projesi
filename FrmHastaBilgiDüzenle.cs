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
    public partial class FrmHastaBilgiDüzenle : Form
    {
        public FrmHastaBilgiDüzenle()
        {
            InitializeComponent();
        }
        // dışardaki forman veir tc çekmek için dışardan erişilebilir tcno.
        public string tcno;
        //
        sqlBaglantısı bgl = new sqlBaglantısı();
        Sorgular sorgular = new Sorgular();

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmHastaDetay hastaDetay=new FrmHastaDetay();
            // form gösterilmeden önce hastadetaya yeniden tc bilgisi gider.
            hastaDetay.tc = msküyetc.Text;
            hastaDetay.Show();
            this.Hide();
        }
        
        private void FrmHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            // form yüklendiğinde dışardan gelen tcno msküye tc ye aktarılır.
            msküyetc.Text=tcno;
            //
            SqlCommand komut = bgl.sorguOlustur(sorgular.Hasta_Bilgi_Düzenle());
            komut.Parameters.AddWithValue("@p1",msküyetc.Text);
            SqlDataReader verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                textüyead.Text = verioku[1].ToString();
                textüyesoyad.Text = verioku[2].ToString();
                comboüyecinsiyet.Text = verioku[6].ToString();
                maskedtelefon.Text = verioku[4].ToString();
                textüyesifre.Text = verioku[5].ToString();
            }

            bgl.baglanti().Close();
        }
        
        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = bgl.sorguOlustur(sorgular.Hasta_Bilgi_Güncelle());
            //
            komut2.Parameters.AddWithValue("@p1",textüyead.Text);
            komut2.Parameters.AddWithValue("@p2",textüyesoyad.Text);
            komut2.Parameters.AddWithValue("@p3",maskedtelefon.Text);
            komut2.Parameters.AddWithValue("@p4", textüyesifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboüyecinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6",msküyetc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            //
            MessageBox.Show("Güncelleme işlemi başarıyla tamamladı. Lütfen yeniden giriş yapın.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk); // hata iconu ünlem
            //
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }
    }
}
