using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Order_Indent_Precot : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        int count;
        BindPartydropdown();
        BindItemdropdown();
        BindTaxdropdown();

        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from orderindent", con); ;

    

        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        TextBox1.Text = "Doc00" + count;

        con.Close();
    }

    protected void BindTaxdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select TaxCode,TaxPer from TaxTemplate", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList4.DataSource = dt;

        DropDownList4.DataTextField = "TaxPer";
        DropDownList4.DataValueField = "TaxCode";
        DropDownList4.DataBind();
    }
    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select PartyCatMastID,Party from partycategorymaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "Party";
        DropDownList1.DataValueField = "PartyCatMastID";
        DropDownList1.DataBind();
    }

    protected void BindItemdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select ItemGrpCode,Item from ItemGroupDet", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Item";
        DropDownList2.DataValueField = "ItemGrpCode";
        DropDownList2.DataBind();
    }
}