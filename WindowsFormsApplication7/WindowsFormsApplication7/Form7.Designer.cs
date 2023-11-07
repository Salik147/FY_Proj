namespace WindowsFormsApplication7
{
    partial class Form7
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
            this.databaseDataSet3 = new WindowsFormsApplication7.DatabaseDataSet11();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WindowsFormsApplication7.DatabaseDataSet11TableAdapters.ProductTableAdapter();
            this.databaseDataSet1 = new WindowsFormsApplication7.DatabaseDataSet1();
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataSet12 = new WindowsFormsApplication7.DatabaseDataSet12();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new WindowsFormsApplication7.DatabaseDataSet12TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoUrlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(378, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaseDataSet11
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet11";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet3;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            this.idProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            // 
            // databaseDataSet12
            // 
            this.databaseDataSet12.DataSetName = "DatabaseDataSet12";
            this.databaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.databaseDataSet12;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 754);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet11 databaseDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSet11TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource databaseDataSet1BindingSource;
        private DatabaseDataSet12 databaseDataSet12;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DatabaseDataSet12TableAdapters.ProductTableAdapter productTableAdapter1;
    }
}