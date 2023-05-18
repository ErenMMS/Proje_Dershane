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

namespace Proje_Dershane
{
    public partial class VeliBilgi : Form
    {
        public VeliBilgi()
        {
            InitializeComponent();
        }
        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");

        private void VeliBilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet32.Tbl_Dershane_Veli' table. You can move, or remove it, as needed.
            this.tbl_Dershane_VeliTableAdapter.Fill(this.dershaneDataSet32.Tbl_Dershane_Veli);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Tbl_Dershane_Veli where VeliID=@s1", baglanti);

            sil.Parameters.AddWithValue("@s1", txtID.Text);
            sil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Tbl_Dershane_Veli Set VeliAd = @a1, VeliSoyad = @a2, VeliTC = @a3, VeliDogumTarihi = @a4, VeliTel = @a5, VeliEvAdres = @a6, VeliIsAdres = @a7, VeliEgitim = @a8, VeliGelir = @a9 where VeliID = @a10", baglanti);


            guncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", maskedTextTC.Text);
            guncelle.Parameters.AddWithValue("@a4", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@a5", maskedTextTel.Text);
            guncelle.Parameters.AddWithValue("@a6", txtAdres1.Text);
            guncelle.Parameters.AddWithValue("@a7", txtAdres2.Text);
            guncelle.Parameters.AddWithValue("@a8", comboBoxEgitim.Text);
            guncelle.Parameters.AddWithValue("@a9", txtGelir.Text);
            guncelle.Parameters.AddWithValue("@a10", txtID.Text);

            guncelle.ExecuteNonQuery();// komut çalıştırmak için kullanılır

            baglanti.Close();

            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtAdres1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtAdres2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            comboBoxEgitim.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtGelir.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_Dershane_VeliTableAdapter.Fill(this.dershaneDataSet32.Tbl_Dershane_Veli);

            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedTextTC.Text = "";
            maskedTextTel.Text = "";
            txtAdres1.Text = "";
            txtAdres2.Text = "";
            comboBoxEgitim.SelectedItem = null;
            txtGelir.Text = "";
        }
    }
}
