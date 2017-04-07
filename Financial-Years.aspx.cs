using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Financial_Years : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    
    
    {
        if (CheckBox1.Checked == true)
        {
            Label6.Text = "active";
            SqlConnection conn = new SqlConnection(connectstringweb);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
            //   da.SelectCommand = new SqlCommand(strSQL);
            da.SelectCommand = new SqlCommand("SELECT * FROM financialyear WHERE ID ='" + FinancialID.Text + "'");
            da.SelectCommand.Connection = conn;
            da.Fill(dt);

            if (dt.Rows.Count > 0) // Means Student Id is already present
            {
                // Label1.Text = "This designation is already added!";
                string message = "This designation is already added!')";
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            }
            else if (dt.Rows.Count == 0 && txtval1.Text != "" && txtval2.Text != "" && txtval3.Text != "" && txtval4.Text != "" && Label6.Text != "")
            {
                string query = "InsertFinancialYear";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@STARTDATE", txtval1.Text);
                cmd.Parameters.AddWithValue("@ENDDATE", txtval2.Text);
                cmd.Parameters.AddWithValue("@FINANCIALYEAR", txtval3.Text);
                cmd.Parameters.AddWithValue("@REMARKS", txtval4.Text);
                cmd.Parameters.AddWithValue("@ISACTIVE", Label6.Text);
                cmd.ExecuteNonQuery();
                // Response.Write("Record inserted successsfully");
                string message = "Record inserted successsfully";

                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
                conn.Close();
                //bindgridview();

            }


        }
        else if(CheckBox1.Checked==false)
        {
            Label6.Text = "inactive";
            SqlConnection conn1 = new SqlConnection(connectstringweb);
            conn1.Open();

            SqlDataAdapter da1 = new SqlDataAdapter();
            DataTable dt1 = new DataTable();

            //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
            //   da.SelectCommand = new SqlCommand(strSQL);
            da1.SelectCommand = new SqlCommand("SELECT * FROM financialyear WHERE ID ='" + FinancialID.Text + "'");
            da1.SelectCommand.Connection = conn1;
            da1.Fill(dt1);

            if (dt1.Rows.Count > 0) // Means Student Id is already present
            {
                // Label1.Text = "This designation is already added!";
                string message = "This designation is already added!')";
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
            }
            else if (dt1.Rows.Count == 0 && txtval1.Text != "" && txtval2.Text != "" && txtval3.Text != "" && txtval4.Text != "" && Label6.Text != "")
            {
                string query1 = "InsertFinancialYear";
                SqlCommand cmd1 = new SqlCommand(query1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@STARTDATE", txtval1.Text);
                cmd1.Parameters.AddWithValue("@ENDDATE", txtval2.Text);
                cmd1.Parameters.AddWithValue("@FINANCIALYEAR", txtval3.Text);
                cmd1.Parameters.AddWithValue("@REMARKS", txtval4.Text);
                cmd1.Parameters.AddWithValue("@ISACTIVE", Label6.Text);
                cmd1.ExecuteNonQuery();
                // Response.Write("Record inserted successsfully");
                string message = "Record inserted successsfully";

                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
                conn1.Close();
                //bindgridview();

            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtval1.Text = "";
        txtval2.Text = "";
        txtval3.Text = "";
        txtval4.Text = "";
        txtval5.Text = "";
      
    }
}
