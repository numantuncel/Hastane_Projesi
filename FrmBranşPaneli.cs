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
    public partial class FrmBranşPaneli : Form
    {
        public FrmBranşPaneli()
        {
            InitializeComponent();
        }
        public void yenile()
        {
            FrmBranşPaneli bPaneli=new FrmBranşPaneli();
            bPaneli.Show();
            this.Close();
        }
        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frmSdetay=new FrmSekreterDetay();
            frmSdetay.Show();
            this.Hide();
        }
        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();
        private void FrmBranşPaneli_Load(object sender, EventArgs e)
        {
            // Data Grid Doldurma İşlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sorgu.Brans_Veri_Al(), bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Regular);

            // Branş Adı Al
            SqlCommand brnasAL = bgl.sorguOlustur(sorgu.Branş_Adı_Al());
            SqlDataReader verioku2 = brnasAL.ExecuteReader();
            while (verioku2.Read())
            {
                combobranş.Items.Add(verioku2[0]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand bransEkle=bgl.sorguOlustur(sorgu.Branş_Ekle());
            bransEkle.Parameters.AddWithValue("@p1",combobranş.Text);
            bransEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            yenile();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            textbransId.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            combobranş.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand bSil = bgl.sorguOlustur(sorgu.Branş_Sil());
            bSil.Parameters.AddWithValue("@p1", textbransId.Text);
            bSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brnaş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand bGüncelle=bgl.sorguOlustur(sorgu.Branş_Güncelle());
            bGüncelle.Parameters.AddWithValue("@p2",textbransId.Text);
            bGüncelle.Parameters.AddWithValue("@p1",combobranş.Text);
            bGüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            yenile();
        }
    }
}
