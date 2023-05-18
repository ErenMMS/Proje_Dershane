using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Dershane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e) // Butona basıldığında diğer forma geçiş yapar
        {
            OgrenciKayit ff = new OgrenciKayit(); 
            ff.Show();
            this.Hide();
        }

        private void btnOgrenciBilgi_Click(object sender, EventArgs e)
        {
            OgrenciBilgi ff = new OgrenciBilgi();
            ff.Show();
            this.Hide();
        }

        private void btnOgretmenKayit_Click(object sender, EventArgs e)
        {
            OgretmenKayit ff = new OgretmenKayit();
            ff.Show();
            this.Hide();
        }

        private void btnOgretmenBilgi_Click(object sender, EventArgs e)
        {
            OgretmenBilgi ff = new OgretmenBilgi();
            ff.Show();
            this.Hide();
        }

        private void btnVeliKayit_Click(object sender, EventArgs e)
        {
            VeliKayit ff = new VeliKayit();
            ff.Show();
            this.Hide();
        }

        private void btnVeliBilgi_Click(object sender, EventArgs e)
        {
            VeliBilgi ff = new VeliBilgi();
            ff.Show();
            this.Hide();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            DersKayitBilgi ff = new DersKayitBilgi();
            ff.Show();
            this.Hide();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Odeme ff = new Odeme();
            ff.Show();
            this.Hide();
        }

        private void btnVeliDurum_Click(object sender, EventArgs e)
        {
            VeliEklemeDurum ff = new VeliEklemeDurum();
            ff.Show();
            this.Hide();
        }

        private void btnOgrenciDurum_Click(object sender, EventArgs e)
        {
            OgrenciEklemeDurum ff = new OgrenciEklemeDurum();
            ff.Show();
            this.Hide();
        }

        private void btnOgretmenDurum_Click(object sender, EventArgs e)
        {
            OgretmenEklemeDurum ff = new OgretmenEklemeDurum();
            ff.Show();
            this.Hide();
        }

    }
}
