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
       

        dtDataPoints.Rows.Add(new object[] { "2017", "Q1", 2100 });
        dtDataPoints.Rows.Add(new object[] { "2017", "Q2", 3200 });
        dtDataPoints.Rows.Add(new object[] { "2017", "Q3", 2800 });
        dtDataPoints.Rows.Add(new object[] { "2017", "Q4", 3800 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q1", 3500 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q2", 3800 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q3", 3500 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q4", 4100 });

        return dtDataPoints;
    }

    private DataTable GetRawDataSourcePurchase()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Year", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));


        dtDataPoints.Rows.Add(new object[] { "2018", "Q1", 2200 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q2", 3400 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q3", 2900 });
        dtDataPoints.Rows.Add(new object[] { "2018", "Q4", 4400 });
 

        return dtDataPoints;
    }

    private DataTable GetRawDataSourceRevenue()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Category", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));


        dtDataPoints.Rows.Add(new object[] { "Sales", "2015", 2200 });
        dtDataPoints.Rows.Add(new object[] { "Sales", "2016", 3400 });
        dtDataPoints.Rows.Add(new object[] { "Sales", "2017", 2900 });
        dtDataPoints.Rows.Add(new object[] { "Sales", "2018", 4400 });


        return dtDataPoints;
    }

    private DataTable GetRawDataSource()
    {
        DataTable dtDataPoints = new DataTable();

        dtDataPoints.Columns.Add(new DataColumn("Year", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Quarter", typeof(string)));
        dtDataPoints.Columns.Add(new DataColumn("Sales", typeof(int)));
        dtDataPoints.Columns.Add(new DataColumn("Purchases", typeof(int)));

        dtDataPoints.Rows.Add(new object[] { "2012", "Q1", 210000, 110000 });
        dtDataPoints.Rows.Add(new object[] { "2012", "Q2", 320000, 250000 });
        dtDataPoints.Rows.Add(new object[] { "2012", "Q3", 280000, 300000 });
        dtDataPoints.Rows.Add(new object[] { "2012", "Q4", 400000, 350000 });
        dtDataPoints.Rows.Add(new object[] { "2014", "Q1", 350000, 100000 });
        dtDataPoints.Rows.Add(new object[] { "2014", "Q2", 380000, 180000 });
        dtDataPoints.Rows.Add(new object[] { "2014", "Q3", 350000, 280000 });
        dtDataPoints.Rows.Add(new object[] { "2014", "Q4", 420000, 300000 });

        return dtDataPoints;
    }
}