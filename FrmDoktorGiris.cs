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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantısı bgl=new sqlBaglantısı();
        Sorgular sorgu=new Sorgular();
        
        private void btnhastageridön_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }

        private void btnhastagirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand dGiris = bgl.sorguOlustur(sorgu.Doktor_Giris());
            dGiris.Parameters.AddWithValue("@p1", mskdoktortc.Text);
            dGiris.Parameters.AddWithValue("@p2", txtdoktorsifre.Text);
            SqlDataReader verioku= dGiris.ExecuteReader();
            if(verioku.Read())
            {
                FrmDoktorDetay doktorDetay = new FrmDoktorDetay();
                doktorDetay.doktorTc=mskdoktortc.Text;
                doktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Tc Veya Şifre Hatalı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

        }
    }
}
