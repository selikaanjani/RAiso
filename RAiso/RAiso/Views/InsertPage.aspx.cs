using RAiso.Controllers;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using RAiso.Views;

namespace RAiso.Views
{
    public partial class InsertPage : System.Web.UI.Page
    {
        StationeryController sc = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            int id = sc.createID();
            String name = NameTB.Text;
            String price = PriceTB.Text;
            String response = sc.validasiInsert(name, price);
            if (response.Equals("Add stationary success!") == true)
            {
                int harga = Convert.ToInt32(PriceTB.Text);
                sc.createStationary(id, name, harga);
                Response.Redirect("~/Views/HomePage.aspx");
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