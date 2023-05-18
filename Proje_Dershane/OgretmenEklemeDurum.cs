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
    public partial class OgretmenEklemeDurum : Form
    {
        public OgretmenEklemeDurum()
        {
            InitializeComponent();
        }

        private void OgretmenEklemeDurum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet46.Tbl_Dershane_Ogretmen' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgretmenTableAdapter.Fill(this.dershaneDataSet46.Tbl_Dershane_Ogretmen);
            // TODO: This line of code loads data into the 'dershaneDataSet45.Tbl_Dershane_OgretmenEklemeDurum' table. You can move, or remove it, as needed.
            this.tbl_Dershane_OgretmenEklemeDurumTableAdapter.Fill(this.dershaneDataSet45.Tbl_Dershane_OgretmenEklemeDurum);

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }
    }
}
