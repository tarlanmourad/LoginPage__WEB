using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage__WEB
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection("Data Source=TARLAN\\LOCALHOST;Initial Catalog=Login;Integrated Security=True");

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string script = "alert(\"Login Successful!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Login Unsuccessful. Please try again.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");
        }
    }
}