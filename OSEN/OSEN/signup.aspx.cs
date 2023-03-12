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
    public partial class REGISTERFORM : System.Web.UI.Page
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
            Customer_ID();
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();

                if (CheckBAgree.Checked)
                {
                    string conv = TexName.Text.ToLower();

                    String sql = "SELECT Cust_Name FROM Customers WHERE Cust_Email = @username";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@username", conv);
                    readData = comm.ExecuteReader();

                    if ((readData.Read() == true))
                    {
                        erroLab.Visible = true;
                        //erroLab.Text = "The Entered Username exists........Try new one!!!!!!";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('The Entered Username exists........Try new one!!!!!!');", true);
                    }
                    else
                    {
                        conn = new SqlConnection(constr);
                        conn.Open();

                        string all = TextEmail.Text.ToLower();
                        if (TextPhone.Text.Length == 10)
                        {
                            SqlCommand AddData = new SqlCommand($"SET IDENTITY_INSERT Customers ON; INSERT INTO Customers (Cust_ID,Cust_Name,Cust_Email,Cust_Cellphone,Cust_passw) VALUES ('{Customer_ID()}','{TexName.Text}','{all}','{TextPhone.Text}','{Encryption(TextPass.Text)}') SET IDENTITY_INSERT Customers OFF;", conn);
                            adap = new SqlDataAdapter();
                            dat = new DataSet();

                            adap.SelectCommand = AddData;
                            adap.Fill(dat, "Customers");

                            //Product_ID(TextEmail.Text);
                            //Response.Write("Successfully registered");

                            conn.Close();

                            Response.Redirect("SignIn.aspx");
                        }
                        else 
                        {
                            erroLab.Visible = true;
                            erroLab.Text = "Invalid Cell-phone number";
                        }

                        
                    }

                }
                else
                {
                    erroLab.Visible = true;
                    erroLab.Text = "Please agree to the rules";
                }


                conn.Close();
            }
            catch (SqlException error)
            {
                erroLab.Visible = true;
                erroLab.Text = error.Message;

            }
        }
        public string Encryption(string Encrypting)
        {
            byte[] al = System.Text.ASCIIEncoding.ASCII.GetBytes(Encrypting);
            string encrypt = Convert.ToBase64String(al);
            return encrypt;
        }

        public String Customer_ID()
        {
            int rand = new Random().Next(100000, 999999);
            String myProduct = rand.ToString();
            
            return myProduct;
        }

        private void Product_ID(String email)
        {
            
            SmtpClient all = new SmtpClient();
            all.Host = "smtp.gmail.com";
            all.Port = 587;

            all.Credentials = new System.Net.NetworkCredential("kanatladirang@gmail.com", "DirangKT@95196");
            all.EnableSsl = true;

            MailMessage messa = new MailMessage();
            messa.Subject = "Account Created";
            messa.Body = "DEAR " + TexName.Text + "\n\nCongradulations for creating an Account." + "\n\nHope you enjoy our services we have. We are looking forward as Osen laundry services to working together and helping one another with ." + "\n\nThank you \n\nBest regards\nDirang Ka Natla";

            string addressTo = TextEmail.Text;
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
    }
}