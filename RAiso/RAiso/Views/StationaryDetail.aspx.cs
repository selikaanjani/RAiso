using RAiso.Controllers;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace RAiso.Views
{
    public partial class StationaryDetail : System.Web.UI.Page
    {
        CartController cc = new CartController();
        StationaryController sc = new StationaryController();
        MsUser user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // kalau dia admin sama guest bisa liat aja
                // kalau customer ada add to cart button

                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    int id = int.Parse(Request["ID"]);
                    MsStationery curr = sc.searchById(id);
                    NameTB.Text = curr.StationeryName;
                    PriceTB.Text = curr.StationeryPrice.ToString();
                    NameTB.ReadOnly = true;
                    PriceTB.ReadOnly = true;
                    AddToCart.Visible = false;
                    QtyLbl.Visible = false;
                    QtyTB.Visible = false;
                }
                else
                {

                    if (Session["user"] == null)
                    {
                        int id = int.Parse(Request["ID"]);
                        MsStationery curr = sc.searchById(id);
                        NameTB.Text = curr.StationeryName;
                        PriceTB.Text = curr.StationeryPrice.ToString();
                        NameTB.ReadOnly = true;
                        PriceTB.ReadOnly = true;
                        AddToCart.Visible = false;
                        QtyLbl.Visible = false;
                        QtyTB.Visible = false;
                    }
                    else
                    {
                        user = (MsUser)Session["user"];
                    }
                    //customer
                    if (user.UserRole.Equals("Customer"))
                    {
                        int id = int.Parse(Request["ID"]);
                        MsStationery curr = sc.searchById(id);
                        NameTB.Text = curr.StationeryName;
                        PriceTB.Text = curr.StationeryPrice.ToString();
                        NameTB.ReadOnly = true;
                        PriceTB.ReadOnly = true;
                        //add to cart button
                        // validasi di cart handler
                        AddToCart.Visible = true;
                        QtyLbl.Visible = true;
                        QtyTB.Visible = true;

                    }
                    else
                    //admin
                    {
                        int id = int.Parse(Request["ID"]);
                        MsStationery curr = sc.searchById(id);
                        NameTB.Text = curr.StationeryName;
                        PriceTB.Text = curr.StationeryPrice.ToString();
                        NameTB.ReadOnly = true;
                        PriceTB.ReadOnly = true;
                        AddToCart.Visible = false;
                        QtyLbl.Visible = false;
                        QtyTB.Visible = false;
                    }
                }
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            String qty = QtyTB.Text;
            String response = cc.validateQty(qty);
            if (response.Equals("Add to cart success!") == true)
            {
                int kuantiti = Convert.ToInt32(QtyTB.Text);
                int id = int.Parse(Request["ID"]);
                MsUser user = (MsUser)Session["user"];
                int userID = user.UserID;
                cc.add(userID, id, kuantiti);
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