using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Party_Master : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindStatedropdown();
        BindCitydropdown();
        BindSPartydropdown();
    }

    protected void BindSPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        // SqlCommand cmd = new SqlCommand("Select state.State,state.StateCode,state.Country,city.City,city.CityCode from state  INNER JOIN city  ON state.Country=city.Country", conn);
        SqlCommand cmd = new SqlCommand("Select PartyCategory,partycategorycode from partycategory", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "PartyCategory";
        DropDownList1.DataValueField = "partycategorycode";
        DropDownList1.DataBind();
    }
    protected void BindStatedropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        // SqlCommand cmd = new SqlCommand("Select state.State,state.StateCode,state.Country,city.City,city.CityCode from state  INNER JOIN city  ON state.Country=city.Country", conn);
        SqlCommand cmd = new SqlCommand("Select State,StateCode from state", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        DropDownList4.DataSource = dt;

        DropDownList4.DataTextField = "State";
        DropDownList4.DataValueField = "StateCode";
        DropDownList4.DataBind();
    }
    protected void BindCitydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        // SqlCommand cmd = new SqlCommand("Select state.State,state.StateCode,state.Country,city.City,city.CityCode from state  INNER JOIN city  ON state.Country=city.Country", conn);
        SqlCommand cmd = new SqlCommand("Select City,CityCode from City", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "City";
        DropDownList2.DataValueField = "CityCode";
        DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox17.Text = "";
        TextBox18.Text = "";
        TextBox19.Text = "";
        TextBox20.Text = "";
        TextBox21.Text = "";


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM partycategorymaster WHERE PartyCatMastID ='" + TextBox3.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This PartyMater is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox3.Text != "" && TextBox1.Text != "" && TextBox7.Text != "")
        {
            string query = "InsertPartyMater";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Category", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@Party", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Salution ", TextBox3.Text);
            cmd.Parameters.AddWithValue("@ControlAccount", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Tin ", TextBox6.Text);
            cmd.Parameters.AddWithValue("@TinDate", TextBox7.Text);

            cmd.Parameters.AddWithValue("@PartyType", DropDownList5.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", TextBox10.Text);
            cmd.Parameters.AddWithValue("@CreditDays", TextBox11.Text);
            cmd.Parameters.AddWithValue("@Transactdet", TextBox13.Text);
            cmd.Parameters.AddWithValue("@CST", TextBox14.Text);

            cmd.Parameters.AddWithValue("@Introduced", DropDownList6.Text);
            cmd.Parameters.AddWithValue("@Represent", TextBox17.Text);
            cmd.Parameters.AddWithValue("@IFSC", TextBox19.Text);
            cmd.Parameters.AddWithValue("@Website ", TextBox20.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox1.Text);

            cmd.Parameters.AddWithValue("@city ", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@WindingCode ", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Pincode ", TextBox5.Text);
            cmd.Parameters.AddWithValue("@State", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Email ", TextBox8.Text);

            cmd.Parameters.AddWithValue("@Phone ", TextBox9.Text);
            cmd.Parameters.AddWithValue("@Mobile", TextBox12.Text);
            cmd.Parameters.AddWithValue("@PAN ", TextBox15.Text);
            cmd.Parameters.AddWithValue("@Bank ", TextBox16.Text);
            cmd.Parameters.AddWithValue("@BankAccNo", TextBox18.Text);
            cmd.Parameters.AddWithValue("@Remarks", TextBox21.Text);
           

          
            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
           
        }
    }
}