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
    public partial class HOUSECALL : System.Web.UI.Page
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
            if (Session["customer"] != null)
            {
                LabelCust_ID.Text = Session["customer"].ToString();
                //Label1.Text = Session["customer"].ToString();
            }
            House_ID();

            Session["cust"] = LabelCust_ID.Text;
            Session["house"] = House_ID();
            conn = new SqlConnection(constr);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();

                SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT HouseCall ON; INSERT INTO HouseCall (House_ID,Cust_ID,Yes_option,No_option) VALUES ('{House_ID()}','{LabelCust_ID.Text}','{1}','{null}') SET IDENTITY_INSERT HouseCall OFF;", conn);
                adap = new SqlDataAdapter();
                dat = new DataSet();

                adap.SelectCommand = AddData;
                adap.Fill(dat, "HouseCall");

                conn.Close();
                Response.Redirect("Booking.aspx");



            }
            catch (SqlException error)
            {
                erroLab.Visible = true;
                erroLab.Text = error.Message;

            }
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT HouseCall ON; INSERT INTO HouseCall (House_ID,Cust_ID,Yes_option,No_option) VALUES ('{House_ID()}','{LabelCust_ID.Text}','{null}','{1}') SET IDENTITY_INSERT HouseCall OFF;", conn);
            adap = new SqlDataAdapter();
            dat = new DataSet();

            adap.SelectCommand = AddData;
            adap.Fill(dat, "HouseCall");

            conn.Close();
            Response.Redirect("Services.aspx");

        }
        public int House_ID()
        {
            int rand = new Random().Next(100000, 999999);
            int myProduct = rand;

            return myProduct;
        }
    }
}