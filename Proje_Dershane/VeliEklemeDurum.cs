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
    public partial class VeliEklemeDurum : Form
    {
        public VeliEklemeDurum()
        {
            InitializeComponent();
        }

        private void VeliEklemeDurum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dershaneDataSet41.Tbl_Dershane_Veli' table. You can move, or remove it, as needed.
            this.tbl_Dershane_VeliTableAdapter.Fill(this.dershaneDataSet41.Tbl_Dershane_Veli);
            // TODO: This line of code loads data into the 'dershaneDataSet40.Tbl_Dershane_VeliEklemeDurum' table. You can move, or remove it, as needed.
            this.tbl_Dershane_VeliEklemeDurumTableAdapter.Fill(this.dershaneDataSet40.Tbl_Dershane_VeliEklemeDurum);

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }
    }
}
