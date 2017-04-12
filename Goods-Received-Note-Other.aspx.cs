using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Gooda_Received_Note_Other : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindLocationdropdown();
        BindPartydropdown();
        BindItemdropdown();
        BindUnitdropdown();
        //SqlConnection con = new SqlConnection(connectstringweb);

        //SqlCommand cmd = new SqlCommand("select count(*) from orderindent", con); ;



        //con.Open();

        //count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        //TextBox1.Text = "Doc00" + count;

        //con.Close();
    }
    protected void BindLocationdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select LocationCode,LocationName from locationmaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList3.DataSource = dt;

        DropDownList3.DataTextField = "LocationName";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList3.DataBind();
    }

    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select Category,Party from partycategorymaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Party";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList2.DataBind();
    }


    protected void BindItemdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select GroupID,ItemGroup from ItemGroupMaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "ItemGroup";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList1.DataBind();
    }
    protected void BindUnitdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select UnitCode,Unit from unit", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList4.DataSource = dt;

        DropDownList4.DataTextField = "Unit";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList4.DataBind();
    }
}