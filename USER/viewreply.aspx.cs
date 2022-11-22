using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.USER
{
    public partial class viewreply : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            objregbl._id = Convert.ToInt32(Session["l_id"]);
            GridView1.DataSource = objregbl.viewreply();
            GridView1.DataBind();
        }
    }
}