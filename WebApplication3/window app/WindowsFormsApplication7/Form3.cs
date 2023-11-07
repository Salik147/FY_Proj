using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsFormsApplication7
{
    public partial class Form3 : Form
    {
        string imageUrl = null;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\usb\fyp1\WindowsFormsApplication7\WindowsFormsApplication7\Database.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet9.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter3.Fill(this.databaseDataSet9.Product);
            // TODO: This line of code loads data into the '_E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this._E__USB_FYP1_WINDOWSFORMSAPPLICATION7_WINDOWSFORMSAPPLICATION7_DATABASE_MDFDataSet.Product);
            // TODO: This line of code loads data into the 'databaseDataSet7.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.databaseDataSet7.Product);
            // TODO: This line of code loads data into the 'databaseDataSet3.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet3.Product);


            RefreshDataGridView();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            
            RefreshDataGridView();
        }

        // ... Your existing code ...

        private void RefreshDataGridView()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            con.Close();
            // Load product data into DataGridView
            this.productTableAdapter.Fill(this.databaseDataSet3.Product);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Photo" && e.RowIndex >= 0)
            {
                byte[] imageData = null;

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                {
                    imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }

            }
                // Check if a valid row is clicked (excluding header row)
                if (e.RowIndex >= 0)
            {
                // Retrieve the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the picture data from the selected row's data source
                byte[] imageData = (byte[])selectedRow.Cells["photoDataGridViewImageColumn"].Value;

                // Open the PictureForm and pass the image data
                PictureForm pictureForm = new PictureForm(imageData);
                pictureForm.ShowDialog();
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();

            this.Visible = false;
        }


    }
}
