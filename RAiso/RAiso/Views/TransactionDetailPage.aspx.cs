using RAiso.Controllers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        TransactionDetailController tdc = new TransactionDetailController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();
            }
        }
        protected void refreshGV()
        {
            //try
            //{
            //    int transId = int.Parse(Request["ID"]);
            //    GVTransactionDetails.DataSource = tdc.fetchAllById(transId);
            //    GVTransactionDetails.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("~/Views/HomePage.aspx");
            //}
            int transId = int.Parse(Request["ID"]);
            GVTransactionDetails.DataSource = tdc.fetchAllById(transId);
            GVTransactionDetails.DataBind();

        }
    }
}