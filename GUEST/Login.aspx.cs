using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ComplaintBox.GUEST
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {






            objregbl._ruser = user.Text;
            objregbl._rpass = password.Text;
            DataTable dt = objregbl.loginin();

            if (dt.Rows.Count == 1)
            {
                Session["uname"] = dt.Rows[0]["username"].ToString();
                Session["l_id"] = dt.Rows[0]["lid"].ToString();



                if (dt.Rows[0]["role"].ToString() == "admin")
                    Response.Redirect("../ADMIN/adminmaster.aspx");
                else if (dt.Rows[0]["role"].ToString() == "customer")
                    if (dt.Rows[0]["status"].ToString() == "confirmed")
                        Response.Redirect("../USER/userdesign.aspx");
                    else
                        Response.Write("<script>alert(' User Not Verified');</script>");
                else
                    Response.Write("<script>alert('Invalid Credentials');</script>");





            }
        }
    }
}