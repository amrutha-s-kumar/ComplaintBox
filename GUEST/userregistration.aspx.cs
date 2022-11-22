using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ComplaintBox.GUEST;

namespace ComplaintBox.GUEST
{
    public partial class userregistration : System.Web.UI.Page
    {

        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objregbl._rname = name.Text;
            objregbl._remail = email.Text;

            
            objregbl._rplace = place.Text;
            objregbl._rphone = phone.Text;
            objregbl._ruser = user.Text;
            objregbl._rpass = password.Text;
            object ob = objregbl.user_login_insert();
            objregbl._lid = ob.ToString();
            
            int i = objregbl.insertuser();
            // int j = objregbl.insertlogin();
            if (i == 1)
            {
                Response.Write("Registration Success");

            }
            else
            {
                Response.Write("Failed to Register");
            }

        }
    }

}