using RAiso.Handlers;
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
        TransactionHeaderHandler thh = new TransactionHeaderHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();
            }
        }

        public void refreshGV() 
        {
            THGV.DataSource = thh.fetchAll();
            THGV.DataBind();
        }

        protected void THGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = THGV.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text.ToString());
            Response.Redirect("~/Views/TransactionDetailPage.aspx?id=" + id);
            refreshGV();
        }
    }
}