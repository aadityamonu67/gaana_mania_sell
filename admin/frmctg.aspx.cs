using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_frmctg : System.Web.UI.Page
{
    nsgaanamania.clstbsgsctg obj = new nsgaanamania.clstbsgsctg();
    nsgaanamania.clstbsgsctgprp objprp = new nsgaanamania.clstbsgsctgprp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void clear_rec()
    {
        txtnm.Text = string.Empty;
        txtdesc.Text = string.Empty;

    }
    protected void btn_saverec_Click(object sender, EventArgs e)
    {
        if (btn_saverec.Text == "Update")
        {
            try
            {
                objprp.sgsctgid = Convert.ToInt32(ViewState["cod"]);


                objprp.sgsctgnm = txtnm.Text;
                objprp.sgsctgdesc = txtdesc.Text;


                obj.upd_rec(objprp);
                GridView1.DataBind();
                btncnl.Visible = false;
                btn_saverec.Text = "Add";
                clear_rec();
            }
            catch (Exception ex)
            {
                Response.Redirect("../error.aspx");
            }
        }
        else
        {

            objprp.sgsctgnm = txtnm.Text;
            objprp.sgsctgdesc = txtdesc.Text;



            try
            {

                obj.save_rec(objprp);
                GridView1.DataBind();
                clear_rec();
            }

            catch (Exception ex)
            {
                Response.Redirect("../error.aspx");
            }




            try
            {
                objprp.sgsctgnm = txtnm.Text;
                objprp.sgsctgdesc = txtdesc.Text;
                obj.save_rec(objprp);
                clear_rec();
            }
            catch (Exception ex)
            {
                Response.Redirect("../error.aspx");
            }
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            objprp.sgsctgid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);

            obj.del_rec(objprp);
            GridView1.DataBind();
            e.Cancel = true;
          
        }
        catch (Exception ex)
        {
            Response.Redirect("../error.aspx");
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
            Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
            List<nsgaanamania.clstbsgsctgprp> k = obj.find_rec(a);
            txtnm.Text = k[0].sgsctgnm;

            txtdesc.Text = k[0].sgsctgdesc;
            btn_saverec.Text = "Update";
            btncnl.Visible = true;
            ViewState["cod"] = a;
            GridView1.DataBind();
            GridView1.EditIndex = -1;
            e.Cancel = true;
        }
        catch (Exception ex)
        {
            Response.Redirect("../error.aspx");
        }
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }

        catch (Exception ex)
        {
            Response.Redirect("../error.aspx");
        }
    }
    protected void btncnl_Click(object sender, EventArgs e)
    {
        try
        {
            clear_rec();
            GridView1.EditIndex = -1;
            GridView1.DataBind();
            btn_saverec.Text = "Add";
            btncnl.Visible = false;
        }
        catch (Exception ex)
        {
            Response.Redirect("../error.aspx");
        }
    }
}