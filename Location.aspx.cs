using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Location : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox3.Text = "";
        TextBox7.Text = "";
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM locationmaster WHERE LocationName ='" + TextBox3.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This LocationName is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox3.Text != "" && TextBox1.Text != "" && TextBox7.Text != "")
        {
            string query = "InsertLocation";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@LocationType", TextBox1.Text);
            cmd.Parameters.AddWithValue("@LocationName", TextBox3.Text);
            cmd.Parameters.AddWithValue("@LocationAddress", TextBox7.Text);
            //cmd.Parameters.AddWithValue("@isactive", CheckBox1.Checked);
            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted successsfully");
            string message = "Record inserted successsfully";

            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            conn.Close();
            //bindgridview();

        }
        else
        {

        }
    }
}