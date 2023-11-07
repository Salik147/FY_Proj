using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string enteredId = TextBox1.Text.Trim();
            string enteredPassword = TextBox2.Text.Trim();

            if (enteredId == "admin" && enteredPassword == "admin")
            {
                // Redirect to admin.aspx
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                // Display "wrong password" message
                Label3.Text = "Wrong information";
            }
        }
    }
}