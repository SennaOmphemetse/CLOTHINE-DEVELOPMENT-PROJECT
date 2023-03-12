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
    public partial class SERVICESFORM : System.Web.UI.Page
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
            if (Session["cust"] != null)
            {
                LabeCust.Text = Session["cust"].ToString();
            }
            
            Session["cust1"] = LabeCust.Text;

            Service_ID();
            Session["Services"] = Service_ID();

            conn = new SqlConnection(constr);
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            Session["Services"] = Service_ID();
            Session["cust1"] = LabeCust.Text;
            const int takkie = 50;
            const int clothes = 50;
            const int blankets = 75;
            const int curtain = 50;

            int amount = 0;

            int tak = DropTakkies.SelectedIndex;
            int price1 = tak * takkie;

            int clo = DropClothes.SelectedIndex;
            int price2 = clo * clothes;

            int bla = DropBlanket.SelectedIndex;
            int price3 = bla * blankets;

            int cur = DropCurtains.SelectedIndex;
            int price4 = cur * curtain;


            amount = price1 + price2 + price3 + price4;
            int total = amount;

            try
            {

                if (cbTakkie.Checked && cbClothes.Checked && cbBlanket.Checked && cbCurtains.Checked)
                {


                    if (tak > 0 && clo > 0 && bla > 0 && cur > 0)
                    {




                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{1}','{clo}','{1}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }

                }
                else if (cbTakkie.Checked == false && cbClothes.Checked && cbBlanket.Checked && cbCurtains.Checked)
                {
                    if (tak == 0 && clo > 0 && bla > 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{0}','{clo}','{1}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked == false && cbBlanket.Checked && cbCurtains.Checked)
                {
                    if (tak > 0 && clo == 0 && bla > 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{1}','{clo}','{0}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked && cbBlanket.Checked == false && cbCurtains.Checked)
                {
                    if (tak > 0 && clo > 0 && bla == 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{1}','{clo}','{0}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked && cbBlanket.Checked && cbCurtains.Checked == false)
                {
                    if (tak > 0 && clo > 0 && bla > 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{1}','{clo}','{1}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked == false && cbBlanket.Checked && cbCurtains.Checked)
                {
                    if (tak == 0 && clo == 0 && bla > 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{0}','{clo}','{1}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked && cbBlanket.Checked == false && cbCurtains.Checked)
                {
                    if (tak == 0 && clo > 0 && bla == 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{1}','{clo}','{0}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked && cbBlanket.Checked && cbCurtains.Checked == false)
                {
                    if (tak == 0 && clo > 0 && bla > 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{1}','{clo}','{1}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked == false && cbBlanket.Checked == false && cbCurtains.Checked)
                {
                    if (tak > 0 && clo == 0 && bla == 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{0}','{clo}','{0}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked == false && cbBlanket.Checked && cbCurtains.Checked == false)
                {
                    if (tak > 0 && clo == 0 && bla > 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{0}','{clo}','{1}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked && cbBlanket.Checked == false && cbCurtains.Checked == false)
                {
                    if (tak > 0 && clo > 0 && bla == 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{1}','{clo}','{0}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked == false && cbBlanket.Checked == false && cbCurtains.Checked)
                {
                    if (tak == 0 && clo == 0 && bla == 0 && cur > 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{0}','{clo}','{0}','{bla}','{1}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked == false && cbBlanket.Checked && cbCurtains.Checked == false)
                {
                    if (tak == 0 && clo == 0 && bla > 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{0}','{clo}','{1}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked && cbBlanket.Checked == false && cbCurtains.Checked == false)
                {
                    if (tak == 0 && clo > 0 && bla == 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{0}','{tak}','{1}','{clo}','{0}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked && cbClothes.Checked == false && cbBlanket.Checked == false && cbCurtains.Checked == false)
                {
                    if (tak > 0 && clo == 0 && bla == 0 && cur == 0)
                    {
                        conn.Open();

                        SqlCommand AddData = new SqlCommand($"INSERT INTO Services (Service_ID,Cust_ID,Tekkie,Tekkie_num,Clothes,Clothes_num,Blankets,Blankets_num,Curtains,Curtains_num,Total_Amount) VALUES ('{Service_ID()}','{LabeCust.Text}','{1}','{tak}','{0}','{clo}','{0}','{bla}','{0}','{cur}','{total}')", conn);
                        adap = new SqlDataAdapter();
                        dat = new DataSet();

                        adap.SelectCommand = AddData;
                        adap.Fill(dat, "Services");

                        conn.Close();
                        step();

                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Correct number of itmes for selected items.";
                    }
                }
                else if (cbTakkie.Checked == false && cbClothes.Checked == false && cbBlanket.Checked == false && cbCurtains.Checked == false)
                {
                    Label1.Visible = true;
                    Label1.Text = "Please choose Services!!!!";
                }

            }
            catch (Exception error)
            {
                Label1.Visible = true;
                Label1.Text = error.Message;
            }
        }

        public void step()
        {
            conn = new SqlConnection(constr);
            conn.Open();

            String sql = "SELECT Cust_ID,Yes_option FROM HouseCall WHERE Cust_ID = @Cust and Yes_option = @check";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@Cust", LabeCust.Text);
            comm.Parameters.AddWithValue("@check", "True");
            readData = comm.ExecuteReader();

            if ((readData.Read() == true))
            {
                Response.Redirect("OutputForm.aspx");
            }
            else
            {
                Response.Redirect("DeliveryMethod.aspx");
            }
            conn.Close();
        }
        public int Service_ID()
        {
            int rand = new Random().Next(1000, 9999);
            int myProduct = rand;

            return myProduct;
        }
    }
}