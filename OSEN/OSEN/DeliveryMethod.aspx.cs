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
    public partial class DELIVERYMETHOD : System.Web.UI.Page
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
            if (Session["Services"] != null)
            {
                LabelServ.Text = Session["Services"].ToString();
            }

            if (Session["cust1"] != null)
            {
                LabelCust.Text = Session["cust1"].ToString();
            }

            Session["Services"] = LabelServ.Text;
            Delivery_ID();

            Session["Delivery_ID"] = Delivery_ID();
            conn = new SqlConnection(constr);
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Delivery ON; INSERT INTO Delivery (Delivery_ID,Cust_ID,Service_ID,Collect,Delivery) VALUES ('{Delivery_ID()}','{Session["cust1"]}','{Session["Services"]}','{0}','{1}') SET IDENTITY_INSERT Delivery OFF;", conn);
                adap = new SqlDataAdapter();
                dat = new DataSet();

                adap.SelectCommand = AddData;
                adap.Fill(dat, "Services");

                conn.Close();
                Response.Redirect("Deliv_Address.aspx");
            }
            catch (Exception errors)
            {
                LabelError.Visible = true;
                LabelError.Text = errors.Message;
            }
        }

        protected void btnCollect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Delivery ON; INSERT INTO Delivery (Delivery_ID,Cust_ID,Service_ID,Collect,Delivery) VALUES ('{Delivery_ID()}','{Session["cust1"]}','{Session["Services"]}','{1}','{0}') SET IDENTITY_INSERT Delivery OFF;", conn);
                adap = new SqlDataAdapter();
                dat = new DataSet();

                adap.SelectCommand = AddData;
                adap.Fill(dat, "Services");

                conn.Close();
                Response.Redirect("OutputForm.aspx");
            }
            catch (Exception errors)
            {
                LabelError.Visible = true;
                LabelError.Text = errors.Message;
            }
        }
        public int Delivery_ID()
        {
            int rand = new Random().Next(100000, 999999);
            int myProduct = rand;

            return myProduct;
        }
    }
}