using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class PictureForm : Form
    {
        public PictureForm(byte[] imageData)
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = image;

                pictureBox.Size = new Size(800, 600);
            }
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
