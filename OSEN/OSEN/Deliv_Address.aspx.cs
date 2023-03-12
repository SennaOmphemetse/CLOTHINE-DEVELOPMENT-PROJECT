using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace OSEN
{
    public partial class DELIVERYADDRESS : System.Web.UI.Page
    {
        //database
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public SqlDataReader readData;
        public DataSet dat;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Omphe\OneDrive\Documents\c#projects\OSEN\OSEN\App_Data\Laundry.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            ALT_ID();
            Session["ALT"] = ALT_ID();

            conn = new SqlConnection(constr);
            LabelDeliv.Visible = false;

            if (Session["Delivery_ID"] != null)
            {
                LabelDeliv.Text = Session["Delivery_ID"].ToString();
            }
            if (Session["Services"] != null)
            {
                Labelserv.Text = Session["Services"].ToString();
            }

            Session["Deliv"] = LabelDeliv.Text;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int a = 75;
            int amount = a;

            try
            {
                conn.Open();

                SqlCommand AddData = new SqlCommand($"INSERT INTO Delivery_Address (Delivery_ID,Address1,Address2,Address3,City,Postal_Code,Collector_Fname,Collector_Lname,Collector_Cellphone,Amount,ALT_ID) VALUES ('{LabelDeliv.Text}','{TextAdd1.Text}','{TextAdd2.Text}','{TextAdd3.Text}','{TextCity.Text}','{TextPost.Text}','{TextFname.Text}','{TextSname.Text}','{TextCellp.Text}','{amount}','{ALT_ID()}')", conn);
                adap = new SqlDataAdapter();
                dat = new DataSet();

                adap.SelectCommand = AddData;
                adap.Fill(dat, "Delivery_Address");

                conn.Close();
                Response.Redirect("PaymentsMethods.aspx");

            }
            catch (SqlException error)
            {
                LabelErr.Visible = true;
                LabelErr.Text = error.Message;
            }
        }
        public String ALT_ID()
        {
            int rand = new Random().Next(100000, 999999);
            String myProduct = rand.ToString();

            return myProduct;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextAdd1.Text = "";
            TextAdd2.Text = "";
            TextAdd3.Text = "";
            TextCellp.Text = "";
            TextCity.Text = "";
            TextPost.Text = "";
            TextFname.Text = "";
            TextSname.Text = "";
        }
    }
}