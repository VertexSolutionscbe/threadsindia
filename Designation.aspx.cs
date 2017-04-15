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
        SqlCommand cmd = new SqlCommand("SELECT * FROM DesignationMaster WHERE DesignationName =@DesignationName", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@DesignationName", this.txtval2.Text.Trim());


       
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Designation is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (txtval2.Text != "")
        {
            if (Button2.Text == "Save")
            {
                string query = "InsertDesignation";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd1.Parameters.AddWithValue("@DesignationName", txtval2.Text);
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
            else
            {
                string query = "DesignationUpdate";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd1.Parameters.AddWithValue("@DesignationCode", Label4.Text);
                cmd1.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd1.ExecuteNonQuery();
                // Response.Write("Record inserted successsfully");
                string message = "Record updated successsfully";

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
        Label4.Text = (gr.FindControl("hfid") as HiddenField).Value;
        Button2.Text = "Update";
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