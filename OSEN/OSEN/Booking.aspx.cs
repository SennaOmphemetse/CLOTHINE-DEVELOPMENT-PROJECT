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
    public partial class BOOKINGFORM : System.Web.UI.Page
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
            Booking_ID();
            if (Session["house"] != null)
            {
                LabelHou.Text = Session["house"].ToString();
            }

            if (Session["cust"] != null)
            {
                LabelCust.Text = Session["cust"].ToString();
            }

            Session["mix"] = LabelCust.Text;
            Session["Book"] = Booking_ID();
            conn = new SqlConnection(constr);
            conn.Open();
        }

        protected void btnSubm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calendar1.SelectedDate <= DateTime.Now)
                {
                    labelError.Visible = true;
                    labelError.Text = "Select Future date from now on.";
                }
                else
                {
                    SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Bookings ON; INSERT INTO Bookings (Book_ID,Cust_ID,House_ID,Address1,Address2,Address3,City,Postal_Code,Booking_Date) VALUES ('{Booking_ID()}','{LabelCust.Text}','{Session["house"]}','{Add1Textb.Text}','{Addr2Textb.Text}','{Textadd3.Text}','{textCity.Text}','{textPostalText.Text}','{TextCala.Text}') SET IDENTITY_INSERT Bookings OFF;", conn);
                    adap = new SqlDataAdapter();
                    dat = new DataSet();

                    adap.SelectCommand = AddData;
                    adap.Fill(dat, "Bookings");

                    Response.Redirect("Services.aspx");
                }
                conn.Close();

            }
            catch (Exception error)
            {
                labelError.Visible = true;
                labelError.Text = error.Message;
            }
        }

        protected void ButCalend_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextCala.Text = Calendar1.SelectedDate.ToShortDateString() + " " + TextTime.Text;
            Calendar1.Visible = false;
        }
        public String Booking_ID()
        {
            int rand = new Random().Next(100000, 999999);
            String myProduct = rand.ToString();

            return myProduct;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            textCity.Text = "";
            Textadd3.Text = "";
            textPostalText.Text = "";
            Add1Textb.Text = "";
            Addr2Textb.Text = "";
            
        }
    }
}