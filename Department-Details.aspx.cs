using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Depoartment_Details : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM departmentmaster WHERE Department =@Department",conn);
        DataSet ds = new DataSet();
        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Department", this.TextBox1.Text.Trim());

       
        //da.SelectCommand = new SqlCommand("SELECT Deptcode FROM departmentmaster WHERE Department =@Department");
        //da.Parameters.AddWithValue("@Department", this.txtName.Text.Trim());
       // da.SelectCommand.Connection = conn;
        da.Fill(ds);

        if (ds.Tables[0]. Rows.Count > 0)
        {
            string message = "This Department is already added!";
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
        else if ( TextBox1.Text != "" )
        {
            string query = "InsertDeptMaster";
           
        SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@Department", TextBox1.Text);
           

            cmd1.ExecuteNonQuery();

            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();


        }
      

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }
}