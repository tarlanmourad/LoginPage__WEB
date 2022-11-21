using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage__WEB
{
    public partial class register : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=TARLAN\\LOCALHOST;Initial Catalog=Login;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) CaptchaText();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtUsername.Text != "" && txtRptPassword.Text != "")
                {
                    if (txtPassword.Text == txtRptPassword.Text)
                    {
                        if (txtCaptcha.Text == lblCaptcha.Text)
                        {
                            conn.Open();
                            string query = "INSERT INTO Users VALUES('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successful Registation!');window.location='login.aspx';", true);
                        }
                        else
                        {
                            string script = "alert(\"Captchas are not matching! Please try again.\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }

                    }
                    else
                    {
                        string script = "alert(\"Passwords are not matching! Try again.\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtRptPassword.Text = "";
                    txtCaptcha.Text = "";
                    lblCaptcha.Text = "";
                    txtUsername.Focus();
                }
                else
                {
                    string script = "alert(\"Empty field! Please fill.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                CaptchaText();
            }
            catch { }
            finally { }
        }

        protected void btnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        public void CaptchaText()
        {
            Random rnd = new Random();

            const string src = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int size = 6;

            var randomStr = "";

            for (int i = 0; i < size; i++)
            {
                int x = rnd.Next(src.Length);
                randomStr += src[x];
            }

            lblCaptcha.Text = randomStr;
        }
    }
}