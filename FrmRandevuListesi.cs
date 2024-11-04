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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frmSdetay=new FrmSekreterDetay();
            frmSdetay.Show();
            this.Close();
        }
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe", 12, FontStyle.Regular);

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sorgu.Randevu_Listesi(), bgl.baglanti());
            da.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
            bgl.baglanti().Close();

            
        }
        public int secilenSatır;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmSekreterDetay fsDetay = new FrmSekreterDetay();
            secilenSatır = dataGridView1.SelectedCells[0].RowIndex;// seçilen hücrenin 0. satır indexi
            fsDetay.gelenID= dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            fsDetay.gelenTARİH = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            fsDetay.gelenSAAT = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();
            fsDetay.gelenBRANS = dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString();
            fsDetay.gelenDOKTOR = dataGridView1.Rows[secilenSatır].Cells[4].Value.ToString();
            
            if ((bool)dataGridView1.Rows[secilenSatır].Cells[5].Value==false)
            {
                fsDetay.gelenDURUM = "0";
            }
            else
            {
                fsDetay.gelenDURUM = "1";
            }
            fsDetay.gelen_hastaTC = dataGridView1.Rows[secilenSatır].Cells[8].Value.ToString();
            fsDetay.Show();
            this.Close();
        }

        private void textVeriAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("select * from Tbl_Randevular where HastaTC like '" + textVeriAra.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
