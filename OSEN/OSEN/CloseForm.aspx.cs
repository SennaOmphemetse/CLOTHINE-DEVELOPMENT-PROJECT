using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSEN
{
    public partial class CloseForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            redirect();
        }
        protected void redirect()
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS", "setTimeout(function() { window.location.replace('welcome.aspx') }, 3000);", true);
        }
    }
}