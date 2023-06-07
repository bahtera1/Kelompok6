namespace Kelompok6
{
    partial class Form2
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
            this.dBTiketKeretaDataSet = new Kelompok6.DBTiketKeretaDataSet();
            this.dBTiketKeretaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerbongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerbongTableAdapter = new Kelompok6.DBTiketKeretaDataSetTableAdapters.gerbongTableAdapter();
            this.nomorgerbongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahkursiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokursiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTiketKeretaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTiketKeretaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerbongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA GRID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorgerbongDataGridViewTextBoxColumn,
            this.jumlahkursiDataGridViewTextBoxColumn,
            this.nokursiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gerbongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 321);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dBTiketKeretaDataSet
            // 
            this.dBTiketKeretaDataSet.DataSetName = "DBTiketKeretaDataSet";
            this.dBTiketKeretaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBTiketKeretaDataSetBindingSource
            // 
            this.dBTiketKeretaDataSetBindingSource.DataSource = this.dBTiketKeretaDataSet;
            this.dBTiketKeretaDataSetBindingSource.Position = 0;
            // 
            // gerbongBindingSource
            // 
            this.gerbongBindingSource.DataMember = "gerbong";
            this.gerbongBindingSource.DataSource = this.dBTiketKeretaDataSetBindingSource;
            // 
            // gerbongTableAdapter
            // 
            this.gerbongTableAdapter.ClearBeforeFill = true;
            // 
            // nomorgerbongDataGridViewTextBoxColumn
            // 
            this.nomorgerbongDataGridViewTextBoxColumn.DataPropertyName = "nomor_gerbong";
            this.nomorgerbongDataGridViewTextBoxColumn.HeaderText = "nomor_gerbong";
            this.nomorgerbongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorgerbongDataGridViewTextBoxColumn.Name = "nomorgerbongDataGridViewTextBoxColumn";
            this.nomorgerbongDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahkursiDataGridViewTextBoxColumn
            // 
            this.jumlahkursiDataGridViewTextBoxColumn.DataPropertyName = "jumlah_kursi";
            this.jumlahkursiDataGridViewTextBoxColumn.HeaderText = "jumlah_kursi";
            this.jumlahkursiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahkursiDataGridViewTextBoxColumn.Name = "jumlahkursiDataGridViewTextBoxColumn";
            this.jumlahkursiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nokursiDataGridViewTextBoxColumn
            // 
            this.nokursiDataGridViewTextBoxColumn.DataPropertyName = "no_kursi";
            this.nokursiDataGridViewTextBoxColumn.HeaderText = "no_kursi";
            this.nokursiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokursiDataGridViewTextBoxColumn.Name = "nokursiDataGridViewTextBoxColumn";
            this.nokursiDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(6, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "DATA GRID";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTiketKeretaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTiketKeretaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerbongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBTiketKeretaDataSetBindingSource;
        private DBTiketKeretaDataSet dBTiketKeretaDataSet;
        private System.Windows.Forms.BindingSource gerbongBindingSource;
        private DBTiketKeretaDataSetTableAdapters.gerbongTableAdapter gerbongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorgerbongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahkursiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokursiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}