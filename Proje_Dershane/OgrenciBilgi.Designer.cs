
namespace Proje_Dershane
{
    partial class OgrenciBilgi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet18 = new Proje_Dershane.DershaneDataSet18();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.veliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneVeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet31 = new Proje_Dershane.DershaneDataSet31();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet13 = new Proje_Dershane.DershaneDataSet13();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxVeli = new System.Windows.Forms.ComboBox();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.tbl_Dershane_SinifTableAdapter = new Proje_Dershane.DershaneDataSet13TableAdapters.Tbl_Dershane_SinifTableAdapter();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.tbl_Dershane_OgrenciTableAdapter1 = new Proje_Dershane.DershaneDataSet18TableAdapters.Tbl_Dershane_OgrenciTableAdapter();
            this.tbl_Dershane_VeliTableAdapter = new Proje_Dershane.DershaneDataSet31TableAdapters.Tbl_Dershane_VeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(372, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cep Telefon No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(372, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ev adresi :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(126, 176);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(192, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(487, 133);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(202, 63);
            this.txtAdres.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciTCDataGridViewTextBoxColumn,
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn,
            this.ogrenciTelDataGridViewTextBoxColumn,
            this.ogrenciAdresDataGridViewTextBoxColumn,
            this.veliIDDataGridViewTextBoxColumn,
            this.sinifIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneOgrenciBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 251);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciTCDataGridViewTextBoxColumn
            // 
            this.ogrenciTCDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogrenciTCDataGridViewTextBoxColumn.Name = "ogrenciTCDataGridViewTextBoxColumn";
            // 
            // ogrenciDogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciDogumTarihi";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.Name = "ogrenciDogumTarihiDataGridViewTextBoxColumn";
            // 
            // ogrenciTelDataGridViewTextBoxColumn
            // 
            this.ogrenciTelDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTel";
            this.ogrenciTelDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.ogrenciTelDataGridViewTextBoxColumn.Name = "ogrenciTelDataGridViewTextBoxColumn";
            // 
            // ogrenciAdresDataGridViewTextBoxColumn
            // 
            this.ogrenciAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAdres";
            this.ogrenciAdresDataGridViewTextBoxColumn.HeaderText = "Ev Adresi";
            this.ogrenciAdresDataGridViewTextBoxColumn.Name = "ogrenciAdresDataGridViewTextBoxColumn";
            // 
            // veliIDDataGridViewTextBoxColumn
            // 
            this.veliIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.veliIDDataGridViewTextBoxColumn.DataPropertyName = "VeliID";
            this.veliIDDataGridViewTextBoxColumn.HeaderText = "Veli ID";
            this.veliIDDataGridViewTextBoxColumn.Name = "veliIDDataGridViewTextBoxColumn";
            this.veliIDDataGridViewTextBoxColumn.Width = 63;
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            this.sinifIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // tblDershaneOgrenciBindingSource1
            // 
            this.tblDershaneOgrenciBindingSource1.DataMember = "Tbl_Dershane_Ogrenci";
            this.tblDershaneOgrenciBindingSource1.DataSource = this.dershaneDataSet18;
            // 
            // dershaneDataSet18
            // 
            this.dershaneDataSet18.DataSetName = "DershaneDataSet18";
            this.dershaneDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(221, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "Öğrenci Bilgi Sistemi";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(28, 314);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 45);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(176, 314);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 45);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(475, 314);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(214, 45);
            this.btnAnaSayfa.TabIndex = 12;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(324, 314);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(145, 45);
            this.btnYenile.TabIndex = 11;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veliAdDataGridViewTextBoxColumn,
            this.veliSoyadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDershaneVeliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(475, 378);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(214, 121);
            this.dataGridView2.TabIndex = 14;
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
            // tblDershaneVeliBindingSource
            // 
            this.tblDershaneVeliBindingSource.DataMember = "Tbl_Dershane_Veli";
            this.tblDershaneVeliBindingSource.DataSource = this.dershaneDataSet31;
            // 
            // dershaneDataSet31
            // 
            this.dershaneDataSet31.DataSetName = "DershaneDataSet31";
            this.dershaneDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn1,
            this.sinifAdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblDershaneSinifBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(475, 505);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(214, 124);
            this.dataGridView3.TabIndex = 15;
            // 
            // sinifIDDataGridViewTextBoxColumn1
            // 
            this.sinifIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sinifIDDataGridViewTextBoxColumn1.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn1.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn1.Name = "sinifIDDataGridViewTextBoxColumn1";
            this.sinifIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sinifIDDataGridViewTextBoxColumn1.Width = 66;
            // 
            // sinifAdDataGridViewTextBoxColumn
            // 
            this.sinifAdDataGridViewTextBoxColumn.DataPropertyName = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.HeaderText = "Sınıf";
            this.sinifAdDataGridViewTextBoxColumn.Name = "sinifAdDataGridViewTextBoxColumn";
            this.sinifAdDataGridViewTextBoxColumn.Width = 90;
            // 
            // tblDershaneSinifBindingSource
            // 
            this.tblDershaneSinifBindingSource.DataMember = "Tbl_Dershane_Sinif";
            this.tblDershaneSinifBindingSource.DataSource = this.dershaneDataSet13;
            // 
            // dershaneDataSet13
            // 
            this.dershaneDataSet13.DataSetName = "DershaneDataSet13";
            this.dershaneDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(372, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Veli Adı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(372, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sınıf Adı :";
            // 
            // comboBoxVeli
            // 
            this.comboBoxVeli.DataSource = this.tblDershaneVeliBindingSource;
            this.comboBoxVeli.DisplayMember = "VeliAd";
            this.comboBoxVeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeli.FormattingEnabled = true;
            this.comboBoxVeli.Location = new System.Drawing.Point(487, 219);
            this.comboBoxVeli.Name = "comboBoxVeli";
            this.comboBoxVeli.Size = new System.Drawing.Size(202, 21);
            this.comboBoxVeli.TabIndex = 7;
            this.comboBoxVeli.ValueMember = "VeliID";
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.DataSource = this.tblDershaneSinifBindingSource;
            this.comboBoxSinif.DisplayMember = "SinifAd";
            this.comboBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(487, 261);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSinif.TabIndex = 8;
            this.comboBoxSinif.ValueMember = "SinifID";
            // 
            // tbl_Dershane_SinifTableAdapter
            // 
            this.tbl_Dershane_SinifTableAdapter.ClearBeforeFill = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 92);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(126, 133);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 20);
            this.txtAd.TabIndex = 1;
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(126, 219);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.PromptChar = ' ';
            this.maskedTextTC.Size = new System.Drawing.Size(192, 20);
            this.maskedTextTC.TabIndex = 3;
            this.maskedTextTC.ValidatingType = typeof(int);
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(487, 92);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.PromptChar = ' ';
            this.maskedTextTel.Size = new System.Drawing.Size(202, 20);
            this.maskedTextTel.TabIndex = 5;
            // 
            // tbl_Dershane_OgrenciTableAdapter1
            // 
            this.tbl_Dershane_OgrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_Dershane_VeliTableAdapter
            // 
            this.tbl_Dershane_VeliTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(719, 654);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.comboBoxSinif);
            this.Controls.Add(this.comboBoxVeli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.OgrenciBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxVeli;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private DershaneDataSet13 dershaneDataSet13;
        private System.Windows.Forms.BindingSource tblDershaneSinifBindingSource;
        private DershaneDataSet13TableAdapters.Tbl_Dershane_SinifTableAdapter tbl_Dershane_SinifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private DershaneDataSet18 dershaneDataSet18;
        private System.Windows.Forms.BindingSource tblDershaneOgrenciBindingSource1;
        private DershaneDataSet18TableAdapters.Tbl_Dershane_OgrenciTableAdapter tbl_Dershane_OgrenciTableAdapter1;
        private DershaneDataSet31 dershaneDataSet31;
        private System.Windows.Forms.BindingSource tblDershaneVeliBindingSource;
        private DershaneDataSet31TableAdapters.Tbl_Dershane_VeliTableAdapter tbl_Dershane_VeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliSoyadDataGridViewTextBoxColumn;
    }
}