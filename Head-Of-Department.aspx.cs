using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Head_Of_Department : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindDeptdropdown();
        }
    }
    protected void BindDeptdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select DeptCode,Department from departmentmaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "Department";
        DropDownList1.DataValueField = "DeptCode";
        DropDownList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
               SqlCommand cmd = new SqlCommand("SELECT * FROM department WHERE HOD =@HOD",conn);
        DataSet ds = new DataSet();
        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@HOD", this.TextBox2.Text.Trim());

       
        
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Head Of Department is already added!";
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
            string query = "InsertDept";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@Department", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@HOD", TextBox2.Text);

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


        }
      

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
    }
}