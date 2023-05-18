
namespace Proje_Dershane
{
    partial class Odeme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucretIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeDurumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucretOdemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneUcretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet36 = new Proje_Dershane.DershaneDataSet36();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOgrenci = new System.Windows.Forms.ComboBox();
            this.tblDershaneOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet37 = new Proje_Dershane.DershaneDataSet37();
            this.comboBoxUcret = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbl_Dershane_UcretTableAdapter = new Proje_Dershane.DershaneDataSet36TableAdapters.Tbl_Dershane_UcretTableAdapter();
            this.tbl_Dershane_OgrenciTableAdapter = new Proje_Dershane.DershaneDataSet37TableAdapters.Tbl_Dershane_OgrenciTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sinifIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneSinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet38 = new Proje_Dershane.DershaneDataSet38();
            this.tbl_Dershane_SinifTableAdapter = new Proje_Dershane.DershaneDataSet38TableAdapters.Tbl_Dershane_SinifTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneUcretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet38)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucretIDDataGridViewTextBoxColumn,
            this.ucretMiktarDataGridViewTextBoxColumn,
            this.odemeDurumuDataGridViewCheckBoxColumn,
            this.ucretOdemeTarihiDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneUcretBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ucretIDDataGridViewTextBoxColumn
            // 
            this.ucretIDDataGridViewTextBoxColumn.DataPropertyName = "UcretID";
            this.ucretIDDataGridViewTextBoxColumn.HeaderText = "Ücret ID";
            this.ucretIDDataGridViewTextBoxColumn.Name = "ucretIDDataGridViewTextBoxColumn";
            this.ucretIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ucretIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // ucretMiktarDataGridViewTextBoxColumn
            // 
            this.ucretMiktarDataGridViewTextBoxColumn.DataPropertyName = "UcretMiktar";
            this.ucretMiktarDataGridViewTextBoxColumn.HeaderText = "Ücret Miktar";
            this.ucretMiktarDataGridViewTextBoxColumn.Name = "ucretMiktarDataGridViewTextBoxColumn";
            // 
            // odemeDurumuDataGridViewCheckBoxColumn
            // 
            this.odemeDurumuDataGridViewCheckBoxColumn.DataPropertyName = "OdemeDurumu";
            this.odemeDurumuDataGridViewCheckBoxColumn.HeaderText = "Ödeme Durumu";
            this.odemeDurumuDataGridViewCheckBoxColumn.Name = "odemeDurumuDataGridViewCheckBoxColumn";
            // 
            // ucretOdemeTarihiDataGridViewTextBoxColumn
            // 
            this.ucretOdemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "UcretOdemeTarihi";
            this.ucretOdemeTarihiDataGridViewTextBoxColumn.HeaderText = "Ücret Ödeme Tarihi";
            this.ucretOdemeTarihiDataGridViewTextBoxColumn.Name = "ucretOdemeTarihiDataGridViewTextBoxColumn";
            this.ucretOdemeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "Öğrenci ID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            // 
            // tblDershaneUcretBindingSource
            // 
            this.tblDershaneUcretBindingSource.DataMember = "Tbl_Dershane_Ucret";
            this.tblDershaneUcretBindingSource.DataSource = this.dershaneDataSet36;
            // 
            // dershaneDataSet36
            // 
            this.dershaneDataSet36.DataSetName = "DershaneDataSet36";
            this.dershaneDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(199, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ücret Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(144, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ödendi";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(245, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ödenmedi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödeme Durumu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Öğrenci Adı :";
            // 
            // comboBoxOgrenci
            // 
            this.comboBoxOgrenci.DataSource = this.tblDershaneOgrenciBindingSource;
            this.comboBoxOgrenci.DisplayMember = "OgrenciAd";
            this.comboBoxOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOgrenci.FormattingEnabled = true;
            this.comboBoxOgrenci.Location = new System.Drawing.Point(144, 132);
            this.comboBoxOgrenci.Name = "comboBoxOgrenci";
            this.comboBoxOgrenci.Size = new System.Drawing.Size(174, 21);
            this.comboBoxOgrenci.TabIndex = 8;
            this.comboBoxOgrenci.ValueMember = "OgrenciID";
            // 
            // tblDershaneOgrenciBindingSource
            // 
            this.tblDershaneOgrenciBindingSource.DataMember = "Tbl_Dershane_Ogrenci";
            this.tblDershaneOgrenciBindingSource.DataSource = this.dershaneDataSet37;
            // 
            // dershaneDataSet37
            // 
            this.dershaneDataSet37.DataSetName = "DershaneDataSet37";
            this.dershaneDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxUcret
            // 
            this.comboBoxUcret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUcret.FormattingEnabled = true;
            this.comboBoxUcret.Items.AddRange(new object[] {
            "10.000,00 ₺ ( 9. Sınıf )",
            "12.000,00 ₺ ( 10. Sınıf )",
            "14.000,00 ₺ ( 11. Sınıf )",
            "15.000,00 ₺ ( 12. Sınıf )",
            "10.000,00 ₺ ( Mezun )"});
            this.comboBoxUcret.Location = new System.Drawing.Point(144, 175);
            this.comboBoxUcret.Name = "comboBoxUcret";
            this.comboBoxUcret.Size = new System.Drawing.Size(174, 21);
            this.comboBoxUcret.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ödeme Tarihi :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDershaneOgrenciBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(366, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(230, 208);
            this.dataGridView2.TabIndex = 12;
            // 
            // sinifIDDataGridViewTextBoxColumn
            // 
            this.sinifIDDataGridViewTextBoxColumn.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn.Name = "sinifIDDataGridViewTextBoxColumn";
            this.sinifIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "Öğrenci Ad";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "Öğrenci Soyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(33, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 45);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(366, 301);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(104, 45);
            this.btnYenile.TabIndex = 16;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(479, 301);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(117, 45);
            this.btnAnaSayfa.TabIndex = 17;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(255, 301);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 45);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(144, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 45);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbl_Dershane_UcretTableAdapter
            // 
            this.tbl_Dershane_UcretTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Dershane_OgrenciTableAdapter
            // 
            this.tbl_Dershane_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 20);
            this.txtID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ücret ID :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifIDDataGridViewTextBoxColumn1,
            this.sinifAdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblDershaneSinifBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(366, 85);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(230, 207);
            this.dataGridView3.TabIndex = 21;
            // 
            // sinifIDDataGridViewTextBoxColumn1
            // 
            this.sinifIDDataGridViewTextBoxColumn1.DataPropertyName = "SinifID";
            this.sinifIDDataGridViewTextBoxColumn1.HeaderText = "Sınıf ID";
            this.sinifIDDataGridViewTextBoxColumn1.Name = "sinifIDDataGridViewTextBoxColumn1";
            this.sinifIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sinifIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // sinifAdDataGridViewTextBoxColumn
            // 
            this.sinifAdDataGridViewTextBoxColumn.DataPropertyName = "SinifAd";
            this.sinifAdDataGridViewTextBoxColumn.HeaderText = "Sınıf Ad";
            this.sinifAdDataGridViewTextBoxColumn.Name = "sinifAdDataGridViewTextBoxColumn";
            // 
            // tblDershaneSinifBindingSource
            // 
            this.tblDershaneSinifBindingSource.DataMember = "Tbl_Dershane_Sinif";
            this.tblDershaneSinifBindingSource.DataSource = this.dershaneDataSet38;
            // 
            // dershaneDataSet38
            // 
            this.dershaneDataSet38.DataSetName = "DershaneDataSet38";
            this.dershaneDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Dershane_SinifTableAdapter
            // 
            this.tbl_Dershane_SinifTableAdapter.ClearBeforeFill = true;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 599);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxUcret);
            this.Controls.Add(this.comboBoxOgrenci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneUcretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneSinifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet38)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOgrenci;
        private System.Windows.Forms.ComboBox comboBoxUcret;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private DershaneDataSet36 dershaneDataSet36;
        private System.Windows.Forms.BindingSource tblDershaneUcretBindingSource;
        private DershaneDataSet36TableAdapters.Tbl_Dershane_UcretTableAdapter tbl_Dershane_UcretTableAdapter;
        private DershaneDataSet37 dershaneDataSet37;
        private System.Windows.Forms.BindingSource tblDershaneOgrenciBindingSource;
        private DershaneDataSet37TableAdapters.Tbl_Dershane_OgrenciTableAdapter tbl_Dershane_OgrenciTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DershaneDataSet38 dershaneDataSet38;
        private System.Windows.Forms.BindingSource tblDershaneSinifBindingSource;
        private DershaneDataSet38TableAdapters.Tbl_Dershane_SinifTableAdapter tbl_Dershane_SinifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odemeDurumuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretOdemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
    }
}