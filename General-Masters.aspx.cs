using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class General_Masters : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    BindContrydropdown();
        //}
        if (!Page.IsPostBack)
        {
            BindContrydropdown();
            //BindContryStatedropdown();
            BindContryStateCitydropdown();
        }  
    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM Country WHERE Country ='" + TextBox1.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This Country is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox1.Text != "" )
        {
            string query = "InsertCountry";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@Country", TextBox1.Text);
          //  cmd.Parameters.AddWithValue("@State", TextBox2.Text);
            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
            //bindgridview();

        }
        //else
        //{
        //    string query = "InsertCountry";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
        //    // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
        //    cmd.Parameters.AddWithValue("@Country", TextBox1.Text);
        //    cmd.Parameters.AddWithValue("@State", TextBox2.Text);
        //    cmd.ExecuteNonQuery();
        //    // Response.Write("Record inserted successsfully");
        //    string message = "Record inserted successsfully";

        //    ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        //    conn.Close();
        //}
    }

    protected void BindContrydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select CountryCode,Country from country", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;
        
        DropDownList1.DataTextField = "Country";
        DropDownList1.DataValueField = "CountryCode";
        DropDownList1.DataBind();
    }
    //protected void BindContryStatedropdown()
    //{

    //    SqlConnection conn = new SqlConnection(connectstringweb);
    //    conn.Open();

    //    SqlCommand cmd = new SqlCommand("select CountryCode,Country from country", conn);
    //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //    DataTable dt = new DataTable();
    //    sda.Fill(dt);
    //    DropDownList1.DataSource = dt;

    //    DropDownList2.DataTextField = "Country";
    //    DropDownList2.DataValueField = "CountryCode";
    //    DropDownList1.DataBind();
    //}
    protected void BindContryStateCitydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("Select country.countrycode,country.country,state.state from country  INNER JOIN state ON country.CountryCode=state.Country", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Country";
        DropDownList2.DataValueField = "CountryCode";
        DropDownList2.DataBind();
        DropDownList3.DataSource = dt;

        DropDownList3.DataTextField = "State";
        DropDownList3.DataValueField = "state";
        DropDownList3.DataBind();
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        //int CountryCode = Convert.ToInt32(ddlCountry.SelectedValue);
        //SqlConnection conn = new SqlConnection(connectstringweb);
        //conn.Open();
        //SqlCommand cmd = new SqlCommand("select * from Country where CountryCode=" + CountryCode, conn);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //conn.Close();
        //ddlState.DataSource = ds;
        //ddlState.DataTextField = "State";
        //ddlState.DataValueField = "CountryCode";
        //ddlState.DataBind();
        //ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        //if(ddlState.SelectedValue=="0")
        //{
        //ddlRegion.Items.Clear();
        //ddlRegion.Items.Insert(0, new ListItem("--Select--", "0"));
        //    }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    //protected void Button1_Click1(object sender, EventArgs e)
    //{
    //    SqlConnection conn = new SqlConnection(connectstringweb);
    //    conn.Open();

    //    SqlDataAdapter da = new SqlDataAdapter();
    //    DataTable dt = new DataTable();

    //    //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
    //    //   da.SelectCommand = new SqlCommand(strSQL);
    //    da.SelectCommand = new SqlCommand("SELECT * FROM country WHERE Country ='" + TextBox1.Text + "'");
    //    da.SelectCommand.Connection = conn;
    //    da.Fill(dt);

    //    if (dt.Rows.Count > 0) // Means Student Id is already present
    //    {
    //        // Label1.Text = "This designation is already added!";
    //        string message = "This Country is already added!')";
    //        ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
    //    }
    //    else if (dt.Rows.Count == 0 && TextBox1.Text != "" )
    //    {
    //        string query = "InsertCountry";
    //        SqlCommand cmd = new SqlCommand(query, conn);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
    //        // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
    //        cmd.Parameters.AddWithValue("@Country", TextBox1.Text);
           
    //        cmd.ExecuteNonQuery();
    //        // Response.Write("Record inserted successsfully");
    //        string message = "Record inserted successsfully";

    //        ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
    //        conn.Close();
    //        //bindgridview();

    //    }
    //    else
    //    {

    //    }
    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select CountryCode,Country from country", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();
        DropDownList1.DataTextField = "Country";
        DropDownList1.DataValueField = "CountryCode";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM State WHERE State ='" + TextBox2.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This Country is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox2.Text != "")
        {
            string query = "InsertState";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@Country", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@State", TextBox2.Text);

            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
            //bindgridview();

        }
        else
        {

        }
    }
    protected void Button_Click8(object sender, EventArgs e)
    {
        
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM City WHERE City ='" + TextBox3.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This City is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox3.Text != "")
        {
            string query = "InsertCity";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@Country", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@State", DropDownList3.Text);
            cmd.Parameters.AddWithValue("@City", TextBox3.Text);
            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
            //bindgridview();

        }
        else
        {

        }
    }


    protected void Button10_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM currencymaster WHERE CurrencyCode ='" + currencycode.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This Currency is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox6.Text != "" && TextBox7.Text!="")
        {
            string query = "InsertCurrency";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@Currency", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Description", TextBox7.Text);
          
            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
            //bindgridview();

        }
        else
        {

        }
    }
}