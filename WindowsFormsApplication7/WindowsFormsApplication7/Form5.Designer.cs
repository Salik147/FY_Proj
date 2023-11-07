namespace WindowsFormsApplication7
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet4 = new WindowsFormsApplication7.DatabaseDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.videoPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.videosTableAdapter = new WindowsFormsApplication7.DatabaseDataSet4TableAdapters.videosTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.videosBindingSource;
            this.comboBox1.DisplayMember = "video_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(579, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "video_id";
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "videos";
            this.videosBindingSource.DataSource = this.databaseDataSet4;
            // 
            // databaseDataSet4
            // 
            this.databaseDataSet4.DataSetName = "DatabaseDataSet4";
            this.databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1139, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(1139, 466);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(99, 55);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "buttonUpload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1139, 583);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 61);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1139, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Maps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoPlayer1
            // 
            this.videoPlayer1.Enabled = true;
            this.videoPlayer1.Location = new System.Drawing.Point(401, 226);
            this.videoPlayer1.Name = "videoPlayer1";
            this.videoPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer1.OcxState")));
            this.videoPlayer1.Size = new System.Drawing.Size(608, 516);
            this.videoPlayer1.TabIndex = 7;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1139, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 62);
            this.button3.TabIndex = 12;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(700, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome To Admin Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1293, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 693);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(314, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select clip";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1604, 754);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.videoPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.Text = "Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer1;
        private DatabaseDataSet4 databaseDataSet4;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private DatabaseDataSet4TableAdapters.videosTableAdapter videosTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}