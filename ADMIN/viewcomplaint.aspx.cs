using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.ADMIN
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objregbl.viewcomplaint();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objregbl._cid = id;
            int i = objregbl.changecmpltstatus();
            GridView1.DataSource = objregbl.viewcomplaint();
            GridView1.DataBind();
        }
    }
}