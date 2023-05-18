
namespace Proje_Dershane
{
    partial class OgretmenBilgi
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTecrube = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogretmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenTecrubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet33 = new Proje_Dershane.DershaneDataSet33();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.tbl_Dershane_OgretmenTableAdapter = new Proje_Dershane.DershaneDataSet33TableAdapters.Tbl_Dershane_OgretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet33)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "ID :";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Chartreuse;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(285, 414);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(126, 45);
            this.btnYenile.TabIndex = 12;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 0;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(416, 414);
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
            this.btnGuncelle.Location = new System.Drawing.Point(22, 414);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 45);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(154, 414);
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
            this.label7.Location = new System.Drawing.Point(147, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 42);
            this.label7.TabIndex = 34;
            this.label7.Text = "Öğretmen Bilgi Sistemi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(416, 265);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 124);
            this.txtAdres.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(140, 212);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 155);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(338, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ev adresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cep Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(338, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Branş :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(338, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Tecrübe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(338, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Maaş :";
            // 
            // txtTecrube
            // 
            this.txtTecrube.Location = new System.Drawing.Point(416, 153);
            this.txtTecrube.Name = "txtTecrube";
            this.txtTecrube.Size = new System.Drawing.Size(169, 20);
            this.txtTecrube.TabIndex = 7;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(416, 210);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(169, 20);
            this.txtMaas.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenIDDataGridViewTextBoxColumn,
            this.ogretmenAdDataGridViewTextBoxColumn,
            this.ogretmenSoyadDataGridViewTextBoxColumn,
            this.ogretmenTCDataGridViewTextBoxColumn,
            this.ogretmenDogumTarihiDataGridViewTextBoxColumn,
            this.ogretmenTelDataGridViewTextBoxColumn,
            this.ogretmenAdresDataGridViewTextBoxColumn,
            this.ogretmenBransDataGridViewTextBoxColumn,
            this.ogretmenTecrubeDataGridViewTextBoxColumn,
            this.ogretmenMaasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneOgretmenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 251);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogretmenIDDataGridViewTextBoxColumn
            // 
            this.ogretmenIDDataGridViewTextBoxColumn.DataPropertyName = "OgretmenID";
            this.ogretmenIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ogretmenIDDataGridViewTextBoxColumn.Name = "ogretmenIDDataGridViewTextBoxColumn";
            this.ogretmenIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogretmenIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // ogretmenAdDataGridViewTextBoxColumn
            // 
            this.ogretmenAdDataGridViewTextBoxColumn.DataPropertyName = "OgretmenAd";
            this.ogretmenAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.ogretmenAdDataGridViewTextBoxColumn.Name = "ogretmenAdDataGridViewTextBoxColumn";
            // 
            // ogretmenSoyadDataGridViewTextBoxColumn
            // 
            this.ogretmenSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgretmenSoyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Name = "ogretmenSoyadDataGridViewTextBoxColumn";
            // 
            // ogretmenTCDataGridViewTextBoxColumn
            // 
            this.ogretmenTCDataGridViewTextBoxColumn.DataPropertyName = "OgretmenTC";
            this.ogretmenTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogretmenTCDataGridViewTextBoxColumn.Name = "ogretmenTCDataGridViewTextBoxColumn";
            // 
            // ogretmenDogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogretmenDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OgretmenDogumTarihi";
            this.ogretmenDogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.ogretmenDogumTarihiDataGridViewTextBoxColumn.Name = "ogretmenDogumTarihiDataGridViewTextBoxColumn";
            // 
            // ogretmenTelDataGridViewTextBoxColumn
            // 
            this.ogretmenTelDataGridViewTextBoxColumn.DataPropertyName = "OgretmenTel";
            this.ogretmenTelDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.ogretmenTelDataGridViewTextBoxColumn.Name = "ogretmenTelDataGridViewTextBoxColumn";
            // 
            // ogretmenAdresDataGridViewTextBoxColumn
            // 
            this.ogretmenAdresDataGridViewTextBoxColumn.DataPropertyName = "OgretmenAdres";
            this.ogretmenAdresDataGridViewTextBoxColumn.HeaderText = "Ev Adresi";
            this.ogretmenAdresDataGridViewTextBoxColumn.Name = "ogretmenAdresDataGridViewTextBoxColumn";
            // 
            // ogretmenBransDataGridViewTextBoxColumn
            // 
            this.ogretmenBransDataGridViewTextBoxColumn.DataPropertyName = "OgretmenBrans";
            this.ogretmenBransDataGridViewTextBoxColumn.HeaderText = "Branş";
            this.ogretmenBransDataGridViewTextBoxColumn.Name = "ogretmenBransDataGridViewTextBoxColumn";
            // 
            // ogretmenTecrubeDataGridViewTextBoxColumn
            // 
            this.ogretmenTecrubeDataGridViewTextBoxColumn.DataPropertyName = "OgretmenTecrube";
            this.ogretmenTecrubeDataGridViewTextBoxColumn.HeaderText = "Tecrübe (Yıl)";
            this.ogretmenTecrubeDataGridViewTextBoxColumn.Name = "ogretmenTecrubeDataGridViewTextBoxColumn";
            // 
            // ogretmenMaasDataGridViewTextBoxColumn
            // 
            this.ogretmenMaasDataGridViewTextBoxColumn.DataPropertyName = "OgretmenMaas";
            this.ogretmenMaasDataGridViewTextBoxColumn.HeaderText = "Maaş";
            this.ogretmenMaasDataGridViewTextBoxColumn.Name = "ogretmenMaasDataGridViewTextBoxColumn";
            // 
            // tblDershaneOgretmenBindingSource
            // 
            this.tblDershaneOgretmenBindingSource.DataMember = "Tbl_Dershane_Ogretmen";
            this.tblDershaneOgretmenBindingSource.DataSource = this.dershaneDataSet33;
            // 
            // dershaneDataSet33
            // 
            this.dershaneDataSet33.DataSetName = "DershaneDataSet33";
            this.dershaneDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Items.AddRange(new object[] {
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
            this.comboBoxBrans.Location = new System.Drawing.Point(416, 97);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(169, 21);
            this.comboBoxBrans.TabIndex = 6;
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(140, 267);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.PromptChar = ' ';
            this.maskedTextTC.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTC.TabIndex = 3;
            this.maskedTextTC.ValidatingType = typeof(int);
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(140, 371);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.PromptChar = ' ';
            this.maskedTextTel.Size = new System.Drawing.Size(169, 20);
            this.maskedTextTel.TabIndex = 5;
            // 
            // tbl_Dershane_OgretmenTableAdapter
            // 
            this.tbl_Dershane_OgretmenTableAdapter.ClearBeforeFill = true;
            // 
            // OgretmenBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(614, 751);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.comboBoxBrans);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtTecrube);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgretmenBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Bilgi Sistemi";
            this.Load += new System.EventHandler(this.OgretmenBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet33)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTecrube;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private DershaneDataSet33 dershaneDataSet33;
        private System.Windows.Forms.BindingSource tblDershaneOgretmenBindingSource;
        private DershaneDataSet33TableAdapters.Tbl_Dershane_OgretmenTableAdapter tbl_Dershane_OgretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenTecrubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenMaasDataGridViewTextBoxColumn;
    }
}