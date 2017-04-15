using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Winding_Bill : System.Web.UI.Page
{
    string connectstringweb = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindCompanydropdown();
        int count;
       
        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from WindingBill", con); ;



        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        txtval6.Text = "Doc00" + count;
        txtval4.Text = "Bill00" + count;
        bindgridview();
    }
    protected void BindCompanydropdown()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select companycode,companyname from company", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "companyname";
        // DropDownList1.DataValueField = "Taxcode";
        DropDownList1.DataBind();
    }

    protected void txtval20_TextChanged(object sender, EventArgs e)
    {

       if(txtval21.Text=="")
       {
            txtval21.Text = (int.Parse(txtval19.Text) + int.Parse(txtval20.Text)).ToString();
        }
       
    }

    protected void txtval21_TextChanged(object sender, EventArgs e)
    {

      //  decimal txtval22; //Needs a better name
       // decimal textBox20Value; //Needs a better name


        if (txtval22.Text == "")
        {
            txtval22.Text = (int.Parse(txtval21.Text) - int.Parse(txtval18.Text)).ToString();
        }

    }

    protected void txtval13_TextChanged(object sender, EventArgs e)
    {

        //  decimal txtval22; //Needs a better name
        // decimal textBox20Value; //Needs a better name


        if (txtval13.Text == "")
        {
            txtval14.Text = (int.Parse(txtval13.Text) ).ToString();
        }

    }
    private void bindgridview()
    {

        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        string query = "WindingGrid";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        conn.Close();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //txtval2.Text = "";
        txtval3.Text = "";
        txtval4.Text = "";
        txtval5.Text = "";
        txtval6.Text = "";
        txtval7.Text = "";
        txtval8.Text = "";
        txtval9.Text = "";
        txtval10.Text = "";
        txtval11.Text = "";
        txtval12.Text = "";
        txtval13.Text = "";
        txtval14.Text = "";
        txtval15.Text = "";
        txtval16.Text = "";
        txtval17.Text = "";
        txtval18.Text = "";
        txtval19.Text = "";
        txtval20.Text = "";
        txtval21.Text = "";
        txtval22.Text = "";
        txtval23.Text = "";
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connectstringweb);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM WindingBill WHERE Company =@Company", conn);
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
      //  cmd.Parameters.AddWithValue("@Company", this.DropDownList1.Text.Trim());
        cmd.Parameters.AddWithValue("@Company", DropDownList1.Text);
        da.Fill(ds);
       
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Button4.Text == "Save")
                {
                    string message = "This Company is already added!";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                }
                else if(Button4.Text=="Update")
                {
                    string query = "WindingUpdate";
                    SqlCommand cmd1 = new SqlCommand(query, conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    // cmd1.Parameters.AddWithValue("@DesignationCode", Label4.Text);
                    cmd1.Parameters.AddWithValue("@Company", DropDownList1.Text);
                    cmd1.Parameters.AddWithValue("@BillDate", txtval3.Text);
                    cmd1.Parameters.AddWithValue("@BillNo", txtval4.Text);
                    cmd1.Parameters.AddWithValue("@PartyId", txtval5.Text);
                    cmd1.Parameters.AddWithValue("@DCNo", txtval6.Text);
                    cmd1.Parameters.AddWithValue("@DCDate", txtval7.Text);
                    cmd1.Parameters.AddWithValue("@RecNo", txtval8.Text);
                    cmd1.Parameters.AddWithValue("@RecDate", txtval9.Text);
                    cmd1.Parameters.AddWithValue("@DCWt", txtval10.Text);
                    cmd1.Parameters.AddWithValue("@RecCone", txtval11.Text);
                    cmd1.Parameters.AddWithValue("@RecWt", txtval12.Text);
                    cmd1.Parameters.AddWithValue("@Rate", txtval13.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txtval14.Text);
                    cmd1.Parameters.AddWithValue("@TotalCones", txtval15.Text);
                    cmd1.Parameters.AddWithValue("@TotalReceived", txtval16.Text);
                    cmd1.Parameters.AddWithValue("@TotalDCKgs", txtval17.Text);
                    cmd1.Parameters.AddWithValue("@Gross", txtval18.Text);
                    cmd1.Parameters.AddWithValue("@ReceivedBox", txtval19.Text);
                    cmd1.Parameters.AddWithValue("@BoxRate", txtval20.Text);
                    cmd1.Parameters.AddWithValue("@Net", txtval21.Text);
                    cmd1.Parameters.AddWithValue("@BoxAmount", txtval22.Text);
                    cmd1.Parameters.AddWithValue("@Narration", txtval23.Text);
                    cmd1.Parameters.AddWithValue("@WindingBillId", Label7.Text);
                    cmd1.ExecuteNonQuery();
                    // Response.Write("Record inserted successsfully");
                    string message = "Record updated successsfully";
                    Button4.Text = "Save";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    conn.Close();
                    bindgridview();
                   // txtval2.Text = "";
                    txtval3.Text = "";
                    txtval4.Text = "";
                    txtval5.Text = "";
                    txtval6.Text = "";
                    txtval7.Text = "";
                    txtval8.Text = "";
                    txtval9.Text = "";
                    txtval10.Text = "";
                    txtval11.Text = "";
                    txtval12.Text = "";
                    txtval13.Text = "";
                    txtval14.Text = "";
                    txtval15.Text = "";
                    txtval16.Text = "";
                    txtval17.Text = "";
                    txtval18.Text = "";
                    txtval19.Text = "";
                    txtval20.Text = "";
                    txtval21.Text = "";
                    txtval22.Text = "";
                    txtval23.Text = "";
                }
            }



            else  
        {
            if (Button4.Text == "Save")
            {
                string query = "InsertWindingBill";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Designationcode", txtval1.Text);
                // cmd.Parameters.AddWithValue("@DesignationName", txtval2.Text);
                cmd1.Parameters.AddWithValue("@Company", DropDownList1.Text);
                cmd1.Parameters.AddWithValue("@BillDate", txtval3.Text);
                cmd1.Parameters.AddWithValue("@BillNo", txtval4.Text);
                cmd1.Parameters.AddWithValue("@PartyId", txtval5.Text);
                cmd1.Parameters.AddWithValue("@DCNo", txtval6.Text);
                cmd1.Parameters.AddWithValue("@DCDate", txtval7.Text);
                cmd1.Parameters.AddWithValue("@RecNo", txtval8.Text);
                cmd1.Parameters.AddWithValue("@RecDate", txtval9.Text);
                cmd1.Parameters.AddWithValue("@DCWt", txtval10.Text);
                cmd1.Parameters.AddWithValue("@RecCone", txtval11.Text);
                cmd1.Parameters.AddWithValue("@RecWt", txtval12.Text);
                cmd1.Parameters.AddWithValue("@Rate", txtval13.Text);
                cmd1.Parameters.AddWithValue("@Amount", txtval14.Text);
                cmd1.Parameters.AddWithValue("@TotalCones", txtval15.Text);
                cmd1.Parameters.AddWithValue("@TotalReceived", txtval16.Text);
                cmd1.Parameters.AddWithValue("@TotalDCKgs", txtval17.Text);
                cmd1.Parameters.AddWithValue("@Gross", txtval18.Text);
                cmd1.Parameters.AddWithValue("@ReceivedBox", txtval19.Text);
                cmd1.Parameters.AddWithValue("@BoxRate", txtval20.Text);
                cmd1.Parameters.AddWithValue("@Net", txtval21.Text);
                cmd1.Parameters.AddWithValue("@BoxAmount", txtval22.Text);
                cmd1.Parameters.AddWithValue("@Narration", txtval23.Text);

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
                bindgridview();
                //txtval2.Text = "";
                txtval3.Text = "";
                txtval4.Text = "";
                txtval5.Text = "";
                txtval6.Text = "";
                txtval7.Text = "";
                txtval8.Text = "";
                txtval9.Text = "";
                txtval10.Text = "";
                txtval11.Text = "";
                txtval12.Text = "";
                txtval13.Text = "";
                txtval14.Text = "";
                txtval15.Text = "";
                txtval16.Text = "";
                txtval17.Text = "";
                txtval18.Text = "";
                txtval19.Text = "";
                txtval20.Text = "";
                txtval21.Text = "";
                txtval22.Text = "";
                txtval23.Text = "";
            }
            else
            {
               
            }
           
        }
       
 
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (Session["mysession"] != null)
        {
            SqlConnection conn = new SqlConnection(connectstringweb);
            conn.Open();
            string query = "WindingDelete";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@name", txtname.Text);
            //cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@WindingBillId", Session["mysession"].ToString());
            cmd.ExecuteNonQuery();
            Response.Write("Delete successsfully");
            conn.Close();
            bindgridview();
            //txtval2.Text = "";
            txtval3.Text = "";
            txtval4.Text = "";
            txtval5.Text = "";
            txtval6.Text = "";
            txtval7.Text = "";
            txtval8.Text = "";
            txtval9.Text = "";
            txtval10.Text = "";
            txtval11.Text = "";
            txtval12.Text = "";
            txtval13.Text = "";
            txtval14.Text = "";
            txtval15.Text = "";
            txtval16.Text = "";
            txtval17.Text = "";
            txtval18.Text = "";
            txtval19.Text = "";
            txtval20.Text = "";
            txtval21.Text = "";
            txtval22.Text = "";
            txtval23.Text = "";

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
        DropDownList1.Text = (gr.FindControl("gridLabel2") as Label).Text;
        txtval3.Text = (gr.FindControl("gridLabel3") as Label).Text;
        txtval4.Text = (gr.FindControl("gridLabel5") as Label).Text;
        txtval5.Text = (gr.FindControl("gridLabel4") as Label).Text;
        txtval6.Text = (gr.FindControl("gridLabel6") as Label).Text;
        txtval7.Text = (gr.FindControl("gridLabel7") as Label).Text;
        txtval8.Text = (gr.FindControl("gridLabel8") as Label).Text;
        txtval9.Text = (gr.FindControl("gridLabel9") as Label).Text;
        txtval10.Text = (gr.FindControl("gridLabel10") as Label).Text;
        txtval11.Text = (gr.FindControl("gridLabel11") as Label).Text;
        txtval12.Text = (gr.FindControl("gridLabel12") as Label).Text;
        txtval13.Text = (gr.FindControl("gridLabel13") as Label).Text;
        txtval14.Text = (gr.FindControl("gridLabel14") as Label).Text;
        txtval15.Text = (gr.FindControl("gridLabel15") as Label).Text;
        txtval16.Text = (gr.FindControl("gridLabel20") as Label).Text;
        txtval17.Text = (gr.FindControl("gridLabel16") as Label).Text;
        txtval18.Text = (gr.FindControl("gridLabel22") as Label).Text;
        txtval19.Text = (gr.FindControl("gridLabel17") as Label).Text;
        txtval20.Text = (gr.FindControl("gridLabel23") as Label).Text;
        txtval21.Text = (gr.FindControl("gridLabel18") as Label).Text;
        txtval22.Text = (gr.FindControl("gridLabel24") as Label).Text;
        txtval23.Text = (gr.FindControl("gridLabel19") as Label).Text;
        Session["mysession"] = (gr.FindControl("hfid") as HiddenField).Value;
        Label7.Text = (gr.FindControl("hfid") as HiddenField).Value;
        Button4.Text = "Update";
    }
}