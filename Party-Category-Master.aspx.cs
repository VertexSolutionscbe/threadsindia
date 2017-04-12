using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Customer_Category_Master : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM partycategory WHERE   partycategory='"+TextBox1.Text+"'", conn);
        
        DataSet dt = new DataSet ();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
      //  cmd.Parameters.AddWithValue("@partycategorycode", this.TextBox2.Text.Trim());
        cmd.Parameters.AddWithValue("@partycategory", this.TextBox1.Text.Trim());
        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
       // da.SelectCommand = new SqlCommand("SELECT * FROM partycategory WHERE partycategorycode ='" + TextBox2.Text + "'");
       // da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Tables[0].Rows.Count > 0) // Means Student Id is already present
        {
            // Label1.Text = "This designation is already added!";
            string message = "This Party Category is already added!')";
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
            string query = "Insertpartycategory";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@PartyCategory", TextBox1.Text);


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
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        
    }
}