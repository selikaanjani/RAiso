using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace RAiso.Views
{
    public partial class CartPage : System.Web.UI.Page
    {
        CartHandlers ch = new CartHandlers();
        StationeryHandler sh = new StationeryHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();

            }
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            TransactionHeaderHandlers thh = new TransactionHeaderHandlers();
            TransactionDetailHandler tdh = new TransactionDetailHandler();

            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            
            

            List<Cart> carts = getAllUserID(UserID);
            DateTime date = DateTime.Now;

            thh.add(thh.generateID(), UserID, date);

            foreach (Cart cart in carts)
            {

            }
            db.SaveChanges();
            ch.deleteAll(UserID);
            refreshGV();
            Response.Redirect("~/Views/HomePage.aspx");
        }

        public void refreshGV()
        {
            CartGV.DataSource = ch.fetchAll();
            CartGV.DataBind();
        }

        protected void CartGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CartGV.Rows[e.NewEditIndex];
            String Name = Convert.ToString(row.Cells[0].Text); //ambil id dari column paling kiri
            MsStationery stationery = sh.searchByName(Name);
            int stId = stationery.StationeryID;
            Response.Redirect("~/Views/CartUpdatePage.aspx?id=" + stId);
            refreshGV();
        }

        protected void CartGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            GridViewRow row = CartGV.Rows[e.RowIndex];
            String Name = Convert.ToString(row.Cells[0].Text); //ambil id dari column paling kiri
            MsStationery stationery = sh.searchByName(Name);
            int stId = stationery.StationeryID;
            ch.delete(UserID, stId);
            refreshGV();
            Response.Redirect("~/Views/CartPage.aspx");
        }
    }
}