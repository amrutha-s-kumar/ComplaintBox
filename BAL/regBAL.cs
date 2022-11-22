using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintBox.BAL
{
    public class regBAL
    {
        DAL.regDAL objdeptdl = new DAL.regDAL();

        //create  variable based on the class
        private int id;
        private string rname;
        private string remail;
        private string rplace;
        private string rphone;
        private string ruser;
        private string rpass;
        private int pid;
        private string pname;
        private string pdescription;
        private string login_id;
        private int cid;
        private string complaint;
        private int qid;
        private string querie;
        private string reply;

        //private string lid;

        
        public int _id
        {
            get
            {
                return id;

            }
            set
            {
                id = value;
            }
        }

        public string _rname
        {
            get
            {
                return rname;

            }
            set
            {
                rname = value;
            }
        }
        public string _remail
        {
            get
            {
                return remail;
            }
            set
            {
                remail = value;
            }
        }

        public string _rplace
        {
            get
            {
                return rplace;
            }
            set
            {
                rplace = value;
            }
        }
        public string _rphone
        {
            get
            {
                return rphone;
            }
            set
            {
                rphone = value;
            }
        }

        


        public string _ruser
        {
            get
            {
                return ruser;
            }
            set
            {
                ruser = value;
            }
        }


        public string _rpass
        {
            get
            {
                return rpass;
            }
            set
            {
                rpass = value;
            }
        }

        public int _pid
        {
            get
            {
                return pid;

            }
            set
            {
                pid = value;
            }
        }

        public string _pname
        {
            get
            {
                return pname;

            }
            set
            {
                pname = value;
            }
        }
        public string _pdesc
        {
            get
            {
                return pdescription;
            }
            set
            {
                pdescription = value;
            }
        }


        public string _lid
        {
            get
            {
                return login_id;

            }
            set
            {
                login_id = value;
            }
        }


        public int _cid
        {
            get
            {
                return cid;

            }
            set
            {
                cid = value;
            }
        }

        public string _complaint
        {
            get
            {
                return complaint;

            }
            set
            {
                complaint = value;
            }
        }
        public int _qid

        {
            get
            {
                return qid;
            }
            set
            {
                qid = value;
            }
        }

        public string _query
        {
            get
            {
                return querie;
            }
            set
            {
                querie = value;
            }
        }

        public string Reply
        {
            get
            {
                return reply;
            }
            set
            {
                reply = value;
            }
        }

        public DataTable getproduct()
        {
            return objdeptdl.Getproduct(this);
        }

        public int insertComplaint()
        {
            return objdeptdl.complaintInsert(this);
        }


        

        public int insertuser()
        {
            return objdeptdl.userInsert(this);
        }
        public object user_login_insert()
        {
            return objdeptdl.userlogin(this);
        }

        public DataTable loginin()
        {
            return objdeptdl.logintable(this);
        }
        /*   public int insertlogin()
           {
               return objdeptdl.registrationInsert(this);
           }*/
        public int addproduct()
        {
            return objdeptdl.productinsert(this);
        }

        public DataTable viewusers()
        {
            return objdeptdl.view_user();
        }

        public int confirmuser()
        {
            return objdeptdl.confirm_user(this);
        }

        public DataTable viewproduct()
        {
            return objdeptdl.view_product();
        }

        public int updateproduct()
        {
            return objdeptdl.update_product(this);
        }

        public int deleteproduct()
        {
            return objdeptdl.delete_product(this);
        }

        public int insertquery()
        {
            return objdeptdl.query_insert(this);
        }

        public DataTable viewcomplaint()
        {
            return objdeptdl.complaintview(this);
        }

        public int changecmpltstatus()
        {
            return objdeptdl.Changecmpltstatus(this);
        }

        public DataTable viewcomplaintstatus()
        {
            return objdeptdl.Viewcomplaintstatus(this);
        }
        public DataTable viewquery()
        {
            return objdeptdl.queryview(this);
        }

        public int updateqry()
        {
            return objdeptdl.Updatequery(this);
        }

        public DataTable viewreply()
        {
            return objdeptdl.Viewreply(this);
        }
    }
}