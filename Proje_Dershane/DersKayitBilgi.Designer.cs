
namespace Proje_Dershane
{
    partial class DersKayitBilgi
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
            this.comboBoxAd = new System.Windows.Forms.ComboBox();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.tblDershaneOgretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet34 = new Proje_Dershane.DershaneDataSet34();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.tblDershaneSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet28 = new Proje_Dershane.DershaneDataSet28();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ogretmenBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet30 = new Proje_Dershane.DershaneDataSet30();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbl_Dershane_SinifTableAdapter = new Proje_Dershane.DershaneDataSet28TableAdapters.Tbl_Dershane_SinifTableAdapter();
            this.comboBoxGun = new System.Windows.Forms.ComboBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.tbl_Dershane_DersTableAdapter = new Proje_Dershane.DershaneDataSet30TableAdapters.Tbl_Dershane_DersTableAdapter();
            this.tbl_Dershane_OgretmenTableAdapter = new Proje_Dershane.DershaneDataSet34TableAdapters.Tbl_Dershane_OgretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet30)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAd
            // 
            this.comboBoxAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAd.FormattingEnabled = true;
            this.comboBoxAd.Items.AddRange(new object[] {
            "Türkçe",
            "Tarih",
            "Coğrafya",
            "Felsefe",
            "Matematik",
            "Fizik",
            "Kimya",
            "Biyoloji",
            "İngilizce",
            "Almanca"});
            this.comboBoxAd.Location = new System.Drawing.Point(136, 149);
            this.comboBoxAd.Name = "comboBoxAd";
            this.comboBoxAd.Size = new System.Drawing.Size(202, 21);
            this.comboBoxAd.TabIndex = 1;
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.DataSource = this.tblDershaneOgretmenBindingSource;
            this.comboBoxOgretmen.DisplayMember = "OgretmenAd";
            this.comboBoxOgretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(507, 195);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(202, 21);
            this.comboBoxOgretmen.TabIndex = 5;
            this.comboBoxOgretmen.ValueMember = "OgretmenID";
            // 
            // tblDershaneOgretmenBindingSource
            // 
            this.tblDershaneOgretmenBindingSource.DataMember = "Tbl_Dershane_Ogretmen";
            this.tblDershaneOgretmenBindingSource.DataSource = this.dershaneDataSet34;
            // 
            // dershaneDataSet34
            // 
            this.dershaneDataSet34.DataSetName = "DershaneDataSet34";
            this.dershaneDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.DataSource = this.tblDershaneSinifBindingSource;
            this.comboBoxSinif.DisplayMember = "SinifAd";
            this.comboBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(507, 149);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSinif.TabIndex = 4;
            this.comboBoxSinif.ValueMember = "SinifID";
            // 
            // tblDershaneSinifBindingSource
            // 
            this.tblDershaneSinifBindingSource.DataMember = "Tbl_Dershane_Sinif";
            this.tblDershaneSinifBindingSource.DataSource = this.dershaneDataSet28;
            // 
            // dershaneDataSet28
            // 
            this.dershaneDataSet28.DataSetName = "DershaneDataSet28";
            this.dershaneDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn1,
            this.sinifAdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblDershaneSinifBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(495, 332);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(214, 149);
            this.dataGridView3.TabIndex = 12;
            // 
            // sinifIDDataGridViewTextBoxColumn1
            // 
            this.sinifIDDataGridViewTextBoxColumn1.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn1.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn1.Name = "sinifIDDataGridViewTextBoxColumn1";
            this.sinifIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sinifIDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sinifAdDataGridViewTextBoxColumn
            // 
            this.sinifAdDataGridViewTextBoxColumn.DataPropertyName = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.HeaderText = "Sınıf Ad";
            this.sinifAdDataGridViewTextBoxColumn.Name = "sinifAdDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenBransDataGridViewTextBoxColumn,
            this.ogretmenAdDataGridViewTextBoxColumn,
            this.ogretmenSoyadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDershaneOgretmenBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(495, 491);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(214, 149);
            this.dataGridView2.TabIndex = 13;
            // 
            // ogretmenBransDataGridViewTextBoxColumn
            // 
            this.ogretmenBransDataGridViewTextBoxColumn.DataPropertyName = "OgretmenBrans";
            this.ogretmenBransDataGridViewTextBoxColumn.HeaderText = "Branş";
            this.ogretmenBransDataGridViewTextBoxColumn.Name = "ogretmenBransDataGridViewTextBoxColumn";
            this.ogretmenBransDataGridViewTextBoxColumn.Width = 59;
            // 
            // ogretmenAdDataGridViewTextBoxColumn
            // 
            this.ogretmenAdDataGridViewTextBoxColumn.DataPropertyName = "OgretmenAd";
            this.ogretmenAdDataGridViewTextBoxColumn.HeaderText = "Öğretmen Ad";
            this.ogretmenAdDataGridViewTextBoxColumn.Name = "ogretmenAdDataGridViewTextBoxColumn";
            // 
            // ogretmenSoyadDataGridViewTextBoxColumn
            // 
            this.ogretmenSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgretmenSoyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.HeaderText = "Öğretmen Soyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Name = "ogretmenSoyadDataGridViewTextBoxColumn";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Ders Adı :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 20);
            this.txtID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Ders ID : ";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(381, 257);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(105, 45);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(495, 257);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(214, 45);
            this.btnAnaSayfa.TabIndex = 10;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(270, 257);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 45);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(159, 257);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 45);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(162, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 42);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ders Kayıt/Güncelleme Sistemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdDataGridViewTextBoxColumn,
            this.dersGunDataGridViewTextBoxColumn,
            this.dersSaatDataGridViewTextBoxColumn,
            this.sinifIDDataGridViewTextBoxColumn,
            this.ogretmenIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 308);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "Ders ID";
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dersIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dersAdDataGridViewTextBoxColumn
            // 
            this.dersAdDataGridViewTextBoxColumn.DataPropertyName = "DersAd";
            this.dersAdDataGridViewTextBoxColumn.HeaderText = "Ders Adı";
            this.dersAdDataGridViewTextBoxColumn.Name = "dersAdDataGridViewTextBoxColumn";
            // 
            // dersGunDataGridViewTextBoxColumn
            // 
            this.dersGunDataGridViewTextBoxColumn.DataPropertyName = "DersGun";
            this.dersGunDataGridViewTextBoxColumn.HeaderText = "Ders Günü";
            this.dersGunDataGridViewTextBoxColumn.Name = "dersGunDataGridViewTextBoxColumn";
            // 
            // dersSaatDataGridViewTextBoxColumn
            // 
            this.dersSaatDataGridViewTextBoxColumn.DataPropertyName = "DersSaat";
            this.dersSaatDataGridViewTextBoxColumn.HeaderText = "Ders Saati";
            this.dersSaatDataGridViewTextBoxColumn.Name = "dersSaatDataGridViewTextBoxColumn";
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            // 
            // ogretmenIDDataGridViewTextBoxColumn
            // 
            this.ogretmenIDDataGridViewTextBoxColumn.DataPropertyName = "OgretmenID";
            this.ogretmenIDDataGridViewTextBoxColumn.HeaderText = "Öğretmen ID";
            this.ogretmenIDDataGridViewTextBoxColumn.Name = "ogretmenIDDataGridViewTextBoxColumn";
            // 
            // tblDershaneDersBindingSource
            // 
            this.tblDershaneDersBindingSource.DataMember = "Tbl_Dershane_Ders";
            this.tblDershaneDersBindingSource.DataSource = this.dershaneDataSet30;
            // 
            // dershaneDataSet30
            // 
            this.dershaneDataSet30.DataSetName = "DershaneDataSet30";
            this.dershaneDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Öğretmen Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sınıf Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Ders Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ders Günü :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(48, 257);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 45);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbl_Dershane_SinifTableAdapter
            // 
            this.tbl_Dershane_SinifTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxGun
            // 
            this.comboBoxGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGun.FormattingEnabled = true;
            this.comboBoxGun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.comboBoxGun.Location = new System.Drawing.Point(136, 195);
            this.comboBoxGun.Name = "comboBoxGun";
            this.comboBoxGun.Size = new System.Drawing.Size(202, 21);
            this.comboBoxGun.TabIndex = 2;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "08:00 - 08:40",
            "09:00 - 09:40",
            "10:00 - 10:40",
            "11:00 - 11:40",
            "13:00 - 13:40",
            "14:00 - 14:40",
            "15:00 - 15:40",
            "16:00 - 16:40"});
            this.comboBoxSaat.Location = new System.Drawing.Point(507, 102);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSaat.TabIndex = 3;
            // 
            // tbl_Dershane_DersTableAdapter
            // 
            this.tbl_Dershane_DersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Dershane_OgretmenTableAdapter
            // 
            this.tbl_Dershane_OgretmenTableAdapter.ClearBeforeFill = true;
            // 
            // DersKayitBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 668);
            this.Controls.Add(this.comboBoxSaat);
            this.Controls.Add(this.comboBoxGun);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxAd);
            this.Controls.Add(this.comboBoxOgretmen);
            this.Controls.Add(this.comboBoxSinif);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DersKayitBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Bilgi Sistemi";
            this.Load += new System.EventHandler(this.DersKayitBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet30)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAd;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private DershaneDataSet28 dershaneDataSet28;
        private System.Windows.Forms.BindingSource tblDershaneSinifBindingSource;
        private DershaneDataSet28TableAdapters.Tbl_Dershane_SinifTableAdapter tbl_Dershane_SinifTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxGun;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private DershaneDataSet30 dershaneDataSet30;
        private System.Windows.Forms.BindingSource tblDershaneDersBindingSource;
        private DershaneDataSet30TableAdapters.Tbl_Dershane_DersTableAdapter tbl_Dershane_DersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdDataGridViewTextBoxColumn;
        private DershaneDataSet34 dershaneDataSet34;
        private System.Windows.Forms.BindingSource tblDershaneOgretmenBindingSource;
        private DershaneDataSet34TableAdapters.Tbl_Dershane_OgretmenTableAdapter tbl_Dershane_OgretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenIDDataGridViewTextBoxColumn;
    }
}