using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class CS_Code_Default :  System.Web.UI.Page
{
    private string strConn = "Data Source=LAPTOP-MI-SEESA;Initial Catalog=TEST;Integrated Security=True";
    private SqlConnection sqlCon;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void showMsgBox(string msgText)
    {
        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert(\""+msgText+"\")", true);
    }

    protected void Read_Click(object sender, EventArgs e)
    {
        SqlConnection sqlCon = new SqlConnection(strConn);
        SqlCommand sqlComm = new SqlCommand
        {
            Connection = sqlCon,
            CommandText = "ReadAppDataFromTable",
            CommandType = System.Data.CommandType.StoredProcedure
        };

        sqlComm.Parameters.AddWithValue("ID", "1");

        try
        {
            sqlCon.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Name.Text = sqlReader.GetString(1);
            } else
            {
                showMsgBox("no data in database");
            }

        }
        catch (Exception exc)
        {
            showMsgBox(exc.Message);
        }
        finally
        {
            sqlCon.Close();
        }
    }
}