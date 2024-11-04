using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHasta = new FrmHastaGiris();
            frmHasta.Show();
            this.Hide();

        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktor = new FrmDoktorGiris();
            frmDoktor.Show();
            this.Hide();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmSekreter =new FrmSekreterGiris();
            frmSekreter.Show();
            this.Hide();
        }


    }
}
