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
    public partial class frmOgrDetay : Form
    {
        public frmOgrDetay()
        {
            InitializeComponent();
        }
        public string numara;
        //Data Source=NAZMI;Initial Catalog=db_NotKayit;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=NAZMI;Initial Catalog=db_NotKayit;Integrated Security=True");
        private void frmOgrDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *  From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();

            }
            baglanti.Close();
        }
    }
}
