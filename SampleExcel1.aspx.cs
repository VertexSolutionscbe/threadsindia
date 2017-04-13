using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public partial class SampleExcel1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
        //    //Get path from web.config file to upload
        //    string FilePath = ConfigurationManager.AppSettings["FilePath"].ToString();
        //    string filename = string.Empty;
        //    //To check whether file is selected or not to uplaod
        //    if (FileUploadToServer.HasFile)
        //    {
        //        try
        //        {
        //            string[] allowdFile = { ".xls", ".xlsx" };
        //            //Here we are allowing only excel file so verifying selected file pdf or not
        //            string FileExt = System.IO.Path.GetExtension(FileUploadToServer.PostedFile.FileName);
        //            //Check whether selected file is valid extension or not
        //            bool isValidFile = allowdFile.Contains(FileExt);
        //            if (!isValidFile)
        //            {
        //                lblMsg.ForeColor = System.Drawing.Color.Red;
        //                lblMsg.Text = "Please upload only Excel";
        //            }
        //            else
        //            {
        //                // Get size of uploaded file, here restricting size of file
        //                int FileSize = FileUploadToServer.PostedFile.ContentLength;
        //                if (FileSize <= 1048576)//1048576 byte = 1MB
        //                {
        //                    //Get file name of selected file
        //                    filename = Path.GetFileName(Server.MapPath(FileUploadToServer.FileName));

        //                    //Save selected file into server location
        //                    FileUploadToServer.SaveAs(Server.MapPath(FilePath) + filename);
        //                    //Get file path
        //                    string filePath = Server.MapPath(FilePath) + filename;
        //                    //Open the connection with excel file based on excel version
        //                    SqlConnection con = null;
        //                    if (FileExt == ".xls")
        //                    {
        //                        con = new SqlConnection(@"Provider=System.Data.SqlClient;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");

        //                    }
        //                    else if (FileExt == ".xlsx")
        //                    {
        //                        con = new SqlConnection  (@"Provider=System.Data.SqlClient;Data Source=" + filePath + ";Extended Properties=Excel 12.0;");
        //                    }
        //                    con.Open();
        //                    //Get the list of sheet available in excel sheet
        //                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        //                    //Get first sheet name
        //                    string getExcelSheetName = dt.Rows[0]["Table_Name"].ToString();
        //                    //Select rows from first sheet in excel sheet and fill into dataset
        //                    SqlCommand ExcelCommand = new SqlCommand(@"SELECT * FROM [" + getExcelSheetName + @"]", con);
        //                    SqlDataAdapter ExcelAdapter = new  SqlDataAdapter(ExcelCommand);
        //                    DataSet ExcelDataSet = new DataSet();
        //                    ExcelAdapter.Fill(ExcelDataSet);
        //                    con.Close();
        //                    //Bind the dataset into gridview to display excel contents
        //                    GridView1.DataSource = ExcelDataSet;
        //                    GridView1.DataBind();
        //                }
        //                else
        //                {
        //                    lblMsg.Text = "Attachment file size should not be greater then 1 MB!";
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            lblMsg.Text = "Error occurred while uploading a file: " + ex.Message;
        //        }
        //    }
        //    else
        //    {
        //        lblMsg.Text = "Please select a file to upload.";
        //    }
        }
    }


