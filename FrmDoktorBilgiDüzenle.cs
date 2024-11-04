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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu= new Sorgular();


        public string DoktorTc;
        public string DoktorAd;
        public string DoktorSoyad;
        public string DoktorBranş;
        public string DoktorŞifre;

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
            frmDoktorDetay.doktorTc= DoktorTc;// formdan geri döndğümde tc alanı ve ad soyad alanı için 
            frmDoktorDetay.Show();
            this.Close();
        }

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
          
            textüyead.Text=DoktorAd;
            textüyesoyad.Text=DoktorSoyad;
            combobranş.Text = DoktorBranş;
            msküyetc.Text = DoktorTc;
            textüyesifre.Text = DoktorŞifre;

            //branş çekme işlemi
            SqlCommand cmd = bgl.sorguOlustur(sorgu.Branş_Adı_Al());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobranş.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorbilgiGüncelle = bgl.sorguOlustur(sorgu.Doktor_Güncelle());
            doktorbilgiGüncelle.Parameters.AddWithValue("@p1",textüyead.Text);
            doktorbilgiGüncelle.Parameters.AddWithValue("@p2", textüyesoyad.Text);
            doktorbilgiGüncelle.Parameters.AddWithValue("@p3",combobranş.Text);
            doktorbilgiGüncelle.Parameters.AddWithValue("@p4",msküyetc.Text);
            doktorbilgiGüncelle.Parameters.AddWithValue("@p5",textüyesifre.Text);
            doktorbilgiGüncelle.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
            this.Close();
            
        }
    }
}
