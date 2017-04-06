using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Company : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindCurrencydropdown();
        BindYeardropdown();
        BindCountrydropdown();
    }
    protected void BindCurrencydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select CurrencyCode,Currency from currencymaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Currency";
        DropDownList2.DataValueField = "CurrencyCode";
        DropDownList2.DataBind();
    }

    protected void BindYeardropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select YEARID,FINANCIALYEAR from financialyear", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "FINANCIALYEAR";
        DropDownList1.DataValueField = "YEARID";
        DropDownList1.DataBind();
    }
    protected void BindCountrydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select CountryCode,Country from Country", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList3.DataSource = dt;

        DropDownList3.DataTextField = "Country";
        DropDownList3.DataValueField = "CountryCode";
        DropDownList3.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM Company WHERE companycode ='" + lblcompanycode.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (CheckBox1.Checked == true)
        {
            lblcheck.Text = "active";
            if (dt.Rows.Count > 0) // Means Student Id is already present
            {
                // Label1.Text = "This designation is already added!";
                string message = "This Country is already added!')";
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            }
            else if (dt.Rows.Count == 0 && TextBox2.Text != "" && TextBox10.Text != "" && TextBox3.Text != ""  && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox11.Text != "" && lblcheck.Text != "")
            {
                string query = "InsertCompany";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd.Parameters.AddWithValue("@companyname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@address", TextBox3.Text);
                cmd.Parameters.AddWithValue("@COUNTRY", DropDownList3.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox7.Text);
                cmd.Parameters.AddWithValue("@MOBILE", TextBox8.Text);
                cmd.Parameters.AddWithValue("@EMAIL", TextBox9.Text);
                cmd.Parameters.AddWithValue("@WEB", TextBox3.Text);
                cmd.Parameters.AddWithValue("@CURRENCY", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@TIN", TextBox5.Text);
                cmd.Parameters.AddWithValue("@CST", TextBox6.Text);
                cmd.Parameters.AddWithValue("@PAN", TextBox11.Text);
                cmd.Parameters.AddWithValue("@YEAR", DropDownList2.Text);
                cmd.Parameters.AddWithValue("@ISACTIVE", lblcheck.Text);
                cmd.ExecuteNonQuery();
                // Response.Write("Record inserted successsfully");
                string message = "Record inserted successsfully";

                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
                conn.Close();
                //bindgridview();
            }
        }
        else if (CheckBox1.Checked == false)
        {
            lblcheck.Text = "inactive";
            if (dt.Rows.Count > 0) // Means Student Id is already present
            {
                // Label1.Text = "This designation is already added!";
                string message = "This Country is already added!')";
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            }
            else if (dt.Rows.Count == 0 && TextBox2.Text != "" && TextBox10.Text != "" && TextBox3.Text != "" &&   TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox11.Text != "" && lblcheck.Text != "")
            {
                string query = "InsertCompany";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd.Parameters.AddWithValue("@companyname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@address", TextBox3.Text);
                cmd.Parameters.AddWithValue("@COUNTRY", DropDownList3.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox7.Text);
                cmd.Parameters.AddWithValue("@MOBILE", TextBox8.Text);
                cmd.Parameters.AddWithValue("@EMAIL", TextBox9.Text);
                cmd.Parameters.AddWithValue("@WEB", TextBox3.Text);
                cmd.Parameters.AddWithValue("@CURRENCY", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@TIN", TextBox5.Text);
                cmd.Parameters.AddWithValue("@CST", TextBox6.Text);
                cmd.Parameters.AddWithValue("@PAN", TextBox11.Text);
                cmd.Parameters.AddWithValue("@YEAR", DropDownList2.Text);
                cmd.Parameters.AddWithValue("@ISACTIVE", lblcheck.Text);
                cmd.ExecuteNonQuery();
                // Response.Write("Record inserted successsfully");
                string message = "Record inserted successsfully";

                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
                conn.Close();
                //bindgridview();
            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
TextBox2.Text = ""; 
        TextBox10.Text = "" ;
        TextBox3.Text = "" ; 
        TextBox7.Text = "";
        TextBox8.Text = "" ;
        TextBox9.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox11.Text = "";
    }
}