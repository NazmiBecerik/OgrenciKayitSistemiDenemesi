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
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NAZMI;Initial Catalog=db_NotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_NotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.db_NotKayitDataSet.TBLDERS);

        }

        private void btnOgrKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)",baglanti);                                              
                komut.Parameters.AddWithValue("@P1", mskNumara.Text);
                komut.Parameters.AddWithValue("@P2", tbxAd.Text);
                komut.Parameters.AddWithValue("@P3", tbxSoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci sisteme eklendi");
                this.tBLDERSTableAdapter.Fill(this.db_NotKayitDataSet.TBLDERS);
            
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxAd.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbxSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tbxSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(tbxSinav1.Text);
            s2 = Convert.ToDouble(tbxSinav2.Text);
            s3 = Convert.ToDouble(tbxSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50) 
            {
                durum = "True";
            
            }
            else
            {
                durum = "False";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6",baglanti);
            komut.Parameters.AddWithValue("@P1", tbxSinav1.Text);
            komut.Parameters.AddWithValue("@P2", tbxSinav2.Text);
            komut.Parameters.AddWithValue("@P3", tbxSinav3.Text);
            komut.Parameters.AddWithValue("@P4",decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5",durum);
            komut.Parameters.AddWithValue("@P6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci notları güncellendi");
            this.tBLDERSTableAdapter.Fill(this.db_NotKayitDataSet.TBLDERS);
        }
    }
}
