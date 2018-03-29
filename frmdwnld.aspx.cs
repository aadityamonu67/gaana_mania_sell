using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmdwnld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList3_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "abc1")
        {
            Response.Redirect("frmdispsgs.aspx?ctgid="+e.CommandArgument.ToString());
        }
        
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
       

        if (e.CommandName == "abc2")
        {
            //latest hits
            Response.Redirect("frmmaindwnld.aspx?sgsid=" + e.CommandArgument.ToString());
        }
      


    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "abc3")
        {
            //previous hits
            Response.Redirect("frmmaindwnld.aspx?sgsid=" + e.CommandArgument.ToString());
        }

    }
}