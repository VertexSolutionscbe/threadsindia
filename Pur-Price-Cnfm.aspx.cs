using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Pur_Price_Cnfm : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindOrderHalfdropdown();
        BindItemdropdown();
        int count;
        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from orderindent", con); ;



        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

     //   DropDownList1.Text = "PCP#0001" + count;
        TextBox2.Text = "PCP0001" + count;

        con.Close();
    }

    protected void BindOrderHalfdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

      //  SqlCommand cmd = new SqlCommand("select Ordhalfid,orderhalf from orderhalf", conn);
        SqlCommand cmd = new SqlCommand("select orderhalf from orderhalf", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "orderhalf";
      //  DropDownList2.DataValueField = "Ordhalfid";
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
        DropDownList3.DataSource = dt;

        DropDownList3.DataTextField = "ItemGroup";
        DropDownList3.DataValueField = "GroupID";
        DropDownList3.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM priceconfirm WHERE OrderHalf =@OrderHalf", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    cmd.Parameters.AddWithValue("@DocId", this.TextBox2.Text.Trim());
        cmd.Parameters.AddWithValue("@OrderHalf", DropDownList2.SelectedValue);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Price is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (TextBox1.Text != "" && TextBox2.Text != "" )
        {
            string query = "InsertPriceCon";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@DocId", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@OrderHalf", DropDownList2.SelectedValue);
            cmd1.Parameters.AddWithValue("@CountName", DropDownList3.SelectedValue);
            cmd1.Parameters.AddWithValue("@Date", TextBox1.Text);
            
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