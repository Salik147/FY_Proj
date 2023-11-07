using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace WindowsFormsApplication7
{
    public partial class Form4 : Form
    {
        string imageUrl = null;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\usb\fyp1\WindowsFormsApplication7\WindowsFormsApplication7\Database.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet10.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.databaseDataSet10.Product);
            // TODO: This line of code loads data into the 'databaseDataSet8.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.databaseDataSet8.Product);
            // TODO: This line of code loads data into the 'databaseDataSet5.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet5.Product);

            RefreshDataGridView();
        }
        private void Form4_Activated(object sender, EventArgs e)
        {
            // Call RefreshDataGridView in Form.Activated event
            RefreshDataGridView();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;

                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Product (ProductName,Photo,PhotoUrl) VALUES (@ProductName,@Photo,@PhotoUrl)", con);
            cmd.Parameters.AddWithValue("@ProductName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Photo", arr);
            cmd.Parameters.AddWithValue("@PhotoUrl", imageUrl);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product saved");

            SqlCommand cmd2 = new SqlCommand("select * from Product", con);
            DataTable dt = new DataTable();
            dt.Load(cmd2.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();

            RefreshDataGridView(); // Call this method to update the DataGridView with the latest data
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

                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

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
        private void RefreshDataGridView()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text.Trim(); // Get the input from the TextBox

            if (!string.IsNullOrEmpty(productName))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Product WHERE ProductName = @ProductName", con);
                    deleteCmd.Parameters.AddWithValue("@ProductName", productName);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        RefreshDataGridView();
                        MessageBox.Show("Product deleted");
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a product name to delete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();

            this.Visible = false;
        }
    }
}
