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
    public partial class FrmReçete : Form
    {
        public FrmReçete()
        {
            InitializeComponent();
        }
        sqlBaglantısı bgl = new sqlBaglantısı();
        Sorgular sorgu = new Sorgular();
        public string HastaTC;
        public string HastaAD;
        public string HastaSOYAD;
        
        private void FrmReçete_Load(object sender, EventArgs e)
        {
            mskHastaTC.Text = HastaTC;
        }

        private void btn_Gönder_Click(object sender, EventArgs e)
        {
            SqlCommand gönder = new SqlCommand("insert into Tbl_Reçeteler (AdSoyad,HastaTc,IlacBilgisi)values(@p1,@p2,@p3)", bgl.baglanti());
            string hastaAdSoyad = HastaAD + " " + HastaSOYAD;
            gönder.Parameters.AddWithValue("@p1", hastaAdSoyad);
            gönder.Parameters.AddWithValue("@p2", mskHastaTC.Text);
            gönder.Parameters.AddWithValue("@p3",richTextBox1.Text);
            

            gönder.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Reçete yazma işlemi tamamlanmıştır.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
