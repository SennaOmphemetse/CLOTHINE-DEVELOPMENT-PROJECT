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
    public partial class FORGOTPFORM : System.Web.UI.Page
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
        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            if (TextEmail.Text == TextEmail2.Text)
            {
                try
                {
                    String passWord;
                    string conv = TextEmail.Text.ToLower();

                    conn = new SqlConnection(constr);
                    conn.Open();

                    String sql = "SELECT Cust_passw FROM Customers WHERE Cust_Email = @username ";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@username", conv);
                    readData = comm.ExecuteReader();

                    if ((readData.Read() == true))
                    {

                        passWord = readData["Cust_passw"].ToString();
                        SendMyPassW(passWord, conv);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Your Password has been sent to the registered Email....Check your Inbox or Spam!!!!');", true);
                        //Response.Write("Your Password has been sent to the registered Email....Check your Inbox or Spam!!!!");
                        Response.Redirect("SignIn.aspx");
                    }
                    else 
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Your Email Address is invalid!!!!...Try again!!');", true);
                        erroLab.Visible = true;
                        erroLab.Text = "Your Email Address is invalid!!!!...Try again!!";
                        //Response.Write("Your Email Address is invalid!!!!...Try again");
                    }

                    conn.Close();
                    
                }
                catch (SqlException error)
                {
                    erroLab.Visible = true;
                    erroLab.Text = error.Message;

                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Emails don't match!!!');", true);
                erroLab.Text = "Emails don't match!!!";
                erroLab.Visible = true;
            }
        }
        private void SendMyPassW(string passWord, String email)
        {

            MailMessage newMail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            string addressFrom = "Dirang ka Natla Administartion<kanatladirang@gmail.com>";
            newMail.From = new MailAddress(addressFrom, "SENDER-NAME");

            newMail.To.Add(email);
            newMail.Subject = "PASSWORD RECOVERY";

            newMail.IsBodyHtml = true; newMail.Body = "Dear client," + "\nYour password is " + passWord + "make sure u protect it...." + "\nThank you...";

            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Port = 587;
            
            client.Credentials = new System.Net.NetworkCredential("kanatladirang@gmail.com", "DirangKT@95196");

            client.Send(newMail);
            Console.WriteLine("Email Sent");


        }

        public string Decryption(string Decrypting)
        {
            string decrypt;

            try
            {
                byte[] al = Convert.FromBase64String(Decrypting);
                decrypt = System.Text.ASCIIEncoding.ASCII.GetString(al);
            }
            catch (SqlException error)
            {
                //kanatladirang@gmail.com", "DirangKT@95196"
                decrypt = "";
            }
            return decrypt;
        }
    }
}