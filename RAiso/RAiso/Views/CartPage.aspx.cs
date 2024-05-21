using RAiso.Controllers;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class CartPage : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        StationeryController stationeryController = new StationeryController();
        TransactionDetailController transactionDetailController = new TransactionDetailController();
        TransactionHeaderController transactionHeaderController = new TransactionHeaderController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();

            }
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            Cart cart = cartController.getCartByUserId(UserID);
            List<Cart> carts = cartController.FetchAll();
            transactionHeaderController.add(UserID);
            transactionDetailController.addMultipleData(carts);
            refreshGV();
            Response.Redirect("~/Views/HomePage.aspx");
        }

        public void refreshGV()
        {
            CartGV.DataSource = cartController.FetchAll();
            CartGV.DataBind();
        }

        protected void CartGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CartGV.Rows[e.NewEditIndex];
            String Name = Convert.ToString(row.Cells[0].Text); //ambil id dari column paling kiri
            int stationeryId = stationeryController.getStationeryIdByName(Name);
            Response.Redirect("~/Views/CartUpdatePage.aspx?id=" + stationeryId);
            refreshGV();
        }

        protected void CartGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            GridViewRow row = CartGV.Rows[e.RowIndex];
            String Name = Convert.ToString(row.Cells[0].Text); //ambil id dari column paling kiri
            int stId = stationeryController.getStationeryIdByName(Name);
            cartController.delete(UserID, stId);
            refreshGV();
            Response.Redirect("~/Views/CartPage.aspx");
        }
    }
}