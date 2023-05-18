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
    public partial class OgretmenBilgi : Form
    {
        public OgretmenBilgi()
        {
            InitializeComponent();
        }

        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");

        private void OgretmenBilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet33.Tbl_Dershane_Ogretmen' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgretmenTableAdapter.Fill(this.dershaneDataSet33.Tbl_Dershane_Ogretmen);
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

            SqlCommand sil = new SqlCommand("Delete from Tbl_Dershane_Ogretmen where OgretmenID=@s1", baglanti);

            sil.Parameters.AddWithValue("@s1", txtID.Text);
            sil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Tbl_Dershane_Ogretmen Set OgretmenAd = @a1, OgretmenSoyad = @a2, OgretmenTC = @a3, OgretmenDogumTarihi = @a4, OgretmenTel = @a5, OgretmenAdres = @a6, OgretmenBrans = @a7, OgretmenTecrube = @a8, OgretmenMaas = @a9 where OgretmenID = @a10", baglanti);


            guncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", maskedTextTC.Text);
            guncelle.Parameters.AddWithValue("@a4", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@a5", maskedTextTel.Text);
            guncelle.Parameters.AddWithValue("@a6", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@a7", comboBoxBrans.Text);
            guncelle.Parameters.AddWithValue("@a8", txtTecrube.Text);
            guncelle.Parameters.AddWithValue("@a9", txtMaas.Text);
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
            //dateTimePicker1.Value = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            comboBoxBrans.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtTecrube.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_Dershane_OgretmenTableAdapter.Fill(this.dershaneDataSet33.Tbl_Dershane_Ogretmen);

            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedTextTC.Text = "";
            maskedTextTel.Text = "";
            txtAdres.Text = "";
            comboBoxBrans.SelectedItem = null;
            txtTecrube.Text = "";
            txtMaas.Text = "";
        }
    }
}
