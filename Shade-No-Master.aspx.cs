using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Shade_No_Master : System.Web.UI.Page
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        if (ShadChk.Checked == true)
        {
            itemLbl.Text = "active";


            SqlCommand cmd = new SqlCommand("SELECT * FROM ShadeNoMaster WHERE ShadeNo =@ShadeNo", conn);
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@ShadeNo", this.TextBox1.Text.Trim());
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

                
                cmd1.Parameters.AddWithValue("@ShadeNo", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@MinLevelkg", TextBox2.Text);
                cmd1.Parameters.AddWithValue("@MaxLevelkg", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@MinLevelPcs", TextBox4.Text);
                cmd1.Parameters.AddWithValue("@MaxLevelPcs", TextBox5.Text);
                cmd1.Parameters.AddWithValue("@Color", TextBox6.Text);
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


            SqlCommand cmd1 = new SqlCommand("SELECT * FROM ShadeNoMaster WHERE ShadeNo =@ShadeNo", conn);
            DataSet ds1 = new DataSet();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            cmd1.Parameters.AddWithValue("@ShadeNo", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@MinLevelkg", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@MaxLevelkg", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@MinLevelPcs", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@MaxLevelPcs", TextBox5.Text);
            cmd1.Parameters.AddWithValue("@Color", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@Active", itemLbl.Text);
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
                cmd2.Parameters.AddWithValue("@ShadeNo", TextBox1.Text);
                cmd2.Parameters.AddWithValue("@MinLevelkg", TextBox2.Text);
                cmd2.Parameters.AddWithValue("@MaxLevelkg", TextBox3.Text);
                cmd2.Parameters.AddWithValue("@MinLevelPcs", TextBox4.Text);
                cmd2.Parameters.AddWithValue("@MaxLevelPcs", TextBox5.Text);
                cmd2.Parameters.AddWithValue("@Color", TextBox6.Text);
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
}