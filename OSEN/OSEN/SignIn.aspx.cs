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
    public partial class LOGINFORM : System.Web.UI.Page
    {
        //database
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public SqlDataReader readData;
        public SqlDataReader readCust;
        public DataSet dat;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Omphe\OneDrive\Documents\c#projects\OSEN\OSEN\App_Data\Laundry.mdf;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            TextName.Focus();
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(constr);
                conn.Open();
                string conv = TextName.Text.ToLower();

                String sql = "SELECT Cust_Email,Cust_passw,Cust_ID FROM Customers WHERE Cust_Email = @username AND Cust_passw = @password";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@username", conv);
                comm.Parameters.AddWithValue("@password", Encryption(TextPass.Text));
                readData = comm.ExecuteReader();

                if ((readData.Read() == true))
                {
                    HttpCookie Remember = new HttpCookie("LoginStatus");

                    conn = new SqlConnection(constr);
                    conn.Open();


                    //hold the cookie
                    LabelCust.Text = readData["Cust_ID"].ToString();
                    Remember["Cust_ID"] = LabelCust.Text;
                    Session["customer"] = readData["Cust_ID"].ToString();

                    string housec = "SELECT Cust_ID FROM HouseCall WHERE Cust_ID = @Cust";
                    SqlCommand comm2 = new SqlCommand(housec, conn);
                    comm2.Parameters.AddWithValue("@Cust", LabelCust.Text);
                    readCust = comm2.ExecuteReader();

                    if ((readCust.Read() == true))
                    {
                        Remember.Expires = DateTime.Now.AddMinutes(10);

                        if (CheckBRemem.Checked)
                        {
                            Remember["name"] = "Welcome[" + TextName.Text + "]";
                            Remember.Expires = DateTime.Now.AddDays(2);
                        }
                        else
                        {
                            Remember.Expires = DateTime.Now.AddMinutes(10);
                        }

                        Response.Cookies.Add(Remember);

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully logged in');", true);
                        Response.Redirect("Continue.aspx");
                    }
                    else
                    {
                        Session["customer"] = readData["Cust_ID"].ToString();
                        Remember.Expires = DateTime.Now.AddMinutes(10);

                        if (CheckBRemem.Checked)
                        {
                            Remember.Expires = DateTime.Now.AddDays(2);
                        }
                        else
                        {
                            Remember.Expires = DateTime.Now.AddMinutes(10);
                        }
                        Response.Cookies.Add(Remember);

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully logged in');", true);
                        Response.Redirect("HouseCall.aspx");

                    }
                    conn.Close();

                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Invalid Username or Password!!!');", true);
                    //Errormess.Visible = true;
                    //Errormess.Text = "Invalid Username or Password!!!";
                }

                conn.Close();

            }
            catch (SqlException error)
            {
                Errormess.Visible = true;
                Errormess.Text = error.Message;

            }
        }
        public string Encryption(string Encrypting)
        {
            byte[] al = System.Text.ASCIIEncoding.ASCII.GetBytes(Encrypting);
            string encrypt = Convert.ToBase64String(al);
            return encrypt;
        }
    }
}