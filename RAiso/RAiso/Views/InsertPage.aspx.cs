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
        StationeryHandler sh = new StationeryHandler();
        StationaryController sc = new StationaryController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            int id = sh.buatID();
            String name = NameTB.Text;
            int price = Convert.ToInt32(PriceTB.Text);
            String response = sc.validasiInsert(name, price);
            if (response.Equals("Add stationary success!") == true)
            {
                sh.add(id, name, price);
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