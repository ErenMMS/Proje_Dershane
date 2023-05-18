
namespace Proje_Dershane
{
    partial class OgrenciKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.tblDershaneSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet15 = new Proje_Dershane.DershaneDataSet15();
            this.tbl_Dershane_SinifTableAdapter = new Proje_Dershane.DershaneDataSet15TableAdapters.Tbl_Dershane_SinifTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.veliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeliEvAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneVeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet39 = new Proje_Dershane.DershaneDataSet39();
            this.comboBoxVeli = new System.Windows.Forms.ComboBox();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.tbl_Dershane_VeliTableAdapter = new Proje_Dershane.DershaneDataSet39TableAdapters.Tbl_Dershane_VeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet39)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cep Telefon No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ev adresi :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(142, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(142, 137);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(142, 312);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 55);
            this.txtAdres.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(23, 529);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(288, 46);
            this.btnAnaSayfa.TabIndex = 10;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(180, 468);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 46);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 42);
            this.label7.TabIndex = 14;
            this.label7.Text = "Öğrenci Kayıt Sistemi";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(23, 468);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(131, 46);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Veli Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(27, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sınıf Adı :";
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.DataSource = this.tblDershaneSinifBindingSource;
            this.comboBoxSinif.DisplayMember = "SinifAd";
            this.comboBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(142, 424);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSinif.TabIndex = 7;
            this.comboBoxSinif.ValueMember = "SinifID";
            // 
            // tblDershaneSinifBindingSource
            // 
            this.tblDershaneSinifBindingSource.DataMember = "Tbl_Dershane_Sinif";
            this.tblDershaneSinifBindingSource.DataSource = this.dershaneDataSet15;
            // 
            // dershaneDataSet15
            // 
            this.dershaneDataSet15.DataSetName = "DershaneDataSet15";
            this.dershaneDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Dershane_SinifTableAdapter
            // 
            this.tbl_Dershane_SinifTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn,
            this.sinifAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneSinifBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(339, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(205, 232);
            this.dataGridView1.TabIndex = 12;
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            this.sinifIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinifIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // sinifAdDataGridViewTextBoxColumn
            // 
            this.sinifAdDataGridViewTextBoxColumn.DataPropertyName = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.HeaderText = "Sınıf Ad";
            this.sinifAdDataGridViewTextBoxColumn.Name = "sinifAdDataGridViewTextBoxColumn";
            this.sinifAdDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veliIDDataGridViewTextBoxColumn,
            this.veliAdDataGridViewTextBoxColumn,
            this.veliSoyadDataGridViewTextBoxColumn,
            this.VeliEvAdres});
            this.dataGridView2.DataSource = this.tblDershaneVeliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(339, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(205, 227);
            this.dataGridView2.TabIndex = 11;
            // 
            // veliIDDataGridViewTextBoxColumn
            // 
            this.veliIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.veliIDDataGridViewTextBoxColumn.DataPropertyName = "VeliID";
            this.veliIDDataGridViewTextBoxColumn.HeaderText = "Veli ID";
            this.veliIDDataGridViewTextBoxColumn.Name = "veliIDDataGridViewTextBoxColumn";
            this.veliIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliIDDataGridViewTextBoxColumn.Width = 63;
            // 
            // veliAdDataGridViewTextBoxColumn
            // 
            this.veliAdDataGridViewTextBoxColumn.DataPropertyName = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.HeaderText = "Veli Ad";
            this.veliAdDataGridViewTextBoxColumn.Name = "veliAdDataGridViewTextBoxColumn";
            // 
            // veliSoyadDataGridViewTextBoxColumn
            // 
            this.veliSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeliSoyad";
            this.veliSoyadDataGridViewTextBoxColumn.HeaderText = "Veli Soyad";
            this.veliSoyadDataGridViewTextBoxColumn.Name = "veliSoyadDataGridViewTextBoxColumn";
            // 
            // VeliEvAdres
            // 
            this.VeliEvAdres.DataPropertyName = "VeliEvAdres";
            this.VeliEvAdres.HeaderText = "Veli Ev Adres";
            this.VeliEvAdres.Name = "VeliEvAdres";
            // 
            // tblDershaneVeliBindingSource
            // 
            this.tblDershaneVeliBindingSource.DataMember = "Tbl_Dershane_Veli";
            this.tblDershaneVeliBindingSource.DataSource = this.dershaneDataSet39;
            // 
            // dershaneDataSet39
            // 
            this.dershaneDataSet39.DataSetName = "DershaneDataSet39";
            this.dershaneDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxVeli
            // 
            this.comboBoxVeli.DataSource = this.tblDershaneVeliBindingSource;
            this.comboBoxVeli.DisplayMember = "VeliAd";
            this.comboBoxVeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeli.FormattingEnabled = true;
            this.comboBoxVeli.Location = new System.Drawing.Point(142, 388);
            this.comboBoxVeli.Name = "comboBoxVeli";
            this.comboBoxVeli.Size = new System.Drawing.Size(169, 21);
            this.comboBoxVeli.TabIndex = 6;
            this.comboBoxVeli.ValueMember = "VeliID";
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(142, 179);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.PromptChar = ' ';
            this.maskedTextTC.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTC.TabIndex = 2;
            this.maskedTextTC.ValidatingType = typeof(int);
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(142, 265);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.PromptChar = ' ';
            this.maskedTextTel.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTel.TabIndex = 4;
            // 
            // tbl_Dershane_VeliTableAdapter
            // 
            this.tbl_Dershane_VeliTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(571, 598);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.comboBoxVeli);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSinif);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet39)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private DershaneDataSet15 dershaneDataSet15;
        private System.Windows.Forms.BindingSource tblDershaneSinifBindingSource;
        private DershaneDataSet15TableAdapters.Tbl_Dershane_SinifTableAdapter tbl_Dershane_SinifTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxVeli;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdDataGridViewTextBoxColumn;
        private DershaneDataSet39 dershaneDataSet39;
        private System.Windows.Forms.BindingSource tblDershaneVeliBindingSource;
        private DershaneDataSet39TableAdapters.Tbl_Dershane_VeliTableAdapter tbl_Dershane_VeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeliEvAdres;
    }
}