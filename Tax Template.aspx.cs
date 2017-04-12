using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Tax_Template : System.Web.UI.Page
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
        string query = "TaxGrid";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM TaxTemplate WHERE TaxPer ='" + TextBox1.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {
         
            string message = "This Tax is already added!')";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox1.Text != "")
        {
            string query = "InsertTaxTemp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TaxPer", TextBox1.Text);


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
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow gr = GridView1.SelectedRow;
        TextBox1.Text = (gr.FindControl("Label1") as Label).Text;

        Session["mysession"] = (gr.FindControl("hfid") as HiddenField).Value;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["mysession"] != null)
        {
            SqlConnection conn = new SqlConnection(connectstringweb);
            conn.Open();
            string query = "TaxDelete";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TaxCode", Session["mysession"].ToString());
            cmd.ExecuteNonQuery();
            Response.Write("Delete successsfully");
            conn.Close();
            bindgridview();
            TextBox2.Text = "";

            Session.Remove("mysession");
        }
        else
        {
            Response.Write("Session is expired please click again select button");
        }
    }
}