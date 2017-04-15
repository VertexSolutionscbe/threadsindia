using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Winding_Partywise_Rate : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindPartydropdown();
        BindReceivetubedropdown();
    }

    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select PartyCatMastID,Party from partycategorymaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "Party";
        // DropDownList1.DataValueField = "Taxcode";
        DropDownList1.DataBind();
    }

    protected void BindReceivetubedropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select ReceiveTubeCode,ReceiveTube from ReceiveTube", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "ReceiveTube";
        // DropDownList1.DataValueField = "Taxcode";
        DropDownList2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM windingpartywise WHERE Party =@Party And Receivedtube=@ReceiveTube", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Party", DropDownList1.Text.Trim());
        cmd.Parameters.AddWithValue("@ReceiveTube", DropDownList2.Text.Trim());

       
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Party is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (TextBox3.Text != "")
        {
            if (Button1.Text == "Save")
            {
                string query = "InsertWindingpartyrate";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Party", DropDownList1.Text);
                cmd1.Parameters.AddWithValue("@ReceiveTube", DropDownList2.Text);
                cmd1.Parameters.AddWithValue("@Rate", TextBox3.Text);
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
                string query = "WindingPartyUpdate";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd1.Parameters.AddWithValue("@Party", DropDownList1.Text);
                cmd1.Parameters.AddWithValue("@ReceiveTube", DropDownList2.Text);
                cmd1.Parameters.AddWithValue("@Rate", TextBox3.Text);
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

    }
}