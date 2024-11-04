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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        public void yenile()
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
            this.Close();
        }

        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frmSdetay=new FrmSekreterDetay();
            frmSdetay.Show();
            this.Hide();
        }
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da=new SqlDataAdapter(bgl.sorguOlustur(sorgu.Doktor_Tüm_Verileri_Al()));
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            dataGridView1.ColumnHeadersDefaultCellStyle.Font=new Font("Segoe",12,FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font=new Font("Segoe",12,FontStyle.Regular);    

            // Branş Alma işlemi
            SqlCommand bransAl=bgl.sorguOlustur(sorgu.Branş_Adı_Al());
            SqlDataReader bransoku=bransAl.ExecuteReader();
            while (bransoku.Read())
            {
                combobranş.Items.Add(bransoku[0]);
            }
            bgl.baglanti().Close(); 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorEkle = bgl.sorguOlustur(sorgu.Doktor_Ekle());
            doktorEkle.Parameters.AddWithValue("@d1", textüyead.Text);
            doktorEkle.Parameters.AddWithValue("@d2", textüyesoyad.Text);
            doktorEkle.Parameters.AddWithValue("@d3", combobranş.Text);
            doktorEkle.Parameters.AddWithValue("@d4", msküyetc.Text);
            doktorEkle.Parameters.AddWithValue("@d5", textüyesifre.Text);
            doktorEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üye Kaydı Yapıldı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            yenile();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int satırNo = dataGridView1.SelectedCells[0].RowIndex;
            textüyead.Text = dataGridView1.Rows[satırNo].Cells[1].Value.ToString();
            textüyesoyad.Text = dataGridView1.Rows[satırNo].Cells[2].Value.ToString();
            combobranş.Text = dataGridView1.Rows[satırNo].Cells[3].Value.ToString();
            msküyetc.Text = dataGridView1.Rows[satırNo].Cells[4].Value.ToString();
            textüyesifre.Text = dataGridView1.Rows[satırNo].Cells[5].Value.ToString();
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand doktorSil = bgl.sorguOlustur(sorgu.Doktor_Sil());
            doktorSil.Parameters.AddWithValue("@dt1",msküyetc.Text);
            doktorSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand dGüncelle=bgl.sorguOlustur(sorgu.Doktor_Güncelle());
            dGüncelle.Parameters.AddWithValue("@p1", textüyead.Text);
            dGüncelle.Parameters.AddWithValue("@p2", textüyesoyad.Text);
            dGüncelle.Parameters.AddWithValue("@p3", combobranş.Text);
            dGüncelle.Parameters.AddWithValue("@p4", msküyetc.Text);
            dGüncelle.Parameters.AddWithValue("@p5", textüyesifre.Text);
            dGüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            yenile();
        }
    }
}
