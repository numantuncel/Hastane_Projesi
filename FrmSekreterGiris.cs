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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
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
            SqlCommand komut = bgl.sorguOlustur(sorgu.Sekreter_Giris());
            komut.Parameters.AddWithValue("@p1",msksekretertc.Text);
            komut.Parameters.AddWithValue("@p2",txtsekeretersifre.Text);
            SqlDataReader verioku=komut.ExecuteReader();
            if(verioku.Read())
            {
                FrmSekreterDetay sdetay=new FrmSekreterDetay();
                sdetay.TcNo=msksekretertc.Text;
                sdetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Tc Veya Şifre Hatalı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }
    }
}
