using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RadHtmlChartGroupDataSource.GroupDataSource(RadHtmlChart1, GetRawDataSource1(), "Year", "AreaSeries", "Sales", "Quarter");
        RadHtmlChartGroupDataSource.GroupDataSource(RadHtmlChart4, GetRawDataSourcePurchase(), "Year", "LineSeries", "Sales", "Quarter");
        RadHtmlChartGroupDataSource.GroupDataSource(RadHtmlChart2, GetRawDataSourceRevenue(), "Category", "ColumnSeries", "Sales", "Quarter");

        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        var a = sc.GetSaleData();

        RadHtmlChart3.DataSource = a;
        RadHtmlChart3.DataBind();
    }

    private DataTable GetRawDataSource1()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Year", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));

        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        var col = sc.GetQuarterlySales();
        foreach (ServiceReference2.SalesCommon element in col)
        {
            dtDataPoints.Rows.Add(new object[] { element.Year, element.Quarter, element.Sales });
        }
       
        return dtDataPoints;
    }

    private DataTable GetRawDataSourcePurchase()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Year", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));


        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        var col = sc.GetPurchase();
        foreach (ServiceReference2.SalesCommon element in col)
        {
            dtDataPoints.Rows.Add(new object[] { element.Year, element.Quarter, element.Sales });
        }


        return dtDataPoints;
    }

    private DataTable GetRawDataSourceRevenue()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Category", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));


        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        var col = sc.GetRevenue();
        foreach (ServiceReference2.SalesCommon element in col)
        {
            dtDataPoints.Rows.Add(new object[] { element.Year, element.Quarter, element.Sales });
        }


        return dtDataPoints;
    }

    //private DataTable GetRawDataSource()
    //{
    //    DataTable dtDataPoints = new DataTable();

    //    dtDataPoints.Columns.Add(new DataColumn("Year", typeof(string)));
    //    dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
    //    dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));
    //    dtDataPoints.Columns.Add(new DataColumn("Purchases", typeof(int)));

    //    dtDataPoints.Rows.Add(new object[] { "2012", "Q1", 210000, 110000 });
    //    dtDataPoints.Rows.Add(new object[] { "2012", "Q2", 320000, 250000 });
    //    dtDataPoints.Rows.Add(new object[] { "2012", "Q3", 280000, 300000 });
    //    dtDataPoints.Rows.Add(new object[] { "2012", "Q4", 400000, 350000 });
    //    dtDataPoints.Rows.Add(new object[] { "2014", "Q1", 350000, 100000 });
    //    dtDataPoints.Rows.Add(new object[] { "2014", "Q2", 380000, 180000 });
    //    dtDataPoints.Rows.Add(new object[] { "2014", "Q3", 350000, 280000 });
    //    dtDataPoints.Rows.Add(new object[] { "2014", "Q4", 420000, 300000 });

    //    return dtDataPoints;
    //}
}