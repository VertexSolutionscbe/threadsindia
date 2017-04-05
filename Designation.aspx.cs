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
        bindgridview();
    }
    private void bindgridview()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        string query = "DesignationGrid";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

      //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
       //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM DesignationMaster WHERE DesignationName ='" + txtval2.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
           // Label1.Text = "This designation is already added!";
            string message = "This designation is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && txtval2.Text != "")
        {
            string query = "InsertDesignation";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
            // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
            cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
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
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

       
        da.SelectCommand = new SqlCommand("SELECT * FROM DesignationMaster");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //if (Page.IsValid)
        //{
        //    // Implement your logic to perform action..  
        //    Button4_Click(txtval2.Text);
        //}  
        if (Session["mysession"] != null)
        {
            SqlConnection conn = new SqlConnection(connectstringweb);
            conn.Open();
            string query = "DesignationDelete";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@name", txtname.Text);
            //cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@DesignationCode", Session["mysession"].ToString());
            cmd.ExecuteNonQuery();
            Response.Write("Delete successsfully");
            conn.Close();
            bindgridview();
            txtval2.Text = "";
            
            Session.Remove("mysession");
        }
        else
        {
            Response.Write("Session is expired please click again select button");
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow gr = GridView1.SelectedRow;
        txtval2.Text = (gr.FindControl("Label3") as Label).Text;
        Session["mysession"] = (gr.FindControl("hfid") as HiddenField).Value;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (txtval2.Text == string.Empty)
        {
            CustomValidator1.ErrorMessage = "Please enter your Designation.";
            args.IsValid = false;
        } 
    }
}