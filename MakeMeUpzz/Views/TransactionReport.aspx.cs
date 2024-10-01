using MakeMeUpzz.Dataset;
using MakeMeUpzz.Models;
using MakeMeUpzz.Report;
using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.Web;

namespace MakeMeUpzz.Views
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1 data = GetData(TransactionHeaderHandler.getallTransaction());
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            report.SetDataSource(data);
        }

        private DataSet1 GetData(List<TransactionHeader> transactions)
        {
            DataSet1 dataSet = new DataSet1();
            var headerTable = dataSet.TransactionHeader;
            var detailTable = dataSet.TransactionDetail;

            foreach (TransactionHeader t in transactions)
            {
                int SubTotal = 0;
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;

                headerTable.Rows.Add(hrow);

                foreach (var d in t.TransactionDetails)
                {

                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MakeupID"] = d.MakeupID;
                    drow["Quantity"] = d.Quantity;

                    int makeupPrice = MakeupController.getMakeupPrice(d.MakeupID);
                    int totalPrice = d.Quantity * makeupPrice;
                    drow["TotalPrice"] = totalPrice;
                    SubTotal += totalPrice;

                    detailTable.Rows.Add(drow);
                }

                //hrow["SubTotal"] = SubTotal;

            }
            return dataSet;
        }
    }
}
