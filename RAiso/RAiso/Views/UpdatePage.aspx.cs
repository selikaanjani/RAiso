using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAiso.Controllers;

namespace RAiso.Views
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        StationeryHandler sh = new StationeryHandler();
        StationaryController sc = new StationaryController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["ID"]);
                MsStationery st = sh.searchById(id);
                if (st == null)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
                NameTBUpdate.Text = st.StationeryName;
                PriceTBUpdate.Text = st.StationeryPrice.ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"]);
            String name = NameTBUpdate.Text;
            int price = Convert.ToInt32(PriceTBUpdate.Text);
            String response = sc.validasiInsert(name, price);
            if (response.Equals("Add stationary success!") == true)
            {
                sh.updateStationary(id, name, price);
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