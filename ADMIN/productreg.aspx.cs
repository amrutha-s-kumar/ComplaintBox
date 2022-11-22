using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.ADMIN
{
    public partial class productreg : System.Web.UI.Page
    {
        BAL.regBAL objregbl = new BAL.regBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objregbl.viewproduct();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objregbl._pname = name.Text;
            objregbl._pdesc = description.Text;
            int i = objregbl.addproduct();
            if (i == 1)
            {
                Response.Write("Product Added");

            }
            else
            {
                Response.Write("Failed to Add");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objregbl._pid = id;
            int i = objregbl.deleteproduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objregbl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objregbl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txt1 = new TextBox();
            txt1 = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            objregbl._pid = id;
            objregbl._pname = txt.Text;
            objregbl._pdesc = txt1.Text;
            int i = objregbl.updateproduct();
            GridView1.EditIndex = -1;


            GridView1.DataSource = objregbl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objregbl.viewproduct();
            GridView1.DataBind();

        }
    }
}