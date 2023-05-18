using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; // sql komutları girildiğinde çalışması için kütüphane eklendi

namespace Proje_Dershane
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*'; // parola yazıldığında * olarak gösterir
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string parola = textBox2.Text;

            // Data Source = YourDataSource
            con = new SqlConnection("Data Source=DESKTOP-Q3AJI4H;Initial Catalog=Dershane;Integrated Security=True");
            com = new SqlCommand();

            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from Tbl_Dershane_Admin where AdminKullaniciAdi='" + textBox1.Text + // select sorgusu yazıldı kullanıcı adı ve parola ilişkilendirildi
                "'And AdminParola='" + textBox2.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())  // Read komutu ile kontrol sağlanır, veriler veritabanındakiler ile uyuşursa Form2 ye geçiş yapar
            {
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!"); // Yanlışsa MessageBox ile bilgilendirir.
            }

            con.Close();
        }
    }
}
