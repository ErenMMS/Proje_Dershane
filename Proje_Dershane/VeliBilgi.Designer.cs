
namespace Proje_Dershane
{
    partial class VeliBilgi
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
            this.txtGelir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEgitim = new System.Windows.Forms.ComboBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliEvAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliIsAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliEgitimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliGelirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneVeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet32 = new Proje_Dershane.DershaneDataSet32();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.tbl_Dershane_VeliTableAdapter = new Proje_Dershane.DershaneDataSet32TableAdapters.Tbl_Dershane_VeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet32)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGelir
            // 
            this.txtGelir.Location = new System.Drawing.Point(442, 147);
            this.txtGelir.Name = "txtGelir";
            this.txtGelir.Size = new System.Drawing.Size(169, 20);
            this.txtGelir.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(337, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Gelir Düzeyi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(337, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Eğitim Durumu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Ad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "ID :";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(294, 408);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(142, 45);
            this.btnYenile.TabIndex = 12;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 0;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(442, 408);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(169, 45);
            this.btnAnaSayfa.TabIndex = 13;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(153, 408);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 45);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(21, 408);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 45);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(201, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 42);
            this.label7.TabIndex = 59;
            this.label7.Text = "Veli Bilgi Sistemi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(442, 203);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(169, 75);
            this.txtAdres1.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(153, 204);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(153, 147);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(337, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ev adresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cep Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Soyad :";
            // 
            // comboBoxEgitim
            // 
            this.comboBoxEgitim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEgitim.FormattingEnabled = true;
            this.comboBoxEgitim.Items.AddRange(new object[] {
            "Yok",
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Üniversite"});
            this.comboBoxEgitim.Location = new System.Drawing.Point(442, 90);
            this.comboBoxEgitim.Name = "comboBoxEgitim";
            this.comboBoxEgitim.Size = new System.Drawing.Size(169, 21);
            this.comboBoxEgitim.TabIndex = 6;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(442, 307);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(169, 75);
            this.txtAdres2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(343, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 71;
            this.label11.Text = "İş adresi :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veliIDDataGridViewTextBoxColumn,
            this.veliAdDataGridViewTextBoxColumn,
            this.veliSoyadDataGridViewTextBoxColumn,
            this.veliTCDataGridViewTextBoxColumn,
            this.veliDogumTarihiDataGridViewTextBoxColumn,
            this.veliTelDataGridViewTextBoxColumn,
            this.veliEvAdresDataGridViewTextBoxColumn,
            this.veliIsAdresDataGridViewTextBoxColumn,
            this.veliEgitimDataGridViewTextBoxColumn,
            this.veliGelirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneVeliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 472);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 251);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // veliIDDataGridViewTextBoxColumn
            // 
            this.veliIDDataGridViewTextBoxColumn.DataPropertyName = "VeliID";
            this.veliIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.veliIDDataGridViewTextBoxColumn.Name = "veliIDDataGridViewTextBoxColumn";
            this.veliIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // veliAdDataGridViewTextBoxColumn
            // 
            this.veliAdDataGridViewTextBoxColumn.DataPropertyName = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.veliAdDataGridViewTextBoxColumn.Name = "veliAdDataGridViewTextBoxColumn";
            // 
            // veliSoyadDataGridViewTextBoxColumn
            // 
            this.veliSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeliSoyad";
            this.veliSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.veliSoyadDataGridViewTextBoxColumn.Name = "veliSoyadDataGridViewTextBoxColumn";
            // 
            // veliTCDataGridViewTextBoxColumn
            // 
            this.veliTCDataGridViewTextBoxColumn.DataPropertyName = "VeliTC";
            this.veliTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.veliTCDataGridViewTextBoxColumn.Name = "veliTCDataGridViewTextBoxColumn";
            // 
            // veliDogumTarihiDataGridViewTextBoxColumn
            // 
            this.veliDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "VeliDogumTarihi";
            this.veliDogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.veliDogumTarihiDataGridViewTextBoxColumn.Name = "veliDogumTarihiDataGridViewTextBoxColumn";
            // 
            // veliTelDataGridViewTextBoxColumn
            // 
            this.veliTelDataGridViewTextBoxColumn.DataPropertyName = "VeliTel";
            this.veliTelDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.veliTelDataGridViewTextBoxColumn.Name = "veliTelDataGridViewTextBoxColumn";
            // 
            // veliEvAdresDataGridViewTextBoxColumn
            // 
            this.veliEvAdresDataGridViewTextBoxColumn.DataPropertyName = "VeliEvAdres";
            this.veliEvAdresDataGridViewTextBoxColumn.HeaderText = "Ev Adresi";
            this.veliEvAdresDataGridViewTextBoxColumn.Name = "veliEvAdresDataGridViewTextBoxColumn";
            // 
            // veliIsAdresDataGridViewTextBoxColumn
            // 
            this.veliIsAdresDataGridViewTextBoxColumn.DataPropertyName = "VeliIsAdres";
            this.veliIsAdresDataGridViewTextBoxColumn.HeaderText = "İş Adresi";
            this.veliIsAdresDataGridViewTextBoxColumn.Name = "veliIsAdresDataGridViewTextBoxColumn";
            // 
            // veliEgitimDataGridViewTextBoxColumn
            // 
            this.veliEgitimDataGridViewTextBoxColumn.DataPropertyName = "VeliEgitim";
            this.veliEgitimDataGridViewTextBoxColumn.HeaderText = "Eğitim Durumu";
            this.veliEgitimDataGridViewTextBoxColumn.Name = "veliEgitimDataGridViewTextBoxColumn";
            // 
            // veliGelirDataGridViewTextBoxColumn
            // 
            this.veliGelirDataGridViewTextBoxColumn.DataPropertyName = "VeliGelir";
            this.veliGelirDataGridViewTextBoxColumn.HeaderText = "Gelir Düzeyi";
            this.veliGelirDataGridViewTextBoxColumn.Name = "veliGelirDataGridViewTextBoxColumn";
            // 
            // tblDershaneVeliBindingSource
            // 
            this.tblDershaneVeliBindingSource.DataMember = "Tbl_Dershane_Veli";
            this.tblDershaneVeliBindingSource.DataSource = this.dershaneDataSet32;
            // 
            // dershaneDataSet32
            // 
            this.dershaneDataSet32.DataSetName = "DershaneDataSet32";
            this.dershaneDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(153, 259);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.PromptChar = ' ';
            this.maskedTextTC.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTC.TabIndex = 3;
            this.maskedTextTC.ValidatingType = typeof(int);
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(153, 363);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.PromptChar = ' ';
            this.maskedTextTel.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTel.TabIndex = 5;
            // 
            // tbl_Dershane_VeliTableAdapter
            // 
            this.tbl_Dershane_VeliTableAdapter.ClearBeforeFill = true;
            // 
            // VeliBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(631, 740);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAdres2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxEgitim);
            this.Controls.Add(this.txtGelir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAdres1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VeliBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veli Bilgi Sistemi";
            this.Load += new System.EventHandler(this.VeliBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGelir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEgitim;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private DershaneDataSet32 dershaneDataSet32;
        private System.Windows.Forms.BindingSource tblDershaneVeliBindingSource;
        private DershaneDataSet32TableAdapters.Tbl_Dershane_VeliTableAdapter tbl_Dershane_VeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliEvAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliIsAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliEgitimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliGelirDataGridViewTextBoxColumn;
    }
}