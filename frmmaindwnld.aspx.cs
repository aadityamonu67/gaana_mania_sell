using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public partial class frmmaindwnld : System.Web.UI.Page
{
    nsgaanamania.clstbsgsdata obj = new nsgaanamania.clstbsgsdata();
    nsgaanamania.clstbsgsdataprp objprp = new nsgaanamania.clstbsgsdataprp();
    protected void Page_Load(object sender, EventArgs e)
    {

        List<nsgaanamania.clstbsgsdataprp> k = obj.find_rec(Convert.ToInt32(Request.QueryString["sgsid"]));
        DataList1.DataSource = k;
        DataList1.DataBind();

       
        

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        
        nsgaanamania.tbsgsdwnlds obj = new nsgaanamania.tbsgsdwnlds();
        nsgaanamania.clstbsgsdwnldsprp objprp = new nsgaanamania.clstbsgsdwnldsprp();
        if (e.CommandName == "abck")
        {
            List<nsgaanamania.clstbsgsdwnldsprp> k = obj.find_rec_sgs(Convert.ToInt32(Request.QueryString["sgsid"]));
            if (k.Count==0)
            {
                objprp.sgsdwnldsno = 1;
                objprp.sgsdwnldssgsid =Convert.ToInt32( Request.QueryString["sgsid"]);
                obj.save_rec(objprp);
                
                // insert query
            }
            else {
                //update query
                objprp.sgsdwnldssgsid = Convert.ToInt32(Request.QueryString["sgsid"]);
                objprp.sgsdwnldsno = k[0].sgsdwnldsno+1;
                obj.upd_rec(objprp);
            }
                Response.Redirect(e.CommandArgument.ToString());

        }
    }
}