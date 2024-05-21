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
    public partial class CartUpdatePage : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        StationeryController stationeryController = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["ID"]);
                MsStationery stationery = stationeryController.searchById(id);
                NameTB.Text = stationery.StationeryName;
                PriceTB.Text = stationery.StationeryPrice.ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String qty = QtyTB.Text;
            String response = cartController.validateQty(qty);
            if (response.Equals("Add to cart success!") == true)
            {
                int stationeryId = int.Parse(Request["ID"]);
                MsUser user = (MsUser)Session["user"];
                int UserID = user.UserID;
                int Quantity = Convert.ToInt32(QtyTB.Text);
                cartController.update(UserID, stationeryId, Quantity);
                Response.Redirect("~/Views/CartPage.aspx");
            }
            else
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Visible = true;
                ErrorLbl.Text = response;
            }
        }
    }
}