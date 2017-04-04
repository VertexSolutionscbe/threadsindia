using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Designation : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        string query = "InsertEmployee";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
       // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
       // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
        cmd.Parameters.AddWithValue("@Name", txtval2.Text);
        cmd.ExecuteNonQuery();
        Response.Write("Record inserted successsfully");
        conn.Close();
        //bindgridview();
        //txtname.Text = "";
        //txtemail.Text = "";

       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write("Record inserted successsfully");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}