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

namespace Hastane_Projesi
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        // giris den tc bigisi çekme işlemi için  
        public string doktorTc;

        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
            this.Close();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
           // hasta hücresi seçilmeden Reçete butonu aktif edilmez reçete id si lazımdır.
           btnReçete.Enabled = false;

           lbltc.Text = doktorTc;

            // data grid yazı boyutu
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Regular);

            // doktora ad soyad çek
            SqlCommand DoktorAdsoyad = bgl.sorguOlustur(sorgu.Doktor_TCye_GöreAdSoyad_Al());
            DoktorAdsoyad.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader doktroadsoyadoku=DoktorAdsoyad.ExecuteReader();
            while (doktroadsoyadoku.Read())
            {
                lbladsoyad.Text = doktroadsoyadoku[0] + " " + doktroadsoyadoku[1];
                
            }
            bgl.baglanti().Close();


            // Doktor Randevu Listesini Çekme İşlemi
            SqlCommand DoktorRls = bgl.sorguOlustur(sorgu.Doktor_RandevuListesi_Görüntüle());
            DoktorRls.Parameters.AddWithValue("Rls1", lbladsoyad.Text);
            DataTable datag1Doldur =new DataTable();
            SqlDataAdapter randevuVeriAl=new SqlDataAdapter(DoktorRls);
            randevuVeriAl.Fill(datag1Doldur);
            dataGridView1.DataSource = datag1Doldur;
          
            

        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
            
        }
        // Burda bilgileri düzenlemek bilgileri karşı forma gönderiyoruz.
        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frmDoktorBilgiDüzenle=new FrmDoktorBilgiDüzenle();
           
            SqlCommand komut = new SqlCommand("Select doktorAD,doktorSOYAD,doktorBRANS,doktorSİFRE from Tbl_Doktorlar where doktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);// yukarıda 0. değer doktorAD 
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                frmDoktorBilgiDüzenle.DoktorAd = veriOku["doktorAD"].ToString();
                frmDoktorBilgiDüzenle.DoktorSoyad = veriOku["doktorSOYAD"].ToString();
                frmDoktorBilgiDüzenle.DoktorBranş = veriOku["doktorBRANS"].ToString();
                frmDoktorBilgiDüzenle.DoktorTc = lbltc.Text;
                frmDoktorBilgiDüzenle.DoktorŞifre = veriOku["doktorSİFRE"].ToString();
            }
            bgl.baglanti().Close();
           
            frmDoktorBilgiDüzenle.Show();
            this.Hide();
        }
        public string gidenHastaAD;
        public string gidenHastaSOYAD;
        public string gidenHastaTc;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmReçete frmReçete = new FrmReçete();
            int satırİndex= dataGridView1.SelectedCells[0].RowIndex;
            gidenHastaAD = dataGridView1.Rows[satırİndex].Cells[2].Value.ToString();
            gidenHastaSOYAD = dataGridView1.Rows[satırİndex].Cells[3].Value.ToString();
            gidenHastaTc = dataGridView1.Rows[satırİndex].Cells[4].Value.ToString();
            rchsikayet.Text = dataGridView1.Rows[satırİndex].Cells[5].Value.ToString();
            btnReçete.Enabled = true;
            
            
        }

        private void btnReçete_Click(object sender, EventArgs e)
        {
            FrmReçete frmReçete = new FrmReçete();
            frmReçete.HastaAD =gidenHastaAD;
            frmReçete.HastaSOYAD=gidenHastaSOYAD;
            frmReçete.HastaTC=gidenHastaTc.ToString();
            frmReçete.Show();
        }
    }
}
