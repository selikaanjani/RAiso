using RAiso.Controllers;
using RAiso.Dataset;
using RAiso.Models;
using RAiso.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        TransactionHeaderController thController = new TransactionHeaderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();

            CrystalReportViewer1.ReportSource = report;
            RAisoDataset data = getData(thController.fetchAll());
            report.SetDataSource(data);

            GVTransactions.DataSource = thController.fetchAll();
            GVTransactions.DataBind();
        }

        private RAisoDataset getData(List<TransactionHeader> transactionHeaders)
        {
            RAisoDataset data = new RAisoDataset();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            foreach (TransactionHeader t in transactionHeaders)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                headerTable.Rows.Add(hrow);

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["StationeryID"] = d.StationeryID;
                    drow["Quantity"] = d.Quantity;
                    detailTable.Rows.Add(drow); 
                }
            }
            return data;
        }
    }
}