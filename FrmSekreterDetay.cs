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
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace Hastane_Projesi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }


        public string TcNo;

        Sorgular sorgu=new Sorgular();
        sqlBaglantısı bgl = new sqlBaglantısı();

        public string branslar;
        // Randevu Listesinden Gelen Değerler
        public string gelenID;
        public string gelenTARİH;
        public string gelenSAAT;
        public string gelenBRANS;
        public string gelenDOKTOR;
        public string gelen_hastaTC;
        public string gelenDURUM;


        //
        
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            // Randevu Listesinden Gelen Veriler
            txtıd.Text = gelenID;
            msktarih.Text = gelenTARİH;
            msksaat.Text = gelenSAAT;
            cmbbrans.Text= gelenBRANS;
            cmbdoktor.Text=gelenDOKTOR;
            msktc.Text = gelen_hastaTC;
            if (gelenDURUM == "1")
            {
                radioDurum.Checked = true;
            }
            else
            {
                radioDurum.Checked=false;
            }

            // BRANSLAR
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sorgu.Brans_Veri_Al(),bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // DOKTORLAR
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sorgu.Doktor_Veri_Al(), bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Dışarıdan Branş Al
            SqlCommand brnasAL = bgl.sorguOlustur(sorgu.Branş_Adı_Al());
            SqlDataReader verioku2= brnasAL.ExecuteReader();
            while (verioku2.Read())
            {
                cmbbrans.Items.Add( verioku2[0]);
            }
            bgl.baglanti().Close();
        }
        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sgiris=new FrmSekreterGiris();
            sgiris.Show();
            this.Close();
        }

        private void btndoktorpnl_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktorPaneli = new FrmDoktorPaneli();
            doktorPaneli.Show();
            
        }

        private void btnbranspnl_Click(object sender, EventArgs e)
        {
            FrmBranşPaneli bpanel=new FrmBranşPaneli();
            bpanel.Show();
            
        }

        private void btnrandevulst_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi rliste=new FrmRandevuListesi();
            rliste.Show();
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = bgl.sorguOlustur(sorgu.Sekreter_Randevu_Oluştur());
            komut3.Parameters.AddWithValue("@p1",msktarih.Text);
            komut3.Parameters.AddWithValue("@p2",msksaat.Text);
            komut3.Parameters.AddWithValue("@p3",cmbbrans.Text);
            komut3.Parameters.AddWithValue("@p4",cmbdoktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand doktorAl = bgl.sorguOlustur(sorgu.Hasta_BransaGöre_DoktorAdSoyad());
            doktorAl.Parameters.AddWithValue("@p2", cmbbrans.Text);
            SqlDataReader verioku3 = doktorAl.ExecuteReader();
            while (verioku3.Read())
            {
                cmbdoktor.Items.Add(verioku3[0] + " " + verioku3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruSor = bgl.sorguOlustur(sorgu.Duyuru_Oluştur());

            duyuruSor.Parameters.AddWithValue("@d1", richduyuru.Text);
            duyuruSor.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand rGüncelle = bgl.sorguOlustur(sorgu.Randevu_Güncelle());

            rGüncelle.Parameters.AddWithValue("@p1",msktarih.Text);
            rGüncelle.Parameters.AddWithValue("@p2", msksaat.Text);
            rGüncelle.Parameters.AddWithValue("@p3", cmbbrans.Text);
            rGüncelle.Parameters.AddWithValue("@p4",cmbdoktor.Text);
            rGüncelle.Parameters.AddWithValue("@p5",radioDurum.Checked);
            rGüncelle.Parameters.AddWithValue("@p6",msktc.Text);
            rGüncelle.Parameters.AddWithValue("@p7",txtıd.Text);
            rGüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Yapıldı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }


    }
}
