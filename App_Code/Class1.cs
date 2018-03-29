using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace nsgaanamania { 
    //interfaces here.....................
    public interface inttbsgsctg {
        Int32 sgsctgid { get; set; }
        String sgsctgnm { get; set; }
        String sgsctgdesc { get; set; }
    
    }
    public interface inttbsgsdata {
        Int32 sgsid { get; set; }
        String sgstitle { get; set; }
        String sgsast { get; set; }
        String sgsdesc { get; set; }
        String sgslk { get; set; }
        DateTime sgsdat { get; set; }
        Int32 sgsdatactgid { get; set; }
    
    }
    public interface inttbsgsdwnlds {
        Int32 sgsdwnldsid { get; set; }
        Int32 sgsdwnldssgsid { get; set; }
        Int32 sgsdwnldsno { get; set; }
    }


    //interfaces end here...........
    //property classes starting 
    public class clstbsgsctgprp : inttbsgsctg
    {
        Int32 prvsgsctgid;
        String prvsgsctgnm, prvsgsctgdesc;
        public int sgsctgid
        {
            get
            {
                return prvsgsctgid;
            }
            set
            {
                prvsgsctgid=value;
            }
        }

        public string sgsctgnm
        {
            get
            {
                return prvsgsctgnm;
            }
            set
            {
                prvsgsctgnm=value;
            }
        }

        public string sgsctgdesc
        {
            get
            {
                return prvsgsctgdesc;
            }
            set
            {
                prvsgsctgdesc=value;
            }
        }
    }

    public class clstbsgsdataprp : inttbsgsdata
    {
        Int32 prvsgsid,prvsgsdatactgid;
        String prvsgstitle, prvsgsdesc, prvsgslk,prvsgsast;
        DateTime prvsgsdat;
        public int sgsid
        {
            get
            {
                return prvsgsid;
            }
            set
            {
                prvsgsid=value;
            }
        }

        public string sgstitle
        {
            get
            {
                return prvsgstitle;
            }
            set
            {
                prvsgstitle=value;
            }
        }

        public string sgsast
        {
            get
            {
                return prvsgsast;
            }
            set
            {
                prvsgsast = value;
            }
        }


        public string sgsdesc
        {
            get
            {
                return prvsgsdesc;
            }
            set
            {
                prvsgsdesc=value;
            }
        }

        public string sgslk
        {
            get
            {
                return prvsgslk;
            }
            set
            {
                prvsgslk=value;
            }
        }

        public DateTime sgsdat
        {
            get
            {
                return prvsgsdat;
            }
            set
            {
                prvsgsdat=value;
            }
        }

        public int sgsdatactgid
        {
            get
            {
                return prvsgsdatactgid;
            }
            set
            {
                prvsgsdatactgid=value;
            }
        }
    }

    public class clstbsgsdwnldsprp : inttbsgsdwnlds
    {
        Int32 prvsgsdwnldsid, prvsgsdwnldssgsid, prvsgsdwnldsno;
        public int sgsdwnldsid
        {
            get
            {
                return prvsgsdwnldsid;
            }
            set
            {
                prvsgsdwnldsid=value;
            }
        }

        public int sgsdwnldssgsid
        {
            get
            {
                return prvsgsdwnldssgsid;
            }
            set
            {
                prvsgsdwnldssgsid=value;
            }
        }

        public int sgsdwnldsno
        {
            get
            {
                return prvsgsdwnldsno;
            }
            set
            {
                prvsgsdwnldsno=value;
            }
        }
    }
    //property classes ending


    //connection class...
    public abstract class clscon
    {

        protected SqlConnection con = new SqlConnection();
        public clscon()
        {

            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
    //connection class ending...

    //main class........
    public class clstbsgsctg:clscon {
            public Int32 admin_login_check(String user, String pass)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("login_check", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 50).Value = user;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = pass;
            cmd.Parameters.Add("@cod", SqlDbType.Int);
            cmd.Parameters["@cod"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            cmd.Dispose();
            con.Close();
            return a;

        }
        public void save_rec(clstbsgsctgprp p) { 
               if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ins_tbsgsctg",con);
            cmd.CommandType=CommandType.StoredProcedure;
           cmd.Parameters.Add("@sgsctgnm",SqlDbType.VarChar,50).Value=p.sgsctgnm;
            
           cmd.Parameters.Add("@sgsctgdesc",SqlDbType.VarChar,100).Value=p.sgsctgdesc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void upd_rec(clstbsgsctgprp p)
        {
              if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upd_tbsgsctg",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsctgid",SqlDbType.Int).Value=p.sgsctgid;
           cmd.Parameters.Add("@sgsctgnm",SqlDbType.VarChar,50).Value=p.sgsctgnm;
            
           cmd.Parameters.Add("@sgsctgdesc",SqlDbType.VarChar,100).Value=p.sgsctgdesc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void del_rec(clstbsgsctgprp p)
        {
               if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("del_tbsgsctg",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsctgid",SqlDbType.Int).Value=p.sgsctgid;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public List<clstbsgsctgprp> find_rec(Int32 sgsctgid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsctg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsctgid", SqlDbType.Int).Value = sgsctgid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsctgprp> obj = new List<clstbsgsctgprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clstbsgsctgprp k = new clstbsgsctgprp();
                k.sgsctgid = Convert.ToInt32(dr[0]);
                k.sgsctgnm = dr[1].ToString();
                k.sgsctgdesc = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clstbsgsctgprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_tbsgsctg", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsctgprp> obj = new List<clstbsgsctgprp>();
            while (dr.Read())
            {
                
                clstbsgsctgprp k = new clstbsgsctgprp();
                k.sgsctgid = Convert.ToInt32(dr[0]);
                k.sgsctgnm = dr[1].ToString();
                k.sgsctgdesc = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
            

        }

    }
    public class clstbsgsdata:clscon {
        public void save_rec(clstbsgsdataprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ins_tbsgsdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgstitle", SqlDbType.VarChar, 20).Value = p.sgstitle;
            cmd.Parameters.Add("@sgsast", SqlDbType.VarChar, 50).Value = p.sgsast;
            cmd.Parameters.Add("@sgsdesc", SqlDbType.VarChar, 50).Value = p.sgsdesc;
            cmd.Parameters.Add("@sgslk", SqlDbType.VarChar, 100).Value = p.sgslk;
            cmd.Parameters.Add("@sgsdat", SqlDbType.DateTime).Value = p.sgsdat;
            cmd.Parameters.Add("@sgsdatactgid", SqlDbType.Int).Value = p.sgsdatactgid;

           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        
        }
        public void upd_rec(clstbsgsdataprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upd_tbsgsdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsid",SqlDbType.Int).Value=p.sgsid;
            cmd.Parameters.Add("@sgstitle", SqlDbType.VarChar, 20).Value = p.sgstitle;
            cmd.Parameters.Add("@sgsast", SqlDbType.VarChar, 50).Value = p.sgsast;
            cmd.Parameters.Add("@sgsdesc", SqlDbType.VarChar, 50).Value = p.sgsdesc;
            cmd.Parameters.Add("@sgslk", SqlDbType.VarChar, 100).Value = p.sgslk;
            cmd.Parameters.Add("@sgsdat", SqlDbType.DateTime).Value = p.sgsdat;
            cmd.Parameters.Add("@sgsdatactgid", SqlDbType.Int).Value = p.sgsdatactgid;


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clstbsgsdataprp p){
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("del_tbsgsdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsid", SqlDbType.Int).Value = p.sgsid;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public List<clstbsgsdataprp> find_rec(Int32 sgsid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsid", SqlDbType.Int).Value = sgsid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat =Convert.ToDateTime( dr[5].ToString());
                k.sgsdatactgid=Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clstbsgsdataprp> disp_rec()
        {
          
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_tbsgsdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while(dr.Read())
            {
                
                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        
    
    }

        public List<clstbsgsdataprp> disp_rec_latest_news()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_tbsgsdata_latest_news", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while (dr.Read())
            {

                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;



        }
        public List<clstbsgsdataprp> disp_rec_latest_hits()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_rec_latest_hits", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while (dr.Read())
            {

                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;



        }
        public List<clstbsgsdataprp> disp_rec_previous_hits()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_rec_previous_hits", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while (dr.Read())
            {

                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;



        }

        public List<clstbsgsdataprp> find_rec_ctg(Int32 sgsdatactgid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsdata_ctg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsdatactgid", SqlDbType.Int).Value = sgsdatactgid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while(dr.Read())
            {
                
                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }


        public List<clstbsgsdataprp> find_rec_ctg_sgs(Int32 sgsdatactgid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsdata_ctg_sgs", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsdatactgid", SqlDbType.Int).Value = sgsdatactgid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdataprp> obj = new List<clstbsgsdataprp>();
            while (dr.Read())
            {

                clstbsgsdataprp k = new clstbsgsdataprp();
                k.sgsid = Convert.ToInt32(dr[0]);
                k.sgstitle = dr[1].ToString();
                k.sgsast = dr[2].ToString();
                k.sgsdesc = dr[3].ToString();
                k.sgslk = dr[4].ToString();
                k.sgsdat = Convert.ToDateTime(dr[5].ToString());
                k.sgsdatactgid = Convert.ToInt32(dr[6]);

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
   
        
    }
    public class tbsgsdwnlds:clscon {
    public void save_rec(clstbsgsdwnldsprp p)
    {

          if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ins_tbsgsdwnlds", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
        
         cmd.Parameters.Add("@sgsdwnldssgsid",SqlDbType.Int).Value=p.sgsdwnldssgsid;


         cmd.Parameters.Add("@sgsdwnldno",SqlDbType.Int).Value=p.sgsdwnldsno;



           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
 
    
    }
        public void upd_rec(clstbsgsdwnldsprp p)
        {
            
          if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upd_tbsgsdwnlds", con);
            cmd.CommandType = CommandType.StoredProcedure;
       
        
         cmd.Parameters.Add("@sgsdwnldssgsid",SqlDbType.Int).Value=p.sgsdwnldssgsid;


         cmd.Parameters.Add("@sgsdwnldno",SqlDbType.Int).Value=p.sgsdwnldsno;



           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
 
        
        }
        public void del_rec(clstbsgsdwnldsprp p)
        {
        
          if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("del_tbsgsdwnlds", con);
            cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.Add("@sgsdwnldsid",SqlDbType.Int).Value=p.sgsdwnldsid;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
 
        }

          public List<clstbsgsdwnldsprp> find_rec(Int32 sgsdwnldsid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsdwnlds", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsdwnldsid", SqlDbType.Int).Value = sgsdwnldsid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdwnldsprp> obj = new List<clstbsgsdwnldsprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clstbsgsdwnldsprp k = new clstbsgsdwnldsprp();
                k.sgsdwnldsid= Convert.ToInt32(dr[0]);
                k.sgsdwnldssgsid= Convert.ToInt32(dr[1]);
                k.sgsdwnldsno= Convert.ToInt32(dr[2]);
              

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clstbsgsdwnldsprp> disp_rec()
        {
           if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disp_tbsgsdwnlds", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdwnldsprp> obj = new List<clstbsgsdwnldsprp>();
            while(dr.Read())
            {
             
                clstbsgsdwnldsprp k = new clstbsgsdwnldsprp();
                k.sgsdwnldsid= Convert.ToInt32(dr[0]);
                k.sgsdwnldssgsid= Convert.ToInt32(dr[1]);
                k.sgsdwnldsno= Convert.ToInt32(dr[2]);
              

                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        
    
    }

        public List<clstbsgsdwnldsprp> find_rec_sgs(Int32 sgsdwnldssgsid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("find_tbsgsdwnlds_sgsdwnldssgsid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sgsdwnldssgsid", SqlDbType.Int).Value = sgsdwnldssgsid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clstbsgsdwnldsprp> obj = new List<clstbsgsdwnldsprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clstbsgsdwnldsprp k = new clstbsgsdwnldsprp();
                k.sgsdwnldsid = Convert.ToInt32(dr[0]);
                k.sgsdwnldssgsid = Convert.ToInt32(dr[1]);
                k.sgsdwnldsno = Convert.ToInt32(dr[2]);


                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    
    }
    //main class end.....


}