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
            if (Session["UserName"] != null)
            {

                Response.Redirect("userPage.aspx");
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;


            double userid = 0;
            userid = (from c in db.login_tb where c.userName == this.txtUserName.Text && c.password == this.txtPassword.Text select c.id).FirstOrDefault();

            if (userid != 0)
            {
                if (this.txtlogId.Text == "admin")
                {
                    Session["UserName"] = "Welcome " + login;
                    Session["loginName"] = "admin";
                    Session["UserId"] = userid;

                    Response.Redirect("..\\admin\\sys_admin_123@sina.aspx");
                    // errormsg.Text = "Admin";

                }
                else
                {
                    Session["UserName"] = "Welcome " + login;

                    Session["loginName"] = null;
                    Session["UserId"] = userid;
                    Response.Redirect("userPage.aspx");
                    // errormsg.Text = "Success";
                }

            }
            else
            {
                errormsg.Visible = true;
                errormsg.Text = "Login Failed Check User Name And password";

            }
        }



    }
}
