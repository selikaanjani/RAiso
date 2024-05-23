using RAiso.Controllers;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        UserController uc = new UserController();
        StationeryController sc = new StationeryController();
        public List<MsStationery> stationeries = new List<MsStationery>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Guest
                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    InsertBtn.Visible = false;
                    refreshTable();
                    foreach (GridViewRow row in StGV.Rows)
                    {
                        row.Cells[3].Controls[0].Visible = false;
                        row.Cells[3].Controls[2].Visible = false;
                    }
                }
                else
                {
                    MsUser user;

                    if (Session["user"] == null)
                    {
                        int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                        user = uc.getUserByID(id);
                        Session["user"] = user;
                        InsertBtn.Visible = false;
                        InsertBtn.Visible = false;
                        refreshTable();
                        foreach (GridViewRow row in StGV.Rows)
                        {
                            row.Cells[3].Controls[0].Visible = false;
                            row.Cells[3].Controls[2].Visible = false;
                        }

                    }
                    else
                    {
                        user = (MsUser)Session["user"];
                    }
                    //customer
                    if (user.UserRole.Equals("Customer"))
                    {
                        InsertBtn.Visible = false;
                        refreshTable();
                        foreach (GridViewRow row in StGV.Rows)
                        {
                            row.Cells[3].Controls[0].Visible = false;
                            row.Cells[3].Controls[2].Visible = false;
                        }
                    }
                    else
                    //admin
                    {
                        InsertBtn.Visible = true;
                        refreshTable();
                    }
                }
            }
        }

        public void refreshTable()
        {
            List<MsStationery> list = sc.viewAllStationary();
            StGV.DataSource = list;
            StGV.DataBind();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertPage.aspx?");
        }

        protected void StGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = StGV.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text.ToString());
            Response.Redirect("~/Views/UpdatePage.aspx?id=" + id);
            refreshTable();
        }

        protected void StGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = StGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text); //ambil id dari column paling kiri
            sc.popStationary(id);
            refreshTable();
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void StGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(StGV.Rows[index].Cells[0].Text);
                Response.Redirect("~/Views/StationaryDetail.aspx?id=" + id);
            }

        }
    }
}