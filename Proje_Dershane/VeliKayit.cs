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
    public partial class VeliKayit : Form
    {
        public VeliKayit()
        {
            InitializeComponent();
        }

        // Data Source= YourDataSource
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

            SqlCommand sorgu = new SqlCommand("insert into Tbl_Dershane_Veli (VeliAd,VeliSoyad,VeliTC,VeliDogumTarihi,VeliTel,VeliEvAdres,VeliIsAdres,VeliEgitim,VeliGelir)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);

            sorgu.Parameters.AddWithValue("@p1", txtAd.Text);
            sorgu.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sorgu.Parameters.AddWithValue("@p3", maskedTextTC.Text);
            sorgu.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            sorgu.Parameters.AddWithValue("@p5", maskedTextTel.Text);
            sorgu.Parameters.AddWithValue("@p6", txtAdres1.Text);
            sorgu.Parameters.AddWithValue("@p7", txtAdres2.Text);
            sorgu.Parameters.AddWithValue("@p8", comboBoxEgitim.Text);
            sorgu.Parameters.AddWithValue("@p9", txtGelir.Text);

            sorgu.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi!");

            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
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
