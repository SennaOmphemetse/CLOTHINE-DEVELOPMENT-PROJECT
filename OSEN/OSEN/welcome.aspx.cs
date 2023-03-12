using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSEN
{
    public partial class WELCOMEFORM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

        protected void homeb_Click(object sender, EventArgs e)
        {
            Session["one"] = "1";
            Response.Redirect("ABOUTFORM.aspx");
            
        }

        protected void aboutb_Click(object sender, EventArgs e)
        {
            Session["one"] = "2";
            Response.Redirect("ABOUTFORM.aspx");
            
        }

        protected void ButContac_Click(object sender, EventArgs e)
        {
            Session["one"] = "3";
            Response.Redirect("ABOUTFORM.aspx");
            
        }

        protected void ButSocial_Click(object sender, EventArgs e)
        {
            Session["one"] = "4";
            Response.Redirect("ABOUTFORM.aspx");
        }
    }
}