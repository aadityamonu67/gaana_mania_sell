using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmadmlogin : System.Web.UI.Page
{
    nsgaanamania.clstbsgsctg obj = new nsgaanamania.clstbsgsctg();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 a = obj.admin_login_check(txteml.Text, txtpwd.Text);
        if (a == -1)
        {
            Response.Redirect("error.aspx");
        }


        else
        {
            Session["cod"] = a;
            Response.Redirect("admin/frmadmidx.aspx");
        }
    }
}