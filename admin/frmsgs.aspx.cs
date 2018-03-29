using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_frmsgs : System.Web.UI.Page
{
    nsgaanamania.clstbsgsdata obj = new nsgaanamania.clstbsgsdata();
    nsgaanamania.clstbsgsdataprp objprp = new nsgaanamania.clstbsgsdataprp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void clear_rec()
    {
        txttitle.Text = string.Empty;
        txtast.Text = string.Empty;
        txtdesc.Text = string.Empty;
        txtlk.Text = string.Empty;
    }
    protected void btn_saverec_Click(object sender, EventArgs e)
    {

        if (btn_saverec.Text == "Update")
        {
            try
            {
                objprp.sgsid = Convert.ToInt32(ViewState["cod"]);


                objprp.sgstitle = txttitle.Text;
                objprp.sgsast = txtast.Text;
                objprp.sgsdesc = txtdesc.Text;
                objprp.sgslk = txtlk.Text;
                objprp.sgsdat = DateTime.Now;
                objprp.sgsdatactgid = Convert.ToInt32(DropDownList1.SelectedValue);

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
            objprp.sgstitle = txttitle.Text;
            objprp.sgsast = txtast.Text;
            objprp.sgsdesc = txtdesc.Text;
            objprp.sgslk = txtlk.Text;
            objprp.sgsdat = DateTime.Now;
            objprp.sgsdatactgid = Convert.ToInt32(DropDownList1.SelectedValue);
      

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

        }

    
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            objprp.sgsid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);

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
            List<nsgaanamania.clstbsgsdataprp> k = obj.find_rec(a);
            txttitle.Text = k[0].sgstitle;
            txtast.Text = k[0].sgsast;
            txtlk.Text = k[0].sgslk;
            txtdesc.Text = k[0].sgsdesc;
            btn_saverec.Text = "Update";
            btncnl.Visible = true;
            ViewState["cod"] = a;
            GridView1.DataBind();
            GridView1.EditIndex = -1;
            e.Cancel = true;
        }
        catch(Exception ex)
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