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

namespace OgrenciNotKayitSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            frmOgrDetay frm = new frmOgrDetay();
            frm.numara = mtbox_OgrenciNo.Text;
            frm.Show();
        }

       
         
private void mtbox_OgrenciNo_TextChanged(object sender, EventArgs e)
        {
            if (mtbox_OgrenciNo.Text == "1111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
            }
    }
        
    }
}
