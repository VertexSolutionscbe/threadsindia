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
        BindCitydropdown();
        BindPartydropdown();
        BindStatedropdown();
    }
    protected void BindCitydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select CityCode,City from City", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "City";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList2.DataBind();
        conn.Close();
    }

    protected void BindStatedropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("select StateCode,State from State", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList4.DataSource = dt;

        DropDownList4.DataTextField = "State";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList4.DataBind();
        conn.Close();
    }

    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select partycategorycode,PartyCategory from partycategory", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "PartyCategory";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList1.DataBind();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM partycategorymaster WHERE Party =@Party", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Party", this.TextBox2.Text.Trim());



        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Party is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (TextBox2.Text != "")
        {
            string query = "InsertPartyMaster";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@Party", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@Salution", DropDownList3.SelectedValue);
            cmd1.Parameters.AddWithValue("@ControlAccount", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@Tin", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@TinDate", TextBox7.Text);
            cmd1.Parameters.AddWithValue("@PartyType", DropDownList5.SelectedValue);
            cmd1.Parameters.AddWithValue("@CreditLimit", TextBox10.Text);
            cmd1.Parameters.AddWithValue("@CreditDays", TextBox11.Text);
            cmd1.Parameters.AddWithValue("@Transactdet", TextBox13.Text);
            cmd1.Parameters.AddWithValue("@CST", TextBox14.Text);
            cmd1.Parameters.AddWithValue("@Introduced", DropDownList6.SelectedValue);
            cmd1.Parameters.AddWithValue("@Represent", TextBox17.Text);
            cmd1.Parameters.AddWithValue("@IFSC", TextBox19.Text);
            cmd1.Parameters.AddWithValue("@Website", TextBox20.Text);
            cmd1.Parameters.AddWithValue("@Address", TextBox21.Text);
            cmd1.Parameters.AddWithValue("@city", DropDownList2.SelectedValue);
            cmd1.Parameters.AddWithValue("@WindingCode", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@Pincode", TextBox5.Text);
            cmd1.Parameters.AddWithValue("@State", DropDownList4.SelectedValue);
            cmd1.Parameters.AddWithValue("@Email", TextBox8.Text);
            cmd1.Parameters.AddWithValue("@Phone", TextBox9.Text);
            cmd1.Parameters.AddWithValue("@Mobile", TextBox12.Text);
            cmd1.Parameters.AddWithValue("@PAN", TextBox15.Text);
            cmd1.Parameters.AddWithValue("@Bank", TextBox16.Text);
            cmd1.Parameters.AddWithValue("@BankAccNo", TextBox18.Text);
            cmd1.Parameters.AddWithValue("@Remarks", TextBox21.Text);
           
          
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
}