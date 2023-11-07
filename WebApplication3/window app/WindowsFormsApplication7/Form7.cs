using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet12.Product' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'databaseDataSet11.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet3.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
