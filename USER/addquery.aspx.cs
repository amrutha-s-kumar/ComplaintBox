using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.USER
{
    public partial class addquery : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = objregbl.getproduct();
                DropDownList1.DataTextField = "pname";
                DropDownList1.DataValueField = "pid";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            objregbl._query = query.Text;
            objregbl._pid = Convert.ToInt32(DropDownList1.SelectedValue);
            objregbl._qid = Convert.ToInt32(Session["l_id"]);


            int i = objregbl.insertquery();
            if (i == 1)
            {
                Response.Write("<script>alert('Query Registered Successfully');</script>");

            }
        }
    }
}