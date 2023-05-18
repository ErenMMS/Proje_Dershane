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
    public partial class OgrenciEklemeDurum : Form
    {
        public OgrenciEklemeDurum()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void OgrenciEklemeDurum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet44.Tbl_Dershane_Ogrenci' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgrenciTableAdapter.Fill(this.dershaneDataSet44.Tbl_Dershane_Ogrenci);
            // TODO: This line of code loads data into the 'dershaneDataSet43.Tbl_Dershane_OgrenciEklemeDurum' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgrenciEklemeDurumTableAdapter.Fill(this.dershaneDataSet43.Tbl_Dershane_OgrenciEklemeDurum);

        }
    }
}
