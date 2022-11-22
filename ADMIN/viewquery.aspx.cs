using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.ADMIN
{
    public partial class viewquery : System.Web.UI.Page
    {

        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objregbl.viewquery();
            GridView1.DataBind();
        }
    }
}