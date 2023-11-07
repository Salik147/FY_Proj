namespace WindowsFormsApplication7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApplication7.DatabaseDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.videoPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.videosTableAdapter = new WindowsFormsApplication7.DatabaseDataSet1TableAdapters.videosTableAdapter();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.videosBindingSource, "video_path", true));
            this.comboBox1.DataSource = this.videosBindingSource;
            this.comboBox1.DisplayMember = "video_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "video_id";
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "videos";
            this.videosBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(855, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Clip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoPlayer1
            // 
            this.videoPlayer1.Enabled = true;
            this.videoPlayer1.Location = new System.Drawing.Point(139, 187);
            this.videoPlayer1.Name = "videoPlayer1";
            this.videoPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer1.OcxState")));
            this.videoPlayer1.Size = new System.Drawing.Size(1000, 542);
            this.videoPlayer1.TabIndex = 2;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpload.Location = new System.Drawing.Point(1017, 48);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "buttonUpload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Visible = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(1017, 77);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(960, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "Maps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1058, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 65);
            this.button3.TabIndex = 9;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(482, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 73);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To IRA";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1157, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 614);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(322, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select clip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1604, 754);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.videoPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer1;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private DatabaseDataSet1TableAdapters.videosTableAdapter videosTableAdapter;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

