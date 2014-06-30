using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using pakatsWeb.Models;
namespace pakatsWeb.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        pakats_dbEntities db = new pakats_dbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }


    }
}