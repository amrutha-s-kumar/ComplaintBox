using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.ADMIN
{
    public partial class reply : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int queid = Convert.ToInt32(Request.QueryString["qid"]);
            objregbl.Reply = query.Text;
            objregbl._qid = queid;
            int i = objregbl.updateqry();
            if (i == 1)
            {
                Response.Write("<script>alert('Reply Registered Successfully');</script>");



            }
        }
    }
}