using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Purchase_Oreder_Other : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindTaxdropdown();
        BindPartydropdown();
        int count;
        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from purchaseorder", con); ;



        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        TextBox1.Text = "Doc00" + count;

        con.Close();
    }


    protected void BindTaxdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select Taxcode,TaxPer from TaxTemplate", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "TaxPer";
       // DropDownList1.DataValueField = "Taxcode";
        DropDownList1.DataBind();
    }
    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select partycategorycode,PartyCategory from partycategory", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;
        
        DropDownList2.DataTextField = "PartyCategory";
       // DropDownList2.DataValueField = "partycategorycode";
        DropDownList2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //  string strSQL = "SELECT * FROM DesignationMaster WHERE DesignationCode = " '"+ txtval1.Text"';
        //   da.SelectCommand = new SqlCommand(strSQL);
        da.SelectCommand = new SqlCommand("SELECT * FROM purchaseorder WHERE DocId ='" + TextBox1.Text + "'");
        da.SelectCommand.Connection = conn;
        da.Fill(dt);

        if (dt.Rows.Count > 0) // Means Student Id is already present
        {

            string message = "This Purchase is already added!";
            ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);
        }
        else if (dt.Rows.Count == 0 && TextBox1.Text != "")
        {
            string query = "InsertPurchaseOrder";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Docid", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Tax", DropDownList1.Text.ToString());
            cmd.Parameters.AddWithValue("@Party", DropDownList2.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Potype", DropDownList3.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Pay", DropDownList4.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Date", TextBox2.Text);

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