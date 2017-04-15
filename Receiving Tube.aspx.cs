using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Winding_Tube : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM ReceiveTube WHERE ReceiveTube ='" + txtval2.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {

            string message = "This Receive is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
        else if (dt.Rows.Count == 0 && txtval2.Text != "")
        {
            string query = "InsertReceivetube";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ReceiveTube", txtval2.Text);
          //  cmd.Parameters.AddWithValue("@Tax", DropDownList1.Text.ToString());
           
            cmd.ExecuteNonQuery();

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
    }
}