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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            SqlCommand duyuru = bgl.sorguOlustur(sorgu.Duyuru_Görüntüle());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(duyuru);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay sDetay=new FrmSekreterDetay();
            sDetay.Show();
            this.Hide();
        }
    }
}
