using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.USER
{
    public partial class viewstatus : System.Web.UI.Page
    {

        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                objregbl._cid = Convert.ToInt32(Session["l_id"]);
                GridView1.DataSource = objregbl.viewcomplaintstatus();
                GridView1.DataBind();
            }

        }
    }
}