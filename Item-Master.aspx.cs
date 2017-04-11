using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Item_Master : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindItemdropdown();
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
        DropDownList1.DataValueField = "GroupID";
        DropDownList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        if (itemChk.Checked == true)
        {
            itemLbl.Text = "active";


            SqlCommand cmd = new SqlCommand("SELECT * FROM ItemGroupDet WHERE ItemGroupName =@ItemGroupName",conn);
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@ItemGroupName", this.TextBox1.Text.Trim());
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string message = "This Item  is already added!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());



            }
            else if (TextBox1.Text != "")
            {
                string query = "InsertShadeNo";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.AddWithValue("@ItemGroupName", DropDownList1.SelectedValue);
                cmd1.Parameters.AddWithValue("@Item", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@Description", TextBox2.Text);
                cmd1.Parameters.AddWithValue("@ItemCode", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@Active", itemLbl.Text);
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
               

            }
            
            }
        else
        {
            itemLbl.Text = "Inactive";


            SqlCommand cmd1 = new SqlCommand("SELECT * FROM ItemGroupDet WHERE ItemGroupName =@ItemGroupName", conn);
            DataSet ds1 = new DataSet();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            cmd1.Parameters.AddWithValue("@ItemGroupName", this.TextBox1.Text.Trim());



            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                string message = "This Item  is already added!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());



            }
            else if (TextBox1.Text != "")
            {
                string query = "InsertShadeNo";
                SqlCommand cmd2 = new SqlCommand(query, conn);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.AddWithValue("@ItemGroupName", DropDownList1.SelectedValue);
                cmd2.Parameters.AddWithValue("@Item", TextBox1.Text);
                cmd2.Parameters.AddWithValue("@Description", TextBox2.Text);
                cmd2.Parameters.AddWithValue("@ItemCode", TextBox3.Text);
                cmd2.Parameters.AddWithValue("@Active", itemLbl.Text);
                cmd2.ExecuteNonQuery();
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


            }
            conn.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}