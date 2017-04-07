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

        //SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE Country =@Country", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Country", this.TextBox1.Text.Trim());



        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Country is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());


            
        }

        else if (TextBox1.Text != "" )
        {
            string query = "InsertCountry";
            SqlCommand cmd0 = new SqlCommand(query, conn);
            cmd0.CommandType = CommandType.StoredProcedure;
           
            cmd0.Parameters.AddWithValue("@Country", TextBox1.Text);
          //  cmd.Parameters.AddWithValue("@State", TextBox2.Text);
            cmd0.ExecuteNonQuery();

            string message = "Record inserted successsfully";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            conn.Close();
            //bindgridview();

        }
        
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
        
       
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    
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

        SqlCommand cmd = new SqlCommand("SELECT * FROM State WHERE State =@State", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@State", this.TextBox2.Text.Trim());


        
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This State is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());


            //string display = "This Department is already added!')";
            //ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", display, true);
        }

        else if ( TextBox2.Text != "")
        {
            string query = "InsertState";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd1.Parameters.AddWithValue("@Country", DropDownList1.Text);
            cmd1.Parameters.AddWithValue("@State", TextBox2.Text);

            cmd1.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
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

        SqlCommand cmd = new SqlCommand("SELECT * FROM City WHERE City =@City", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@City", this.TextBox3.Text.Trim());


      
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This City is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());


          
        }

        else if ( TextBox3.Text != "")
        {
            string query = "InsertCity";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;
          
            cmd1.Parameters.AddWithValue("@Country", DropDownList2.Text);
            cmd1.Parameters.AddWithValue("@State", DropDownList3.Text);
            cmd1.Parameters.AddWithValue("@City", TextBox3.Text);
            cmd1.ExecuteNonQuery();
           
            string message = "Record inserted successsfully!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

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

        SqlCommand cmd = new SqlCommand("SELECT * FROM currencymaster WHERE currency =@currency", conn);
        DataSet ds = new DataSet();
        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@currency", this.TextBox6.Text.Trim());

       
        //da.SelectCommand = new SqlCommand("SELECT Deptcode FROM departmentmaster WHERE Department =@Department");
        //da.Parameters.AddWithValue("@Department", this.txtName.Text.Trim());
       // da.SelectCommand.Connection = conn;
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Currency is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }

        else if (TextBox6.Text != "" && TextBox7.Text != "")
        {
            string query = "InsertCurrency";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@Currency", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@Description", TextBox7.Text);

            cmd1.ExecuteNonQuery();

            string message = "Record inserted successsfully!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

            conn.Close();
            //bindgridview();

        }
        else
        {

        }
    }
}