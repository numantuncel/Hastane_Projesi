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
using System.Data.Common;

namespace Hastane_Projesi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }


        public string tc;
        
        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu = new Sorgular();

        // randevu alma işlemi için load kısmından ad soyad çekme işlemi
        public string hastaAd;
        public string hastaSoyad;
        
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            // tarih ve saat doktor aktif randevu görüntülemeden girilmemeli
            msktarih.Enabled= false;
            msksaat.Enabled= false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe", 12,FontStyle.Regular);

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Bold);
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Regular);
            
            lbltc.Text = tc;
            // ad soyad çekme
            SqlCommand komut = bgl.sorguOlustur(sorgu.Hasta_Ad_Soyad_Çekme());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader verioku= komut.ExecuteReader();
            while(verioku.Read())
            {
                //randevu alma işlemi için ad soyad parametresi
                hastaAd = verioku[0].ToString();
                hastaSoyad = verioku[1].ToString();

                lbladsoyad.Text = verioku[0]+" " + verioku[1];
                // komut satırı içinde string bir değer varsa boşluk gibi geriye kalanı stringe çevirmeyiz
                // veri okudan gelen 0, ve 1. index

            }
            bgl.baglanti().Close();


            // Randevum
            SqlCommand randevularım =bgl.sorguOlustur(sorgu.Hasta_Randevularım_Görüntüleme());
            randevularım.Parameters.AddWithValue("@r1",tc);

            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(randevularım);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            // Branş çekme işlemi
            SqlCommand komut2 =bgl.sorguOlustur(sorgu.Branş_Adı_Al());
            SqlDataReader verioku2=komut2.ExecuteReader();
            while(verioku2.Read())
            {
                combobranş.Items.Add(verioku2[0]);// 0. indexden başlar sırayla okur // datareader komple okuma işlemidir
                // 0 sadece 0. indexden başlaması gerektiğini belirtir.
            }

            bgl.baglanti().Close();
        }

        private void combobranş_SelectedIndexChanged(object sender, EventArgs e)
        {   
            combodoktor.Items.Clear();
            SqlCommand komut3 = bgl.sorguOlustur(sorgu.Hasta_BransaGöre_DoktorAdSoyad());
            komut3.Parameters.AddWithValue("@p1",combobranş.Text);
            SqlDataReader verioku3 = komut3.ExecuteReader();
            while (verioku3.Read())
            {
                combodoktor.Items.Add(verioku3[0]+" " + verioku3[1]);//ad ve soyad
            }

            bgl.baglanti().Close();
        }

        private void combodoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand AktifRandevular = bgl.sorguOlustur(sorgu.Hasta_DoktoraGöre_AktifRandevular());
            AktifRandevular.Parameters.AddWithValue("@Ar", combodoktor.Text);

            DataTable dt2 = new DataTable();
            SqlDataAdapter veriçek = new SqlDataAdapter(AktifRandevular);
            // tek tırnak tek başına kullanılmaz bu yüzden çift tırnaklar arasında yazılır
            veriçek.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.baglanti().Close();

            msktarih.Enabled = true;
            msksaat.Enabled = true;
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDüzenle frmHastaBilgiDüzenle=new FrmHastaBilgiDüzenle();
            frmHastaBilgiDüzenle.tcno = lbltc.Text;
            frmHastaBilgiDüzenle.Show();
            this.Hide();
        }

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmhastaGiris = new FrmHastaGiris();
            frmhastaGiris.Show();
            this.Close();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand randevuAl = bgl.sorguOlustur(sorgu.Hasta_Randevu_Olustur());
            //
            randevuAl.Parameters.AddWithValue("@p1", msktarih.Text);
            randevuAl.Parameters.AddWithValue("@p2", msksaat.Text);
            randevuAl.Parameters.AddWithValue("@p3",combobranş.Text);
            randevuAl.Parameters.AddWithValue("@p4",combodoktor.Text);
            randevuAl.Parameters.AddWithValue("@p5", 1);
            randevuAl.Parameters.AddWithValue("@p6",hastaAd);
            randevuAl.Parameters.AddWithValue("@p7",hastaSoyad);
            randevuAl.Parameters.AddWithValue("@p8",lbltc.Text);
            randevuAl.Parameters.AddWithValue("@p9",richşikayet.Text);
            randevuAl.ExecuteNonQuery();

            bgl.baglanti().Close();

            //Randevu Alma  İşlemi Yapıldıktan sonra data grid güncel veri ile dolar
            DialogResult result =MessageBox.Show("Randevunuz Aktif","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                SqlCommand randevularım = bgl.sorguOlustur(sorgu.Hasta_Randevularım_Görüntüleme());
                randevularım.Parameters.AddWithValue("@r1", tc);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(randevularım);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();

                SqlCommand AktifRandevular = bgl.sorguOlustur(sorgu.Hasta_DoktoraGöre_AktifRandevular());
                AktifRandevular.Parameters.AddWithValue("@Ar", combodoktor.Text);

                DataTable dt2 = new DataTable();
                SqlDataAdapter veriçek = new SqlDataAdapter(AktifRandevular);
                // tek tırnak tek başına kullanılmaz bu yüzden çift tırnaklar arasında yazılır
                veriçek.Fill(dt2);
                dataGridView2.DataSource = dt2;
                bgl.baglanti().Close(); 
            }
        }
        public int randevuİd;// randevu id ile delete ve update işlemi yapıyoruz    
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;// seçilen hücrennin 0 satır indexi

            randevuİd= Convert.ToInt32(dataGridView1.Rows[secilenSatır].Cells[0].Value);
            msktarih.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            msksaat.Text = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();
            combobranş.Text = dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString();
            combodoktor.Text = dataGridView1.Rows[secilenSatır].Cells[4].Value.ToString();
            richşikayet.Text = dataGridView1.Rows[secilenSatır].Cells[5].Value.ToString();
            
        }

        private void btn_İptalEt_Click(object sender, EventArgs e)
        {
            SqlCommand iptalEt = bgl.sorguOlustur(sorgu.Hasta_Randevu_İptal());
            iptalEt.Parameters.AddWithValue("@p1", randevuİd.ToString());
            iptalEt.ExecuteNonQuery();

            bgl.baglanti().Close();

            //İptal Etme İşlemi Yapıldıktan sonra data grid güncel veri ile dolar.
            DialogResult result =MessageBox.Show("Randevunuz İptal Edilmiştir","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                SqlCommand randevularım = bgl.sorguOlustur(sorgu.Hasta_Randevularım_Görüntüleme());
                randevularım.Parameters.AddWithValue("@r1", tc);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(randevularım);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();

                SqlCommand AktifRandevular = bgl.sorguOlustur(sorgu.Hasta_DoktoraGöre_AktifRandevular());
                AktifRandevular.Parameters.AddWithValue("@Ar", combodoktor.Text);

                DataTable dt2 = new DataTable();
                SqlDataAdapter veriçek = new SqlDataAdapter(AktifRandevular);
                // tek tırnak tek başına kullanılmaz bu yüzden çift tırnaklar arasında yazılır
                veriçek.Fill(dt2);
                dataGridView2.DataSource = dt2;
                bgl.baglanti().Close();
            }
        }
        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand randevuGüncelle = bgl.sorguOlustur(sorgu.Hasta_Randevu_Güncelle());
            randevuGüncelle.Parameters.AddWithValue("@p1",msktarih.Text);
            randevuGüncelle.Parameters.AddWithValue("@p2",msksaat.Text);
            randevuGüncelle.Parameters.AddWithValue("@p3",combobranş.Text);
            randevuGüncelle.Parameters.AddWithValue("@p4",combodoktor.Text);
            randevuGüncelle.Parameters.AddWithValue("@p5",richşikayet.Text);
            randevuGüncelle.Parameters.AddWithValue("@p6", randevuİd);
            randevuGüncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            // Güncellme işlemi yapıldıktan sonra data grid güncel veri ile dolar.
            DialogResult result=MessageBox.Show("Randevu bilgileriniz güncellenmiştir.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result==DialogResult.OK) 
            {
                SqlCommand randevularım = bgl.sorguOlustur(sorgu.Hasta_Randevularım_Görüntüleme());
                randevularım.Parameters.AddWithValue("@r1", tc);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(randevularım);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
                //
                SqlCommand AktifRandevular = bgl.sorguOlustur(sorgu.Hasta_DoktoraGöre_AktifRandevular());
                AktifRandevular.Parameters.AddWithValue("@Ar", combodoktor.Text);

                DataTable dt2 = new DataTable();
                SqlDataAdapter veriçek = new SqlDataAdapter(AktifRandevular);
                // tek tırnak tek başına kullanılmaz bu yüzden çift tırnaklar arasında yazılır
                veriçek.Fill(dt2);
                dataGridView2.DataSource = dt2;
                bgl.baglanti().Close();
            }
        }
    }
}
