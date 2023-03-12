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
    public partial class PAYMENTSFORM : System.Web.UI.Page
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
            conn = new SqlConnection(constr);

            if (Session["Deliv"] != null)
            {
                Labeldeli.Text = Session["Deliv"].ToString();
            }

            if (Session["Delivery_ID"] != null)
            {
                Labeldeli.Text = Session["Delivery_ID"].ToString();
            }

            if (Session["cust1"] != null)
            {
                LabelCust.Text = Session["cust1"].ToString();
            }
            
            Paym_ID();
            serv();

            Session["Pay"] = Paym_ID();
        }

        protected void ButCard_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(constr);
                conn.Open();

                String payments = $"DELETE FROM Payment WHERE Cust_ID = '{LabelCust.Text}'";
                SqlCommand comm4 = new SqlCommand(payments, conn);
                SqlDataAdapter adap4 = new SqlDataAdapter();
                DataSet dat4 = new DataSet();

                comm4.ExecuteNonQuery();
                conn.Close();

                conn = new SqlConnection(constr);
                conn.Open();
                String sql = "SELECT Service_ID,Total_Amount FROM Services WHERE Service_ID = @SERV";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@SERV", LabelSer.Text);
                readData = comm.ExecuteReader();

                if ((readData.Read() == true))
                {
                    LabelAmou.Text = readData["Total_Amount"].ToString();
                    //double amou = 75.00 + double.Parse(LabelAmou.Text);
                    double amount = Convert.ToDouble(LabelAmou.Text) + 75.00;

                    conn = new SqlConnection(constr);
                    conn.Open();
                    SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Payment ON; INSERT INTO Payment (Payment_ID,Cust_ID,Service_ID,Delivery_ID,Cash_on_Delivery,Card_on_Delivery,Amount) VALUES ('{Paym_ID()}','{LabelCust.Text}','{LabelSer.Text}','{Labeldeli.Text}','{0}','{1}','{amount}') SET IDENTITY_INSERT Payment OFF;", conn);
                    adap = new SqlDataAdapter();
                    dat = new DataSet();

                    adap.SelectCommand = AddData;
                    adap.Fill(dat, "Payment");
                    conn.Close();

                }

                conn.Close();

                Session["cust1"].ToString();
                Session["Delivery_ID"].ToString();
                Response.Redirect("OutputForm.aspx");

            }
            catch (SqlException error)
            {
                Label1.Visible = true;
                Label1.Text = error.Message;
            }
        }

        public void serv()
        {
            conn = new SqlConnection(constr);
            conn.Open();
            String sql = "SELECT Delivery_ID,Cust_ID,Service_ID FROM Delivery WHERE Delivery_ID = @SERV";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@SERV", Labeldeli.Text);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                LabelCust.Text = readData["Cust_ID"].ToString();
                LabelSer.Text = readData["Service_ID"].ToString();
                Session["cust1"] = LabelCust.Text;
            }
            conn.Close();
        }

        protected void ButCashD_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(constr);
                conn.Open();

                String payments = $"DELETE FROM Payment WHERE Cust_ID = '{LabelCust.Text}'";
                SqlCommand comm4 = new SqlCommand(payments, conn);
                SqlDataAdapter adap4 = new SqlDataAdapter();
                DataSet dat4 = new DataSet();

                comm4.ExecuteNonQuery();
                conn.Close();

                conn = new SqlConnection(constr);
                conn.Open();
                String sql = "SELECT Service_ID,Total_Amount FROM Services WHERE Service_ID = @SERV";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@SERV", LabelSer.Text);
                readData = comm.ExecuteReader();

                if ((readData.Read() == true))
                {
                    conn = new SqlConnection(constr);
                    conn.Open();

                    LabelAmou.Text = readData["Total_Amount"].ToString();
                    //double amou = 75.00 + double.Parse(LabelAmou.Text);
                    double amount = Convert.ToDouble(LabelAmou.Text) + 75.00;

                    SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Payment ON; INSERT INTO Payment (Payment_ID,Cust_ID,Service_ID,Delivery_ID,Cash_on_Delivery,Card_on_Delivery,Amount) VALUES ('{Paym_ID()}','{LabelCust.Text}','{LabelSer.Text}','{Labeldeli.Text}','{1}','{0}','{amount}') SET IDENTITY_INSERT Payment OFF;", conn);
                    adap = new SqlDataAdapter();
                    dat = new DataSet();

                    adap.SelectCommand = AddData;
                    adap.Fill(dat, "Payment");
                    conn.Close();
                }

                conn.Close();
                Session["cust1"].ToString();
                Session["Delivery_ID"].ToString();
                Response.Redirect("OutputForm.aspx");

            }
            catch (SqlException error)
            {
                Label1.Visible = true;
                Label1.Text = error.Message;
            }
        }
        public int Paym_ID()
        {
            int rand = new Random().Next(100000, 999999);
            int myProduct = rand;

            return myProduct;
        }
    }
}