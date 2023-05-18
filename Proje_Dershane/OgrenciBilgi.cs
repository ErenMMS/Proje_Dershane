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
    public partial class OgrenciBilgi : Form
    {
        public OgrenciBilgi()
        {
            InitializeComponent();
        }

        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");

        private void OgrenciBilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet31.Tbl_Dershane_Veli' table. You can move, or remove it, as needed.
            this.tbl_Dershane_VeliTableAdapter.Fill(this.dershaneDataSet31.Tbl_Dershane_Veli);
            // TODO: This line of code loads data into the 'dershaneDataSet18.Tbl_Dershane_Ogrenci' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgrenciTableAdapter1.Fill(this.dershaneDataSet18.Tbl_Dershane_Ogrenci);
            // TODO: This line of code loads data into the 'dershaneDataSet13.Tbl_Dershane_Sinif' table. You can move, or remove it, as needed.
            this.tbl_Dershane_SinifTableAdapter.Fill(this.dershaneDataSet13.Tbl_Dershane_Sinif);
            
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e) // Silme işlemi yapar
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Tbl_Dershane_Ogrenci where OgrenciID=@s1", baglanti); // veritabanında silme işlemi için delete sorgusu yazıldı
            // where OgrenciID=@s1 kullanılarak @s1 parametresindeki veriye bağlı olarak o verinin silme işlemi koşulu oluşturuldu
            
            sil.Parameters.AddWithValue("@s1", txtID.Text); // txtID de yer alan veri @s1 parametresine aktarıldı
            sil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e) /// Güncelleme işlemi
        {
            baglanti.Open();

            //Update sorgusu yazıldı OgrenciID koşuluna bağlı olarak güncelleme işlemi yapılıyor
            SqlCommand guncelle = new SqlCommand("Update Tbl_Dershane_Ogrenci Set OgrenciAd = @a1, OgrenciSoyad = @a2, OgrenciTC = @a3, OgrenciDogumTarihi = @a4, OgrenciTel = @a5, OgrenciAdres = @a6, VeliID = @a7, SinifID = @a8 where OgrenciID = @a9", baglanti);

            guncelle.Parameters.AddWithValue("@a1", txtAd.Text); // Veriler belirlenmiş parametrelere aktarıldı
            guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", maskedTextTC.Text);
            guncelle.Parameters.AddWithValue("@a4", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@a5", maskedTextTel.Text);
            guncelle.Parameters.AddWithValue("@a6", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@a7", comboBoxVeli.SelectedValue);
            guncelle.Parameters.AddWithValue("@a8", comboBoxSinif.SelectedValue);
            guncelle.Parameters.AddWithValue("@a9", txtID.Text);


            guncelle.ExecuteNonQuery();// komut çalıştırmak için kullanılır

            baglanti.Close();

            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // datagrid e 2 kez tıklanıldığında;
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();                 // tıklanıldığında datagriddeki verilerin belirtilmiş satırları için txtID,TxtAd
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();                 // gibi textbox larda verilerin gösterilmesi sağlandı
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            comboBoxVeli.SelectedValue = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            comboBoxSinif.SelectedValue = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e) // Yenileme işlemi
        {
            //Yenileme butonuna tıklanıldığında sayfa tamamiyle yenilenir textbox larda bulunan veriler temizlenir datagrid tekrardan yüklenerek güncel hali de gösterilmiş olur.
            this.tbl_Dershane_OgrenciTableAdapter1.Fill(this.dershaneDataSet18.Tbl_Dershane_Ogrenci);

            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedTextTC.Text = "";
            maskedTextTel.Text = "";
            txtAdres.Text = "";
            comboBoxVeli.SelectedItem = null;
            comboBoxSinif.SelectedItem = null;
        }

    }
}
