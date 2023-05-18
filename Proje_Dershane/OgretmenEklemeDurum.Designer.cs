
namespace Proje_Dershane
{
    partial class OgretmenEklemeDurum
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogretmenEkleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgretmenEklemeDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet45 = new Proje_Dershane.DershaneDataSet45();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ogretmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet46 = new Proje_Dershane.DershaneDataSet46();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.tbl_Dershane_OgretmenEklemeDurumTableAdapter = new Proje_Dershane.DershaneDataSet45TableAdapters.Tbl_Dershane_OgretmenEklemeDurumTableAdapter();
            this.tbl_Dershane_OgretmenTableAdapter = new Proje_Dershane.DershaneDataSet46TableAdapters.Tbl_Dershane_OgretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenEklemeDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet46)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğretmen Eklenme Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenEkleIDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneOgretmenEklemeDurumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 176);
            this.dataGridView1.TabIndex = 2;
            // 
            // ogretmenEkleIDDataGridViewTextBoxColumn
            // 
            this.ogretmenEkleIDDataGridViewTextBoxColumn.DataPropertyName = "OgretmenEkleID";
            this.ogretmenEkleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ogretmenEkleIDDataGridViewTextBoxColumn.Name = "ogretmenEkleIDDataGridViewTextBoxColumn";
            this.ogretmenEkleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogretmenEkleIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 190;
            // 
            // tblDershaneOgretmenEklemeDurumBindingSource
            // 
            this.tblDershaneOgretmenEklemeDurumBindingSource.DataMember = "Tbl_Dershane_OgretmenEklemeDurum";
            this.tblDershaneOgretmenEklemeDurumBindingSource.DataSource = this.dershaneDataSet45;
            // 
            // dershaneDataSet45
            // 
            this.dershaneDataSet45.DataSetName = "DershaneDataSet45";
            this.dershaneDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenIDDataGridViewTextBoxColumn,
            this.ogretmenAdDataGridViewTextBoxColumn,
            this.ogretmenSoyadDataGridViewTextBoxColumn,
            this.ogretmenTCDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDershaneOgretmenBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 176);
            this.dataGridView2.TabIndex = 3;
            // 
            // ogretmenIDDataGridViewTextBoxColumn
            // 
            this.ogretmenIDDataGridViewTextBoxColumn.DataPropertyName = "OgretmenID";
            this.ogretmenIDDataGridViewTextBoxColumn.HeaderText = "Öğretmen ID";
            this.ogretmenIDDataGridViewTextBoxColumn.Name = "ogretmenIDDataGridViewTextBoxColumn";
            this.ogretmenIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogretmenIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // ogretmenAdDataGridViewTextBoxColumn
            // 
            this.ogretmenAdDataGridViewTextBoxColumn.DataPropertyName = "OgretmenAd";
            this.ogretmenAdDataGridViewTextBoxColumn.HeaderText = "Öğretmen Ad";
            this.ogretmenAdDataGridViewTextBoxColumn.Name = "ogretmenAdDataGridViewTextBoxColumn";
            this.ogretmenAdDataGridViewTextBoxColumn.Width = 94;
            // 
            // ogretmenSoyadDataGridViewTextBoxColumn
            // 
            this.ogretmenSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgretmenSoyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.HeaderText = "Öğretmen Soyad";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Name = "ogretmenSoyadDataGridViewTextBoxColumn";
            this.ogretmenSoyadDataGridViewTextBoxColumn.Width = 110;
            // 
            // ogretmenTCDataGridViewTextBoxColumn
            // 
            this.ogretmenTCDataGridViewTextBoxColumn.DataPropertyName = "OgretmenTC";
            this.ogretmenTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogretmenTCDataGridViewTextBoxColumn.Name = "ogretmenTCDataGridViewTextBoxColumn";
            this.ogretmenTCDataGridViewTextBoxColumn.Width = 46;
            // 
            // tblDershaneOgretmenBindingSource
            // 
            this.tblDershaneOgretmenBindingSource.DataMember = "Tbl_Dershane_Ogretmen";
            this.tblDershaneOgretmenBindingSource.DataSource = this.dershaneDataSet46;
            // 
            // dershaneDataSet46
            // 
            this.dershaneDataSet46.DataSetName = "DershaneDataSet46";
            this.dershaneDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(23, 450);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(284, 46);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // tbl_Dershane_OgretmenEklemeDurumTableAdapter
            // 
            this.tbl_Dershane_OgretmenEklemeDurumTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Dershane_OgretmenTableAdapter
            // 
            this.tbl_Dershane_OgretmenTableAdapter.ClearBeforeFill = true;
            // 
            // OgretmenEklemeDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(327, 513);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgretmenEklemeDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Ekleme Durum";
            this.Load += new System.EventHandler(this.OgretmenEklemeDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenEklemeDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet46)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAnaSayfa;
        private DershaneDataSet45 dershaneDataSet45;
        private System.Windows.Forms.BindingSource tblDershaneOgretmenEklemeDurumBindingSource;
        private DershaneDataSet45TableAdapters.Tbl_Dershane_OgretmenEklemeDurumTableAdapter tbl_Dershane_OgretmenEklemeDurumTableAdapter;
        private DershaneDataSet46 dershaneDataSet46;
        private System.Windows.Forms.BindingSource tblDershaneOgretmenBindingSource;
        private DershaneDataSet46TableAdapters.Tbl_Dershane_OgretmenTableAdapter tbl_Dershane_OgretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenEkleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenTCDataGridViewTextBoxColumn;
    }
}