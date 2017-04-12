using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Gooda_Received_Note_Other : System.Web.UI.Page
{
    public string str;
    public string str2;
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
         
        int count;
        int count1;
        BindLocationdropdown();
        BindPartydropdown();
        BindItemdropdown();
        BindUnitdropdown();
        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from goodsreceivednote", con); ;



        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        TextBox1.Text = "Doc00" + count;

        SqlCommand cmd1 = new SqlCommand("select count1(*) from goodsreceivednote", con); ;



        ////con.Open();

        count1 = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        TextBox2.Text = "Ref00" + count1;

      //  con.Close();
    }
    protected void BindLocationdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select LocationCode,LocationName from locationmaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList3.DataSource = dt;

        DropDownList3.DataTextField = "LocationName";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList3.DataBind();
    }

    protected void BindPartydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select Category,Party from partycategorymaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList2.DataSource = dt;

        DropDownList2.DataTextField = "Party";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList2.DataBind();
    }


    protected void BindItemdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select GroupID,ItemGroup from ItemGroupMaster", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "ItemGroup";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList1.DataBind();
    }
    protected void BindUnitdropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select UnitCode,Unit from unit", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList4.DataSource = dt;

        DropDownList4.DataTextField = "Unit";
        // DropDownList4.DataValueField = "TaxCode";
        DropDownList4.DataBind();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        str = TextBox5.Text;
        str2 = TextBox13.Text;
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM goodsreceivednote WHERE RefNo =@RefNo", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@RefNo", this.TextBox2.Text.Trim());



        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string message = "This Goods Note is already added!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        else if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != ""&& TextBox5.Text != ""&& TextBox7.Text != ""&& TextBox8.Text != ""&& TextBox9.Text != ""&&  TextBox10.Text != ""&&  TextBox11.Text != ""&&  TextBox12.Text != "" && TextBox13.Text != "" &&  TextBox14.Text != "")
        {
            //if (str >= str2)
            if((Convert.ToString(TextBox5.Text))!=( Convert.ToString(TextBox13.Text)))
            {
                string query = "InsertGoodsReceiveNote";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Location", DropDownList3.SelectedValue);
                cmd1.Parameters.AddWithValue("@DocId", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@RefNo", TextBox2.Text);
                cmd1.Parameters.AddWithValue("@Date", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@Party", DropDownList2.SelectedValue);
                cmd1.Parameters.AddWithValue("@Shade", TextBox7.Text);
                cmd1.Parameters.AddWithValue("@Item", DropDownList1.SelectedValue);
                cmd1.Parameters.AddWithValue("@Unit", DropDownList4.SelectedValue);
                cmd1.Parameters.AddWithValue("@Cones", TextBox8.Text);
                cmd1.Parameters.AddWithValue("@Quantity", TextBox9.Text);
                cmd1.Parameters.AddWithValue("@Rate", TextBox10.Text);
                cmd1.Parameters.AddWithValue("@Amount", TextBox11.Text);
                cmd1.Parameters.AddWithValue("@Narration", TextBox14.Text);
                cmd1.Parameters.AddWithValue("@NetBill", TextBox13.Text);
                cmd1.Parameters.AddWithValue("@Gross", TextBox5.Text);
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
                string message = "Net Bill should be less than gross bill";

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

            }

        }
        else
        {

        }
    }
}