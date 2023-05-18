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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        // Data Source = YourDataSource
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True"); //Data kaynağı baglanti değişkenine aktarıldı.

        private void btnAnaSayfa_Click(object sender, EventArgs e) // Ana sayfaya geçiş yapar
        {
            Form2 ff = new Form2(); 
            ff.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e) // Veritabanına kayıt yapar
        {
            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("insert into Tbl_Dershane_Ogrenci (OgrenciAd,OgrenciSoyad,OgrenciTC,OgrenciDogumTarihi,OgrenciTel,OgrenciAdres,VeliID,SinifID)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti); // insert sorgusu ile boşluklara girilen veriler yazılmış parametreler aracılığı ile veri tabanına kaydeder

            sorgu.Parameters.AddWithValue("@p1", txtAd.Text); // Form üzerinde veri girişinin yapıldığı yerlere girilen veriler @p1,2,3.... parametrelerine aktarılır
            sorgu.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sorgu.Parameters.AddWithValue("@p3", maskedTextTC.Text);
            sorgu.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            sorgu.Parameters.AddWithValue("@p5", maskedTextTel.Text);
            sorgu.Parameters.AddWithValue("@p6", txtAdres.Text);
            sorgu.Parameters.AddWithValue("@p7", comboBoxVeli.SelectedValue);
            sorgu.Parameters.AddWithValue("@p8", comboBoxSinif.SelectedValue);

            sorgu.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi!");

            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e) // Temizleme işlemi, boşluklarda yazılanları temizler
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedTextTC.Text = "";
            maskedTextTel.Text = "";
            txtAdres.Text = "";
            comboBoxVeli.SelectedItem = null;
            comboBoxSinif.SelectedItem = null;
        }

        private void OgrenciKayit_Load(object sender, EventArgs e) // OgrenciKayit sayfası yüklendiğinde aşağıda belirtilmiş olan dataset leri yükler
        {
            // TODO: This line of code loads data into the 'dershaneDataSet39.Tbl_Dershane_Veli' table. You can move, or remove it, as needed.
            this.tbl_Dershane_VeliTableAdapter.Fill(this.dershaneDataSet39.Tbl_Dershane_Veli);
            // TODO: This line of code loads data into the 'dershaneDataSet15.Tbl_Dershane_Sinif' table. You can move, or remove it, as needed.
            this.tbl_Dershane_SinifTableAdapter.Fill(this.dershaneDataSet15.Tbl_Dershane_Sinif);
        }
    }
}
