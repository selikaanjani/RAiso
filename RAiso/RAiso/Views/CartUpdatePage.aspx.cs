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
        StationeryHandler sh = new StationeryHandler();
        CartHandlers ch = new CartHandlers();
        CartController cc = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["ID"]);
                MsStationery curr = sh.searchById(id);
                NameTB.Text = curr.StationeryName;
                PriceTB.Text = curr.StationeryPrice.ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String qty = QtyTB.Text;
            String response = cc.validateQty(qty);
            if (response.Equals("Add to cart success!") == true)
            {
                int id = int.Parse(Request["ID"]);
                MsUser user = (MsUser)Session["user"];
                int UserID = user.UserID;
                int Quantity = Convert.ToInt32(QtyTB.Text);
                ch.update(UserID, id, Quantity);
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