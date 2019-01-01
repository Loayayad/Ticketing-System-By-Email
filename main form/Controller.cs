using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace main_form
{
    public class Controller
    { 
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        
        public DataTable GetCompanyNames()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.companyname;
            return dbMan.ExecuteReader(StoredProcName, null);

        }
        public DataTable getusernames()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.getuserallnames;
            return dbMan.ExecuteReader(StoredProcName, null);

        }
        public DataTable getsysnames()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.getsysname;
            return dbMan.ExecuteReader(StoredProcName, null);

        }
        public DataTable getsevnames()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.getsevname;
            return dbMan.ExecuteReader(StoredProcName, null);

        }
        public DataTable getstatnames()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.getstatname;
            return dbMan.ExecuteReader(StoredProcName, null);

        }
        public int addticket(string id,int userid, string body, string subject, string from,string cc, string opendate,int att,string comment = "new")
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@body", body);
            Parameters.Add("@subject", subject);
            Parameters.Add("@opendate", opendate);
            Parameters.Add("@from", from );
            Parameters.Add("@attachments", att);
            Parameters.Add("@id", id);
            Parameters.Add("@userid", userid);
            Parameters.Add("@cc", cc);
            Parameters.Add("@comment", comment);
            string StoredProcname = StoredProcedures.addticket;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;

        }
        public int EditTickets(string id,string body,string subject,string comment,string closedate
            ,int id1, int id2, int id3, int id4, int id5)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@body", body);
            Parameters.Add("@subject", subject);
            Parameters.Add("@closedate", closedate);
            Parameters.Add("@comment", comment);
            Parameters.Add("@id", id);
            Parameters.Add("@userid", id1);
            Parameters.Add("@cid", id2);
            Parameters.Add("@sysid", id3);
            Parameters.Add("@sevid", id4);
            Parameters.Add("@statid", id5);
            string StoredProcname = StoredProcedures.EditTickets;
            object f= dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f==null) return 0;
            else return 1;
          
        }
        public int changecompany(int cid,string tid)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tid", tid);
            Parameters.Add("@uid", cid);
            string StoredProcname = StoredProcedures.changecompany;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;
        }
        public int changeuser(int cid, string tid)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tid", tid);
            Parameters.Add("@uid", cid);
            string StoredProcname = StoredProcedures.changeuser;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;
        }
        public int changesev(int cid, string tid)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tid", tid);
            Parameters.Add("@sid", cid);
            string StoredProcname = StoredProcedures.changesev;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;
        }
        public int changestatus(int cid, string tid)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tid", tid);
            Parameters.Add("@uid", cid);
            string StoredProcname = StoredProcedures.changestatus;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;
        }
        public int changesys(int cid, string tid)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tid", tid);
            Parameters.Add("@uid", cid);
            string StoredProcname = StoredProcedures.changesys;
            object f = dbMan.ExecuteScalar(StoredProcname, Parameters);
            if (f == null) return 0;
            else return 1;
        }
        public bool CheckPassword(string username, string password)
        {
            Dictionary<string, Object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@pass", password);
            string StoredProcname = StoredProcedures.checkuser;
            if ((int)dbMan.ExecuteScalar(StoredProcname, Parameters) > 0) return true;
            return false;


        }
        public int RetrievetlID(string username,string pass)
    {
        Dictionary<string, object> Parameters = new Dictionary<string, object>();
        Parameters.Add("@username", username);
            Parameters.Add("@pass", pass);
            string StoredProcName = StoredProcedures.getid;
        object x = dbMan.ExecuteScalar(StoredProcName, Parameters);
        if (x == null) return -1;
        return (int)x;
    }
        public DataTable ShowAllTick()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            string StoredProcName = StoredProcedures.tickets;
            return dbMan.ExecuteReader(StoredProcName, null);
        }
        public DataTable ShowAllTickstat(int x)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            string StoredProcName = StoredProcedures.showalltickstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }
        public DataTable ShowAllTickcomp(int x)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp", x);
            string StoredProcName = StoredProcedures.showalltickcomp;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowAllTicksys(int x)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@sys", x);
            string StoredProcName = StoredProcedures.showallticksys;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowAllTicksev(int x)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@sev", x);
            string StoredProcName = StoredProcedures.showallticksev;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickByCompStat(int x,int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status",x );
            Parameters.Add("@compID", y);
            string StoredProcName = StoredProcedures.showtickbycompstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBySysStat(int x, int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@sysID", y);
            string StoredProcName = StoredProcedures.showtickbysysstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBySevStat(int x, int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@sevid", y);
            string StoredProcName = StoredProcedures.showtickbysevstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowAllTickCompSys(int x, int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@compID", x);
            Parameters.Add("@sysid", y);
            string StoredProcName = StoredProcedures.showalltickcompsys;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowAllTickCompSev(int x, int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@compID", x);
            Parameters.Add("@sevid", y);
            string StoredProcName = StoredProcedures.showalltickcompsev;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowAllTickSevSys(int x, int y)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@sysid", x);
            Parameters.Add("@sevid", y);
            string StoredProcName = StoredProcedures.showallticksevsys;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBycompSysStat(int x, int y,int z)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@compID", y);
            Parameters.Add("@sysid", z);
            string StoredProcName = StoredProcedures.showtickbycompsysstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBycompSevStat(int x, int y, int z)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@compID", y);
            Parameters.Add("@sevid", z);
            string StoredProcName = StoredProcedures.showtickbycompsevstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBysevSysStat(int x, int y, int z)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@sysid", y);
            Parameters.Add("@sevid", z);
            string StoredProcName = StoredProcedures.showtickbysevsysstat;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickBycompSysSev(int x, int y, int z)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@compID", x);
            Parameters.Add("@sysid", y);
            Parameters.Add("@sevid", z);
            string StoredProcName = StoredProcedures.showtickbycompsyssev;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

        public DataTable ShowTickByAll(int x, int y, int z,int v)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@status", x);
            Parameters.Add("@compID", y);
            Parameters.Add("@sysID", z);
            Parameters.Add("@sevid",v);
            string StoredProcName = StoredProcedures.showtickbyall;

            return dbMan.ExecuteReader(StoredProcName, Parameters);
        }

    }
}