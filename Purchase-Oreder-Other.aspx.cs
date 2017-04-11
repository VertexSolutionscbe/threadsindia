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
        SqlConnection con = new SqlConnection(connectstringweb);

        SqlCommand cmd = new SqlCommand("select count(*) from orderindent", con); ;



        con.Open();

        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

        TextBox1.Text = "Doc00" + count;

        con.Close();
    }
}