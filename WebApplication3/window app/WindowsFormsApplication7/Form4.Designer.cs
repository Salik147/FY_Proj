namespace WindowsFormsApplication7
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet8 = new WindowsFormsApplication7.DatabaseDataSet8();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet5 = new WindowsFormsApplication7.DatabaseDataSet5();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new WindowsFormsApplication7.DatabaseDataSet5TableAdapters.ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.productTableAdapter1 = new WindowsFormsApplication7.DatabaseDataSet8TableAdapters.ProductTableAdapter();
            this.databaseDataSet10 = new WindowsFormsApplication7.DatabaseDataSet10();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new WindowsFormsApplication7.DatabaseDataSet10TableAdapters.ProductTableAdapter();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(717, 74);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 34);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(691, 204);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(792, 204);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 35);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.databaseDataSet8;
            // 
            // databaseDataSet8
            // 
            this.databaseDataSet8.DataSetName = "DatabaseDataSet8";
            this.databaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet5;
            // 
            // databaseDataSet5
            // 
            this.databaseDataSet5.DataSetName = "DatabaseDataSet5";
            this.databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(442, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Map";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1044, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // databaseDataSet10
            // 
            this.databaseDataSet10.DataSetName = "DatabaseDataSet10";
            this.databaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.databaseDataSet10;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(305, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(637, 320);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1413, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "MapModify_Tab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseDataSet5 databaseDataSet5;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSet5TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private DatabaseDataSet8 databaseDataSet8;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DatabaseDataSet8TableAdapters.ProductTableAdapter productTableAdapter1;
        private DatabaseDataSet10 databaseDataSet10;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private DatabaseDataSet10TableAdapters.ProductTableAdapter productTableAdapter2;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}