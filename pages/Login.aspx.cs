using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace pakatsWeb.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connetionString = null;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlConnection cnn;
        string query = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            connetionString = "Data Source=PAKATS-PC;Initial Catalog=pakats_db;User ID=sa;Password=pakats";
            cnn = new SqlConnection(connetionString);
            try
            {
                query = "";
                cmd = new SqlCommand(query, cnn);
                if (cnn.State != ConnectionState.Open)
                    cnn.Open();
                dataReader = cmd.ExecuteReader();
                dataReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                lblPassword.Text=ex.ToString();
            }
        }


    }
}