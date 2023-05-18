
namespace Proje_Dershane
{
    partial class OgrenciEklemeDurum
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
            this.ogrenciEkleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgrenciEklemeDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet43 = new Proje_Dershane.DershaneDataSet43();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet44 = new Proje_Dershane.DershaneDataSet44();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.tbl_Dershane_OgrenciEklemeDurumTableAdapter = new Proje_Dershane.DershaneDataSet43TableAdapters.Tbl_Dershane_OgrenciEklemeDurumTableAdapter();
            this.tbl_Dershane_OgrenciTableAdapter = new Proje_Dershane.DershaneDataSet44TableAdapters.Tbl_Dershane_OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciEklemeDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet44)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciEkleIDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneOgrenciEklemeDurumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrenciEkleIDDataGridViewTextBoxColumn
            // 
            this.ogrenciEkleIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciEkleID";
            this.ogrenciEkleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ogrenciEkleIDDataGridViewTextBoxColumn.Name = "ogrenciEkleIDDataGridViewTextBoxColumn";
            this.ogrenciEkleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciEkleIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 190;
            // 
            // tblDershaneOgrenciEklemeDurumBindingSource
            // 
            this.tblDershaneOgrenciEklemeDurumBindingSource.DataMember = "Tbl_Dershane_OgrenciEklemeDurum";
            this.tblDershaneOgrenciEklemeDurumBindingSource.DataSource = this.dershaneDataSet43;
            // 
            // dershaneDataSet43
            // 
            this.dershaneDataSet43.DataSetName = "DershaneDataSet43";
            this.dershaneDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciTCDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDershaneOgrenciBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 258);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 176);
            this.dataGridView2.TabIndex = 1;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "Öğrenci ID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 83;
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
            // ogrenciTCDataGridViewTextBoxColumn
            // 
            this.ogrenciTCDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogrenciTCDataGridViewTextBoxColumn.Name = "ogrenciTCDataGridViewTextBoxColumn";
            // 
            // tblDershaneOgrenciBindingSource
            // 
            this.tblDershaneOgrenciBindingSource.DataMember = "Tbl_Dershane_Ogrenci";
            this.tblDershaneOgrenciBindingSource.DataSource = this.dershaneDataSet44;
            // 
            // dershaneDataSet44
            // 
            this.dershaneDataSet44.DataSetName = "DershaneDataSet44";
            this.dershaneDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Eklenme Tarihi";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(22, 450);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(284, 46);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // tbl_Dershane_OgrenciEklemeDurumTableAdapter
            // 
            this.tbl_Dershane_OgrenciEklemeDurumTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Dershane_OgrenciTableAdapter
            // 
            this.tbl_Dershane_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciEklemeDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(327, 513);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciEklemeDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekleme Durum";
            this.Load += new System.EventHandler(this.OgrenciEklemeDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciEklemeDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet44)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnaSayfa;
        private DershaneDataSet43 dershaneDataSet43;
        private System.Windows.Forms.BindingSource tblDershaneOgrenciEklemeDurumBindingSource;
        private DershaneDataSet43TableAdapters.Tbl_Dershane_OgrenciEklemeDurumTableAdapter tbl_Dershane_OgrenciEklemeDurumTableAdapter;
        private DershaneDataSet44 dershaneDataSet44;
        private System.Windows.Forms.BindingSource tblDershaneOgrenciBindingSource;
        private DershaneDataSet44TableAdapters.Tbl_Dershane_OgrenciTableAdapter tbl_Dershane_OgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciEkleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTCDataGridViewTextBoxColumn;
    }
}