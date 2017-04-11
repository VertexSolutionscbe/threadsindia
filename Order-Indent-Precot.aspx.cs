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

        SqlCommand cmd = new SqlCommand("select ItemGrpCode,Item from Item", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
       sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Item";
        DropDownList2.DataValueField = "ItemGrpCode";
        DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM orderindent WHERE Orderdet =@Orderdet", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Orderdet", this.TextBox3.Text.Trim());



        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Designation is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (TextBox1.Text!="" && TextBox2.Text!="" &&   TextBox3.Text != "" )
        {
            string query = "InsertOrderIndent";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@DocId", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@DocDate", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@Tax", DropDownList4.SelectedValue);
            cmd1.Parameters.AddWithValue("@Item", DropDownList2.SelectedValue);
            cmd1.Parameters.AddWithValue("@Pay", DropDownList3.SelectedValue);
            cmd1.Parameters.AddWithValue("@Party", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@Orderdet", TextBox3.Text);
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