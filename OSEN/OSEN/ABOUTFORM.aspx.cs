using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSEN
{
    public partial class ABOUTFORM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["one"] != null)
            {
                if (Session["one"].ToString() == "1")
                {
                    LabelAB.Visible = true;
                    LabelAB.ForeColor = System.Drawing.Color.Red;
                    LabelAbout.Font.Underline = true;
                    LabelAbout.ForeColor = System.Drawing.Color.Red;
                }
                else if (Session["one"].ToString() == "2")
                {
                    LabelTerm.Visible = true;
                    LabelTerm.ForeColor = System.Drawing.Color.Red; 
                    Label2.Font.Underline = true;
                    Label2.ForeColor = System.Drawing.Color.Red;
                }
                else if (Session["one"].ToString() == "3")
                {
                    LabelFll.Visible = true;
                    LabelFll.ForeColor = System.Drawing.Color.Red;
                    LabelContact.Font.Underline = true;
                    LabelContact.ForeColor = System.Drawing.Color.Red;
                }
                else if (Session["one"].ToString() == "4")
                {
                    LabelSocial.Font.Underline = true;
                    LabelSocial.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }
    }
}