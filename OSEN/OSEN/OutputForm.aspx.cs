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
    public partial class OutputForm : System.Web.UI.Page
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
            //Session["Cust"] = LabelCust.ToString();
            LabelCust.Text = Session["cust1"].ToString();

            if (Session["Delivery_ID"] != null)
            {
                LabelDelivv.Text = Session["Delivery_ID"].ToString();
            }
            if (Session["Pay"] != null)
            {
                LabeDelivery.Text = Session["Pay"].ToString();
            }
            if (Session["Book"] != null)
            {
                LabelNobook.Text = Session["Book"].ToString();
            }

            Outp_ID();
            addit();
            services();
            Serv_PAYMENTS();

            if (Session["Delivery_ID"] != null && Session["ALT"] != null)
            {
                Deliv_add();
            }
            Dist_Pay();
            Deliv_add();
            Booki_Pay();
            //Checkbook();
            //deliv1();
            customer();
        }

        protected void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();

            SqlCommand AddData = new SqlCommand($"INSERT INTO Output (Cust_ID,ORDER_ID) VALUES ('{Session["cust1"]}','{Outp_ID()}')", conn);
            adap = new SqlDataAdapter();
            dat = new DataSet();

            adap.SelectCommand = AddData;
            adap.Fill(dat, "Output");

            conn.Close();
            //email();
            Response.Redirect("CloseForm.aspx");
        }

        public void email()
        {
            SmtpClient all = new SmtpClient();
            all.Host = "smtp.gmail.com";
            all.Port = 587;

            all.Credentials = new System.Net.NetworkCredential("kanatladirang@gmail.com", "DirangKT@95196");
            all.EnableSsl = true;

            MailMessage messa = new MailMessage();
            messa.Subject = "Services";
            messa.Body = "DEAR " + custome.Text + "\n\nServices will be provided." + "\n\nHope you enjoy our services we have." + "\n\nThank you \n\nBest regards\nDirang Ka Natla";

            string addressTo = Labemail.Text;
            messa.To.Add(addressTo);
            string addressFrom = "Dirang ka Natla Administartion<kanatladirang@gmail.com>";
            messa.From = new MailAddress(addressFrom);
            try
            {
                all.Send(messa);
            }
            catch
            {
                throw;
            }
        }


        public void addit()
        {
            conn.Open();
            String sql = "SELECT Cust_ID,Delivery_ID FROM Delivery WHERE Cust_ID = @SERV";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@SERV", Session["cust1"]);
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                LabelDelivv.Text = readData["Delivery_ID"].ToString();
            }
            else
            {

            }
            conn.Close();
        }
        public void services()
        {
            try
            {

                SqlConnection connection = new SqlConnection(constr);
                connection.Open();
                string sql = $"SELECT Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num FROM Services WHERE Cust_ID = '{Session["cust1"]}' AND Service_ID = '{Session["Services"]}'";

                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Services");

                GVServices.DataSource = ds;
                GVServices.DataBind();
                connection.Close();

            }
            catch (Exception ex)
            {
                Labelerr.Text = ex.Message;
            }

        }

        public void Serv_PAYMENTS()
        {
            SqlConnection conn3 = new SqlConnection(constr);
            conn3.Open();
            String sql3 = "SELECT Cust_ID,Total_Amount,Service_ID FROM Services WHERE Cust_ID = @SERV AND Service_ID = @Srv";
            SqlCommand comm3 = new SqlCommand(sql3, conn3);
            comm3.Parameters.AddWithValue("@SERV", Session["cust1"]);
            comm3.Parameters.AddWithValue("@Srv", Session["Services"]);
            readData = comm3.ExecuteReader();

            if ((readData.Read() == true))
            {
                LabeService.Visible = true;
                LabeService.Text = "SERVICE PRICE R:" + readData["Total_Amount"].ToString();
                LabelProduct.Text = "PRODUCT ID: " + readData["Service_ID"].ToString();
            }
            else
            {
                LabeService.Visible = false;
            }
            conn3.Close();
        }
        public void Dist_Pay()
        {
            
            SqlConnection connn = new SqlConnection(constr);
            connn.Open();
            String sql1 = "SELECT Cust_ID,Amount,Cash_on_Delivery FROM Payment WHERE Cust_ID = @SERV";
            SqlCommand commm = new SqlCommand(sql1, connn);
            commm.Parameters.AddWithValue("@SERV", Session["cust1"]);
            SqlDataReader readData11 = commm.ExecuteReader();

            if ((readData11.Read() == true))
            {

                if (readData11["Cash_on_Delivery"].ToString() == "True")
                {
                    LabeDelivery.Visible = true;
                    LabeDelivery.Text = "Total price to pay is R: " + readData11["Amount"].ToString() + "\nMethod of payment will be cash on Delivery";
                }
                else
                {
                    LabeDelivery.Visible = true;
                    LabeDelivery.Text = "Total price to pay is R: " + readData11["Amount"].ToString() + "\nMethod of payment will be card on Delivery";

                }

            }
            else
            {
                LabeDelivery.Visible = true;
                LabeDelivery.Text = "No delivery";
            }
            connn.Close();
            

        }
        

        public void Booki_Pay()
        {


            if (LabelNobook.Text == "Label")
            {
                LabelNobook.Text = "No Booking made";
                LabelNobook.Visible = true;
            }
            else if (LabelNobook.Text == null)
            {
                LabelNobook.Text = "No Booking made";
                LabelNobook.Visible = true;
            }
            else
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string housec = "SELECT Cust_ID FROM Bookings WHERE Cust_ID = @Cust";
                SqlCommand comm2 = new SqlCommand(housec, conn);
                comm2.Parameters.AddWithValue("@Cust", Session["cust1"]);
                SqlDataReader readCust1 = comm2.ExecuteReader();

                if ((readCust1.Read() == true))
                {
                    SqlConnection connection2 = new SqlConnection(constr);
                    connection2.Open();
                    String sql2 = $"SELECT Address1,Address2,Address3,City,Postal_Code,Booking_Date FROM Bookings WHERE Cust_ID = '{Session["cust1"]}' AND Book_ID = '{Session["Book"]}'";
                    SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection2);
                    DataSet ds2 = new DataSet();
                    dataadapter2.Fill(ds2, "Bookings");

                    GridAddress.DataSource = ds2;
                    GridAddress.DataBind();
                    connection2.Close();
                }
                else
                {
                    LabelNobook.Visible = true;
                    LabelNobook.Text = "No bookings";
                }

                conn.Close();
            }

        }

        public void Deliv_add()
        {
            if (LabelDelivv.Text == "Label")
            {

            }
            else if (LabelDelivv.Text == null)
            {

            }
            else
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string housec = "SELECT Delivery_ID FROM Delivery_Address WHERE Delivery_ID = @Del";
                SqlCommand comm2 = new SqlCommand(housec, conn);
                comm2.Parameters.AddWithValue("@Del", LabelDelivv.Text);
                SqlDataReader readCust1 = comm2.ExecuteReader();

                if ((readCust1.Read() == true))
                {
                    SqlConnection connection1 = new SqlConnection(constr);
                    connection1.Open();
                    String sql = $"SELECT Address1,Address2,Address3,City,Postal_Code FROM Delivery_Address WHERE Delivery_ID = '{Session["Delivery_ID"]}' AND ALT_ID = '{Session["ALT"]}'";
                    SqlDataAdapter dataadapter1 = new SqlDataAdapter(sql, connection1);
                    DataSet ds1 = new DataSet();
                    dataadapter1.Fill(ds1, "Delivery_Address");

                    GridDeliv.DataSource = ds1;
                    GridDeliv.DataBind();
                    connection1.Close();

                    LabelDelivaddress.Visible = true;
                    LabelDelivaddress.Text = "Method chosen for item distribution is delivery.";

                }
                else
                {
                    LabelCollect.Visible = true;
                    LabelCollect.Text = "Method chosen for item distribution is Collect or House-call.";
                }

                conn.Close();
            }
        }
        public void customer()
        {
            SqlConnection conn1 = new SqlConnection(constr);
            conn1.Open();
            String sql1 = $"SELECT Cust_Name,Cust_Email FROM Customers WHERE Cust_ID = @cust";
            SqlCommand comm1 = new SqlCommand(sql1, conn1);
            comm1.Parameters.AddWithValue("@cust", Session["cust1"]);
            SqlDataReader readData21 = comm1.ExecuteReader();

            if ((readData21.Read() == true))
            {
                //LabelHeadAdd.Visible = true;
                custome.Text = readData21["Cust_Name"].ToString();
                WelcomeLabel.Text = "Welcome, " + readData21["Cust_Name"] + ". Please confirm if the following are your chosen options..";
                Labemail.Text = readData21["Cust_Email"].ToString();
            }
            conn1.Close();
        }
        public int Outp_ID()
        {
            int rand = new Random().Next(1000, 9999);
            int myProduct = rand;

            return myProduct;
        }


        //public void Checkbook()
        //{
        //    conn = new SqlConnection(constr);
        //    conn.Open();
        //    string housec = "SELECT Cust_ID FROM Bookings WHERE Cust_ID = @Cust";
        //    SqlCommand comm2 = new SqlCommand(housec, conn);
        //    comm2.Parameters.AddWithValue("@Cust", Session["cust1"]);
        //    SqlDataReader readCust1 = comm2.ExecuteReader();

        //    if ((readCust1.Read() == false))
        //    {
        //        LabelNobook.Visible = true;
        //        LabelNobook.Text = "No bookings";
        //    }
        //}

        //public void deliv1()
        //{
        //    conn = new SqlConnection(constr);
        //    conn.Open();
        //    string housec = "SELECT Delivery_ID,Collect FROM Delivery WHERE Delivery_ID = @Del AND Collect = @COL";
        //    SqlCommand comm2 = new SqlCommand(housec, conn);
        //    comm2.Parameters.AddWithValue("@Del", LabelDelivv.Text);
        //    comm2.Parameters.AddWithValue("@COL", "TRUE");
        //    SqlDataReader readCust1 = comm2.ExecuteReader();

        //    if ((readCust1.Read() == true))
        //    {
        //        LabelDelivaddress.Visible = true;
        //        LabelDelivaddress.Text = "Method chosen for item distribution is Collection.";
        //    }
        //}

    }
}