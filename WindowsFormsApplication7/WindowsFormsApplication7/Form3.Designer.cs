namespace WindowsFormsApplication7
{
    partial class Form3
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
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet = new WindowsFormsApplication7._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet7 = new WindowsFormsApplication7.DatabaseDataSet7();
            this.button3 = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new WindowsFormsApplication7.DatabaseDataSet3();
            this.productTableAdapter = new WindowsFormsApplication7.DatabaseDataSet3TableAdapters.ProductTableAdapter();
            this.productTableAdapter1 = new WindowsFormsApplication7.DatabaseDataSet7TableAdapters.ProductTableAdapter();
            this.productTableAdapter2 = new WindowsFormsApplication7._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSetTableAdapters.ProductTableAdapter();
            this.databaseDataSet9 = new WindowsFormsApplication7.DatabaseDataSet9();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter3 = new WindowsFormsApplication7.DatabaseDataSet9TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(402, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(868, 689);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet;
            // 
            // _E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet
            // 
            this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet.DataSetName = "_E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSe" +
    "t";
            this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.databaseDataSet7;
            // 
            // databaseDataSet7
            // 
            this.databaseDataSet7.DataSetName = "DatabaseDataSet7";
            this.databaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1466, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // databaseDataSet9
            // 
            this.databaseDataSet9.DataSetName = "DatabaseDataSet9";
            this.databaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataMember = "Product";
            this.productBindingSource3.DataSource = this.databaseDataSet9;
            // 
            // productTableAdapter3
            // 
            this.productTableAdapter3.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1604, 754);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Map Tab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSet3TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button3;
        private DatabaseDataSet7 databaseDataSet7;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DatabaseDataSet7TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private _E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet _E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private _E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSetTableAdapters.ProductTableAdapter productTableAdapter2;
        private DatabaseDataSet9 databaseDataSet9;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private DatabaseDataSet9TableAdapters.ProductTableAdapter productTableAdapter3;
    }
}