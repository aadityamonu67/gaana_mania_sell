using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmdispsgs : System.Web.UI.Page
{
    nsgaanamania.clstbsgsdata obj = new nsgaanamania.clstbsgsdata();
    protected void Page_Load(object sender, EventArgs e)
    {
        List<nsgaanamania.clstbsgsdataprp> k = obj.find_rec_ctg_sgs(Convert.ToInt32( Request.QueryString["ctgid"]));
        DataList3.DataSource = k;
        DataList3.DataBind();

    }

    protected void DataList3_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "abc1")
        {
            Response.Redirect("frmmaindwnld.aspx?sgsid=" + e.CommandArgument.ToString());
        }
    }
}