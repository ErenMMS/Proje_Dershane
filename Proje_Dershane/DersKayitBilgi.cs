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
    public partial class DersKayitBilgi : Form
    {
        public DersKayitBilgi()
        {
            InitializeComponent();
        }

        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("insert into Tbl_Dershane_Ders (DersAd,DersGun,DersSaat,SinifID,OgretmenID)" + "values (@p1,@p2,@p3,@p4,@p5)", baglanti);

            sorgu.Parameters.AddWithValue("@p1", comboBoxAd.Text);
            sorgu.Parameters.AddWithValue("@p2", comboBoxGun.Text);
            sorgu.Parameters.AddWithValue("@p3", comboBoxSaat.Text);
            sorgu.Parameters.AddWithValue("@p4", comboBoxSinif.SelectedValue);
            sorgu.Parameters.AddWithValue("@p5", comboBoxOgretmen.SelectedValue);

            sorgu.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi!");

            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Tbl_Dershane_Ders where DersID=@s1", baglanti);

            sil.Parameters.AddWithValue("@s1", txtID.Text);
            sil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Tbl_Dershane_Ders Set DersAd = @a1, DersGun = @a2, DersSaat = @a3, SinifID = @a4, OgretmenID = @a5 where DersID = @a6", baglanti);

            guncelle.Parameters.AddWithValue("@a1", comboBoxAd.Text);
            guncelle.Parameters.AddWithValue("@a2", comboBoxGun.Text);
            guncelle.Parameters.AddWithValue("@a3", comboBoxSaat.Text);
            guncelle.Parameters.AddWithValue("@a4", comboBoxSinif.SelectedValue);
            guncelle.Parameters.AddWithValue("@a5", comboBoxOgretmen.SelectedValue);
            guncelle.Parameters.AddWithValue("@a6", txtID.Text);

            guncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_Dershane_DersTableAdapter.Fill(this.dershaneDataSet30.Tbl_Dershane_Ders);

            txtID.Text = "";
            comboBoxAd.SelectedItem = null; // yenilendiğinde selected item null ile combobox için seçilen veri olmaması sağlandı 
            comboBoxGun.SelectedItem = null;
            comboBoxSaat.SelectedItem = null;
            comboBoxSinif.SelectedItem = null;
            comboBoxOgretmen.SelectedItem = null;
        }

        private void DersKayitBilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet34.Tbl_Dershane_Ogretmen' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgretmenTableAdapter.Fill(this.dershaneDataSet34.Tbl_Dershane_Ogretmen);
            // TODO: This line of code loads data into the 'dershaneDataSet30.Tbl_Dershane_Ders' table. You can move, or remove it, as needed.
            this.tbl_Dershane_DersTableAdapter.Fill(this.dershaneDataSet30.Tbl_Dershane_Ders);
            // TODO: This line of code loads data into the 'dershaneDataSet28.Tbl_Dershane_Sinif' table. You can move, or remove it, as needed.
            this.tbl_Dershane_SinifTableAdapter.Fill(this.dershaneDataSet28.Tbl_Dershane_Sinif);
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBoxAd.SelectedItem = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBoxGun.SelectedItem = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxSaat.SelectedItem = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBoxSinif.SelectedValue = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBoxOgretmen.SelectedValue = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
