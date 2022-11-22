using ComplaintBox.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ComplaintBox.DAL
{
    public class regDAL
    {


        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        // private string s;
        //private string _ruser;
        //private string _rpass;

        public regDAL()
        {



            string conn = ConfigurationManager.ConnectionStrings["ros"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        /* public int registrationInsert(BAL.regBAL obj)
         {



             string qry = "insert into userreg values('" + obj._rname + "','" + obj._remail + "','" + obj._rplace + "','" + obj._rphone + "','"+obj._lid+"');select @@IDENTITY";


             SqlCommand cmd = new SqlCommand(qry, Getcon());
             object ob = cmd.ExecuteScalar();


             string st = "not yet confirmed";
             string rl = "customer";
             string s = "insert into login values('" + obj._ruser + "','" + obj._rpass + "','" + rl + "','" + st + "','"+ob+"')";
             cmd = new SqlCommand(s, Getcon());
             return cmd.ExecuteNonQuery();





         }*/

        /*public int 
            {
             con.Open();
             SqlCommand cmd = new SqlCommand("SELECT table_name FROM INFORMATION_SCHEMA.TABLES", con);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             ddlabc.DataSource = ds;
             ddlabc.DataTextField = "table_name";
             ddlabc.DataValueField = "table_name";
             ddlabc.DataBind();
             con.Close();
            }*/
        public int userInsert(BAL.regBAL obj)
        {
            string qry = "insert into userreg values('" + obj._rname + "' ,'" + obj._remail + "','" + obj._rplace + "','" + obj._rphone + "','" + obj._lid + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public object userlogin(BAL.regBAL obj)
        {
            GetCon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + obj._ruser + "','" + obj._rpass + "','customer','not yet confirmed');select @@IDENTITY";
            object id = cmd.ExecuteScalar();
            return id;
        }
        public int User_login(BAL.regBAL obj)
        {
            string s = "select count(*) from login where username='" + obj._ruser + "' and password='" + obj._rpass + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            int row = (int)cmd.ExecuteScalar();
            return row;
        }
            public DataTable logintable(BAL.regBAL obj)

        {
            string sql = "select * from login where username='" +obj. _ruser + "' and password='" + obj._rpass + "'";
            SqlCommand cmd = new SqlCommand(sql, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }

        public int productinsert(BAL.regBAL obj)
        {
            string qry = "insert into product values('" + obj._pname + "','" + obj._pdesc + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int confirm_user(BAL.regBAL obj)
        {
            string s = "update login set status='confirmed' where lid=" + obj._lid + "";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable view_user()
        {
            string qry = "select s.*,l.* from userreg s INNER JOIN login l ON s.lid=l.lid where l.role='customer' and l.status='not yet confirmed'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable view_product()
        {
            string s = "select * from product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int update_product(BAL.regBAL obj)
        {
            string s = "update product set pname='" + obj._pname + "', pdescription='"+obj._pdesc+"' where pid='" + obj._pid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

      

        public int delete_product(BAL.regBAL obj)
        {
            string s = "delete from product where pid='" + obj._pid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }



        public DataTable Getproduct(BAL.regBAL obj)
        {
            string s = "SELECT * FROM product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintInsert(BAL.regBAL obj)
        {
            string qry = "insert into complaint values('" + obj._complaint + "','" + obj._id + "','" + obj._pid + "','Complaint Received',GETDATE())";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

      
        public int query_insert(BAL.regBAL obj)
        {
            string qry = "insert into query values('" + obj._query + "','" + obj._pid + "','" + obj._qid+ "','Query Received',GETDATE(),'no Reply')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable complaintview(BAL.regBAL obj)
        {
            string s = "select * from userreg tb inner join complaint cmt on tb.userid=cmt.userid inner join product pt on pt.pid=cmt.pid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Changecmpltstatus(BAL.regBAL obj)
        {
            string s = "update complaint set status='Complaint Confirmed' where Id='"+ obj._cid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewcomplaintstatus(BAL.regBAL obj)
        {
            string s = "select * from userreg tb inner join complaint cmt on tb.userid=cmt.userid inner join product pt on pt.pid=cmt.pid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable queryview(BAL.regBAL obj)
        {
            string s = "select * from userreg tb inner join query cmt on tb.userid=cmt.userid inner join product pt on pt.pid=cmt.pid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Updatequery(BAL.regBAL obj)
        {
            string qry = "update query set reply='" + obj.Reply + "' where qid='" + obj._qid + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewreply(BAL.regBAL obj)
        {
            string s = "select * from product pt inner join query qt on pt.pid=qt.pid where qt.userid='" + obj._id + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
