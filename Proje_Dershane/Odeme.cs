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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");

        private void Odeme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet38.Tbl_Dershane_Sinif' table. You can move, or remove it, as needed.
            this.tbl_Dershane_SinifTableAdapter.Fill(this.dershaneDataSet38.Tbl_Dershane_Sinif);
            // TODO: This line of code loads data into the 'dershaneDataSet37.Tbl_Dershane_Ogrenci' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgrenciTableAdapter.Fill(this.dershaneDataSet37.Tbl_Dershane_Ogrenci);
            // TODO: This line of code loads data into the 'dershaneDataSet36.Tbl_Dershane_Ucret' table. You can move, or remove it, as needed.
            this.tbl_Dershane_UcretTableAdapter.Fill(this.dershaneDataSet36.Tbl_Dershane_Ucret);
            comboBoxOgrenci.SelectedItem = null; // başlangıçta öğrenci adı göstermesin diye yazıldı
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("insert into Tbl_Dershane_Ucret (UcretMiktar,UcretOdemeTarihi,OdemeDurumu,OgrenciID)" + "values (@p1,@p2,@p3,@p4)", baglanti);

            sorgu.Parameters.AddWithValue("@p1", comboBoxUcret.Text);
            sorgu.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
            sorgu.Parameters.AddWithValue("@p3", label7.Text);
            sorgu.Parameters.AddWithValue("@p4", comboBoxOgrenci.SelectedValue);

            sorgu.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Tbl_Dershane_Ucret where UcretID=@s1", baglanti);

            sil.Parameters.AddWithValue("@s1", txtID.Text);
            sil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Tbl_Dershane_Ucret Set UcretMiktar = @a1, UcretOdemeTarihi = @a2, OdemeDurumu = @a3, OgrenciID = @a4 where UcretID = @a5", baglanti);

            guncelle.Parameters.AddWithValue("@a1", comboBoxUcret.Text);
            guncelle.Parameters.AddWithValue("@a2", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@a3", label7.Text);
            guncelle.Parameters.AddWithValue("@a4", comboBoxOgrenci.SelectedValue);
            guncelle.Parameters.AddWithValue("@a5", txtID.Text);

            guncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.tbl_Dershane_UcretTableAdapter.Fill(this.dershaneDataSet36.Tbl_Dershane_Ucret);

            txtID.Text = "";
            comboBoxUcret.SelectedItem = null;
            comboBoxOgrenci.SelectedItem = null;
            label7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // radibutton için seçilen verinin sql işlemerini kullanmak için label tercih edildi 
        {
            label7.Text = "true";           //radioButton1 Seçildiğinde label7.Text = "true" diyerek database de bit data tipine sahip sütunun verisi belirtilmiş oldu
            dateTimePicker1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "false";          //radiobutton1 deki işlemlerin false hali
            dateTimePicker1.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBoxUcret.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBoxOgrenci.SelectedValue = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
