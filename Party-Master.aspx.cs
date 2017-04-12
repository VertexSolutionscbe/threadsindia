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

    }
}