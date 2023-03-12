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
    public partial class CONTINUEFORM : System.Web.UI.Page
    {
        //database
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public SqlDataReader readData;
        public SqlDataReader readData2;
        public DataSet dat;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Omphe\OneDrive\Documents\c#projects\OSEN\OSEN\App_Data\Laundry.mdf;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);

            HttpCookie Remember = Request.Cookies["LoginStatus"];
            if (Remember != null)
            {
                LabelCust_ID.Text = Remember["Cust_ID"];
                Label1.Text = Remember["Cust_ID"];

            }
            Session["cust"] = LabelCust_ID.Text;
            Session["cust1"] = LabelCust_ID.Text;
            qqer();
            houses();
            Services();
            delivery();
        }

        protected void butnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Session["customer"] = LabelCust_ID.Text;

                conn = new SqlConnection(constr);
                conn.Open();

                String payments = $"DELETE FROM Payment WHERE Cust_ID = '{LabelCust_ID.Text}'";
                SqlCommand comm4 = new SqlCommand(payments, conn);
                SqlDataAdapter adap4 = new SqlDataAdapter();
                DataSet dat4 = new DataSet();

                comm4.ExecuteNonQuery();
                conn.Close();

                conn = new SqlConnection(constr);
                conn.Open();

                String delivAdd = "SELECT Delivery_ID,Cust_ID FROM Delivery WHERE Cust_ID = @Deliv";
                SqlCommand comm5 = new SqlCommand(delivAdd, conn);
                comm5.Parameters.AddWithValue("@Deliv", LabelCust_ID.Text);
                SqlDataReader readData4 = comm5.ExecuteReader();

                if ((readData4.Read()) == true)
                {
                    conn = new SqlConnection(constr);
                    conn.Open();
                    Labeldel.Text = readData4["Delivery_ID"].ToString();
                    String DelivA = $"DELETE FROM Delivery_Address WHERE Delivery_ID = '{Labeldel.Text}'";
                    SqlCommand comm7 = new SqlCommand(DelivA, conn);
                    SqlDataAdapter adap7 = new SqlDataAdapter();
                    DataSet dat7 = new DataSet();

                    comm7.ExecuteNonQuery();
                    conn.Close();
                }
                conn.Close();

                conn = new SqlConnection(constr);
                conn.Open();

                String Deliv = $"DELETE FROM Delivery WHERE Cust_ID = '{LabelCust_ID.Text}'";
                SqlCommand comm2 = new SqlCommand(Deliv, conn);
                SqlDataAdapter adap3 = new SqlDataAdapter();
                DataSet dat3 = new DataSet();

                comm2.ExecuteNonQuery();
                conn.Close();



                conn = new SqlConnection(constr);
                conn.Open();
                String services = $"DELETE FROM Services WHERE Cust_ID = '{LabelCust_ID.Text}'";
                SqlCommand comm1 = new SqlCommand(services, conn);
                SqlDataAdapter adap2 = new SqlDataAdapter();
                DataSet dat2 = new DataSet();

                comm1.ExecuteNonQuery();
                conn.Close();


                conn = new SqlConnection(constr);
                conn.Open();
                String Bookin = $"DELETE FROM Bookings WHERE Cust_ID = '{LabelCust_ID.Text}'";
                SqlCommand comm10 = new SqlCommand(Bookin, conn);
                SqlDataAdapter adap20 = new SqlDataAdapter();
                DataSet dat20 = new DataSet();

                comm10.ExecuteNonQuery();
                conn.Close();



                conn = new SqlConnection(constr);
                conn.Open();

                String house = $"DELETE FROM HouseCall WHERE Cust_ID = '{LabelCust_ID.Text}'";
                SqlCommand comm = new SqlCommand(house, conn);
                adap = new SqlDataAdapter();
                dat = new DataSet();

                comm.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("HouseCall.aspx");

            }
            catch (Exception error)
            {
                erroLab.Visible = true;
                erroLab.Text = error.Message;
            }
        }

        protected void butnConti_Click(object sender, EventArgs e)
        {
            Session["customer"] = LabelCust_ID.Text;
            Session["cust1"] = LabelCust_ID.Text;

            try
            {
                HttpCookie Remember = new HttpCookie("LoginStatus");
                Remember["Cust_ID"] = LabelCust_ID.ToString();

                conn = new SqlConnection(constr);
                conn.Open();

                String sql = "SELECT Cust_ID,Yes_option FROM HouseCall WHERE Cust_ID = @Cust";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                readData = comm.ExecuteReader();

                if ((readData.Read() == true))
                {
                    if (readData["Yes_option"].ToString() == "True")
                    {

                        conn = new SqlConnection(constr);
                        conn.Open();

                        String book = "SELECT Cust_ID FROM Bookings WHERE Cust_ID = @Cust";
                        SqlCommand comm2 = new SqlCommand(book, conn);
                        comm2.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                        readData2 = comm2.ExecuteReader();

                        if ((readData2.Read() == true))
                        {
                            conn = new SqlConnection(constr);
                            conn.Open();

                            String Servi = "SELECT Cust_ID FROM Services WHERE Cust_ID = @Cust";
                            SqlCommand comm3 = new SqlCommand(Servi, conn);
                            comm3.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                            SqlDataReader readData3 = comm3.ExecuteReader();

                            if (readData3.Read() == true)
                            {
                                conn = new SqlConnection(constr);
                                conn.Open();

                                String Paym = "SELECT Cust_ID FROM Output WHERE Cust_ID = @Cust";
                                SqlCommand comm1 = new SqlCommand(Paym, conn);
                                comm1.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                                SqlDataReader readData = comm1.ExecuteReader();

                                if (readData.Read() == true)
                                {
                                    Label1.Visible = true;
                                    Label1.Text = "Service have been granted....Please select start to request new service";
                                }
                                else
                                {
                                    Response.Redirect("OutputForm.aspx");
                                }
                                conn.Close();
                            }
                            else
                            {
                                Response.Redirect("Services.aspx");
                            }
                            conn.Close();


                        }
                        else
                        {
                            Response.Redirect("Booking.aspx");
                        }
                        conn.Close();

                    }
                    else
                    {
                        conn = new SqlConnection(constr);
                        conn.Open();

                        String Servi2 = "SELECT Cust_ID FROM Services WHERE Cust_ID = @Cust";
                        SqlCommand comm7 = new SqlCommand(Servi2, conn);
                        comm7.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                        SqlDataReader readData5 = comm7.ExecuteReader();

                        if (readData5.Read() == true)
                        {
                            conn = new SqlConnection(constr);
                            conn.Open();

                            String Delivery = "SELECT Cust_ID,Delivery_ID,Delivery FROM Delivery WHERE Cust_ID = @Cust";
                            SqlCommand comm8 = new SqlCommand(Delivery, conn);
                            comm8.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                            SqlDataReader readData8 = comm8.ExecuteReader();

                            if ((readData8.Read()) == true)
                            {
                                if (readData8["Delivery"].ToString() == "True")
                                {
                                    Label1.Text = readData8["Delivery_ID"].ToString();
                                    conn = new SqlConnection(constr);
                                    conn.Open();

                                    String Delivery_Address = "SELECT Delivery_ID FROM Delivery_Address WHERE Delivery_ID = @Cust";
                                    SqlCommand comm4 = new SqlCommand(Delivery_Address, conn);
                                    comm4.Parameters.AddWithValue("@Cust", Label1.Text);
                                    SqlDataReader readData4 = comm4.ExecuteReader();

                                    if (readData4.Read() == true)
                                    {
                                        conn = new SqlConnection(constr);
                                        conn.Open();

                                        String Payment = "SELECT Delivery_ID FROM Payment WHERE Delivery_ID = @Cust";
                                        SqlCommand comm5 = new SqlCommand(Payment, conn);
                                        comm5.Parameters.AddWithValue("@Cust", Label1.Text);
                                        SqlDataReader readData6 = comm5.ExecuteReader();

                                        if (readData6.Read() == true)
                                        {
                                            conn = new SqlConnection(constr);
                                            conn.Open();

                                            String outp = "SELECT Cust_ID FROM Output WHERE Cust_ID = @Cust";
                                            SqlCommand com = new SqlCommand(outp, conn);
                                            com.Parameters.AddWithValue("@Cust", LabelCust_ID.Text);
                                            SqlDataReader readDa = com.ExecuteReader();

                                            if (readDa.Read() == true)
                                            {
                                                erroLab.Visible = true;
                                                erroLab.Text = "Service have been granted....Please select start to request new service";
                                            }
                                            else
                                            {
                                                Response.Redirect("OutputForm.aspx");
                                            }
                                            conn.Close();
                                        }
                                        else
                                        {
                                            Response.Redirect("PaymentsMethods.aspx");
                                        }
                                        conn.Close();
                                    }
                                    else
                                    {
                                        Response.Redirect("Deliv_Address.aspx");
                                    }
                                    conn.Close();
                                }
                                else
                                {
                                    Response.Redirect("OutputForm.aspx");
                                }

                            }
                            else
                            {
                                Response.Redirect("DeliveryMethod.aspx");
                            }
                            conn.Close();
                        }
                        else
                        {
                            Response.Redirect("Services.aspx");
                        }
                        conn.Close();
                    }

                }
                else
                {
                    Response.Redirect("HouseCall.aspx");
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                erroLab.Visible = true;
                erroLab.Text = error.Message;

            }
        }
        public void qqer()
        {
            conn = new SqlConnection(constr);
            conn.Open();

            String sql = "SELECT Cust_ID FROM Customers WHERE Cust_ID = @ID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ID", LabelCust_ID.Text);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                Label1.Text = readData["Cust_ID"].ToString();
                Session["cust1"] = readData["Cust_ID"].ToString();
                Session["cust"] = readData["Cust_ID"].ToString();

                HttpCookie cont = new HttpCookie("Continue");
                cont["Continue"] = Label1.Text;
            }
            conn.Close();
        }
        public void houses()
        {
            conn = new SqlConnection(constr);
            conn.Open();

            String sql = "SELECT House_ID FROM HouseCall WHERE Cust_ID = @ID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ID", LabelCust_ID.Text);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                Session["house"] = readData["House_ID"].ToString();
            }
            conn.Close();
        }
        public void Services()
        {

            conn = new SqlConnection(constr);
            conn.Open();

            String sql = "SELECT Service_ID FROM Services WHERE Cust_ID = @ID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ID", LabelCust_ID.Text);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                Session["Services"] = readData["Service_ID"].ToString();
            }
            conn.Close();
        }
        public void delivery()
        {
            conn = new SqlConnection(constr);
            conn.Open();

            String sql = "SELECT Delivery_ID FROM Delivery WHERE Cust_ID = @ID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ID", LabelCust_ID.Text);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                Session["Delivery_ID"] = readData["Delivery_ID"].ToString();
            }
            conn.Close();


        }
    }
}