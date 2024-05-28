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
        StationeryController sc = new StationeryController();
        TransactionHeaderController thController = new TransactionHeaderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();

            CrystalReportViewer1.ReportSource = report;
            RaisoDataset data = getData(thController.fetchAll());
            report.SetDataSource(data);
        }

        private RaisoDataset getData(List<TransactionHeader> transactionHeaders)
        {
            RaisoDataset data = new RaisoDataset();
            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;

            foreach (TransactionHeader t in transactionHeaders)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                decimal grandTotal = 0;

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    MsStationery st = sc.searchById(d.StationeryID);
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["StationeryName"] = st.StationeryName;
                    drow["StationeryPrice"] = st.StationeryPrice;
                    drow["Quantity"] = d.Quantity;
                    drow["SubTotal"] = d.Quantity * st.StationeryPrice;
                    grandTotal += d.Quantity * st.StationeryPrice;
                    detailTable.Rows.Add(drow); 
                }
                hrow["GrandTotal"] = grandTotal;
                headerTable.Rows.Add(hrow);
            }
            return data;
        }
    }
}