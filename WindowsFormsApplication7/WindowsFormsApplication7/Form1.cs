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
using System.IO;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\usb\fyp1\WindowsFormsApplication7\WindowsFormsApplication7\Database.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            // Connect to the SQL database
            connection = new SqlConnection(connectionString);
            connection.Open();

            // Populate the ComboBox with video names from the database
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            string query = "SELECT video_name FROM videos";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Clear the ComboBox before setting the DataSource
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["video_name"].ToString());
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    // Retrieve the selected video name from the ComboBox
                    string selectedVideoName = comboBox1.SelectedItem.ToString();

                    // Retrieve the video path from the database based on the selected video name
                    string query = "SELECT video_path FROM videos WHERE video_name = @videoName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@videoName", selectedVideoName);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string videoPath = result.ToString();

                            // Set the video source for the VideoPlayer control
                            videoPlayer1.URL = videoPath;

                            // Start playing the video
                            videoPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            MessageBox.Show("Video path not found in the database.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a video from the ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close the SQL connection when the form is closed
            connection.Close();
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.Fill(this.databaseDataSet1.videos);

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files (*.mp4;*.avi;*.wmv)|*.mp4;*.avi;*.wmv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string videoPath = openFileDialog.FileName;

                // Close the VideoPlayer control and release resources
                videoPlayer1.Ctlcontrols.stop();
                videoPlayer1.URL = null;

                // Save the video file to a specific location
                string destinationPath = @"E:\usb\WindowsFormsApplication7\WindowsFormsApplication7\Videos" + Path.GetFileName(videoPath);
                File.Copy(videoPath, destinationPath, true);

                // Get the video name from the file name
                string videoName = Path.GetFileNameWithoutExtension(videoPath);

                // Store the video details in the database
                string query = "INSERT INTO videos (video_name, video_path) VALUES (@videoName, @videoPath)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@videoName", videoName);
                    command.Parameters.AddWithValue("@videoPath", destinationPath);
                    command.ExecuteNonQuery();
                }

                // Populate the ComboBox with the updated video names
                PopulateComboBox();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedVideoName = comboBox1.SelectedItem.ToString();

                // Retrieve the video path from the database based on the selected video name
                string query = "SELECT video_path FROM videos WHERE video_name = @videoName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@videoName", selectedVideoName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string videoPath = result.ToString();

                        // Delete the video record from the database
                        string deleteQuery = "DELETE FROM videos WHERE video_name = @videoName";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@videoName", selectedVideoName);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Delete the video file from the file system
                        if (File.Exists(videoPath))
                        {
                            File.Delete(videoPath);
                        }

                        // Populate the ComboBox with the updated video names
                        PopulateComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Video path not found in the database.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a video from the ComboBox.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();

            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();

            
        }
    }
}

