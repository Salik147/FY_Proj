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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expectedName = "admin";
            string expectedPassword = "password";

            string enteredName = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredName == expectedName && enteredPassword == expectedPassword)
            {
                // Open the next form or perform other actions
                Form5 nextForm = new Form5();
                nextForm.Show();

                // Hide the current form if needed
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
