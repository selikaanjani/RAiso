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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        TransactionHeaderController transactionHeaderController = new TransactionHeaderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();
            }
        }

        public void refreshGV() 
        {
            MsUser user = (MsUser)Session["user"];
            int UserID = user.UserID;
            THGV.DataSource = transactionHeaderController.fetchAllById(UserID);
            THGV.DataBind();
        }

        protected void THGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = THGV.Rows[e.NewEditIndex];
            int transId = Convert.ToInt32(row.Cells[0].Text.ToString());
            Response.Redirect("~/Views/TransactionDetailPage.aspx?id=" + transId);
            refreshGV();
        }
    }
}