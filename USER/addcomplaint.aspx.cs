using ComplaintBox.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.USER
{
    public partial class addcomplaint : System.Web.UI.Page
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
        


            /*
                        DataTable product_list = BAL.regBAL.GetproductList();
                        // objregbl._ = dtState;
                        objregbl.DataSource = dt;
                        objregbl._pname = "pname";
                        objregbl._pid = "pid";
                        objregbl.DataBind();
                        //objregbl.Items.Insert(0, new ListItem("---Select State---"));
                        objregbl.Items.Insert(0, new ListItem("---Select State---"));
                    }*/
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            objregbl._complaint = complaint.Text;
            objregbl._id = Convert.ToInt32(Session["l_id"]);
                
            objregbl._pid = Convert.ToInt32(DropDownList1.SelectedValue);
           
           
            int i = objregbl.insertComplaint();
            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Registered Successfully');</script>");

            }

        }
    }
}