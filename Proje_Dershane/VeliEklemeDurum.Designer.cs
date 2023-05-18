
namespace Proje_Dershane
{
    partial class VeliEklemeDurum
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
            this.veliEkleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneVeliEklemeDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet40 = new Proje_Dershane.DershaneDataSet40();
            this.tbl_Dershane_VeliEklemeDurumTableAdapter = new Proje_Dershane.DershaneDataSet40TableAdapters.Tbl_Dershane_VeliEklemeDurumTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.veliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeliTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDershaneVeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet41 = new Proje_Dershane.DershaneDataSet41();
            this.tbl_Dershane_VeliTableAdapter = new Proje_Dershane.DershaneDataSet41TableAdapters.Tbl_Dershane_VeliTableAdapter();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliEklemeDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet41)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veli Eklenme Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veliEkleIDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDershaneVeliEklemeDurumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // veliEkleIDDataGridViewTextBoxColumn
            // 
            this.veliEkleIDDataGridViewTextBoxColumn.DataPropertyName = "VeliEkleID";
            this.veliEkleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.veliEkleIDDataGridViewTextBoxColumn.Name = "veliEkleIDDataGridViewTextBoxColumn";
            this.veliEkleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliEkleIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 190;
            // 
            // tblDershaneVeliEklemeDurumBindingSource
            // 
            this.tblDershaneVeliEklemeDurumBindingSource.DataMember = "Tbl_Dershane_VeliEklemeDurum";
            this.tblDershaneVeliEklemeDurumBindingSource.DataSource = this.dershaneDataSet40;
            // 
            // dershaneDataSet40
            // 
            this.dershaneDataSet40.DataSetName = "DershaneDataSet40";
            this.dershaneDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Dershane_VeliEklemeDurumTableAdapter
            // 
            this.tbl_Dershane_VeliEklemeDurumTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veliIDDataGridViewTextBoxColumn,
            this.veliAdDataGridViewTextBoxColumn,
            this.veliSoyadDataGridViewTextBoxColumn,
            this.VeliTC});
            this.dataGridView2.DataSource = this.tblDershaneVeliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 258);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 176);
            this.dataGridView2.TabIndex = 2;
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
            // VeliTC
            // 
            this.VeliTC.DataPropertyName = "VeliTC";
            this.VeliTC.HeaderText = "TC";
            this.VeliTC.Name = "VeliTC";
            // 
            // tblDershaneVeliBindingSource
            // 
            this.tblDershaneVeliBindingSource.DataMember = "Tbl_Dershane_Veli";
            this.tblDershaneVeliBindingSource.DataSource = this.dershaneDataSet41;
            // 
            // dershaneDataSet41
            // 
            this.dershaneDataSet41.DataSetName = "DershaneDataSet41";
            this.dershaneDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Dershane_VeliTableAdapter
            // 
            this.tbl_Dershane_VeliTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(21, 450);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(284, 46);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // VeliEklemeDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(327, 513);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VeliEklemeDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veli Ekleme Durum";
            this.Load += new System.EventHandler(this.VeliEklemeDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliEklemeDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDershaneVeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet41)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DershaneDataSet40 dershaneDataSet40;
        private System.Windows.Forms.BindingSource tblDershaneVeliEklemeDurumBindingSource;
        private DershaneDataSet40TableAdapters.Tbl_Dershane_VeliEklemeDurumTableAdapter tbl_Dershane_VeliEklemeDurumTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DershaneDataSet41 dershaneDataSet41;
        private System.Windows.Forms.BindingSource tblDershaneVeliBindingSource;
        private DershaneDataSet41TableAdapters.Tbl_Dershane_VeliTableAdapter tbl_Dershane_VeliTableAdapter;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliEkleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeliTC;
    }
}