using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.ADMIN
{
    public partial class confirmuser : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objregbl.viewusers();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();
            objregbl._lid = s;





            int i = objregbl.confirmuser();
            GridView1.DataSource = objregbl.viewusers();
            GridView1.DataBind();


            

            
        }

        
    }
}