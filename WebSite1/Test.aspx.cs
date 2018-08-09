using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ServiceReference1 sr = new ServiceReference1();

        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        var a=sc.GetSaleData();

        RadHtmlChart1.DataSource = a;
        RadHtmlChart1.DataBind();

        RadHtmlChartGroupDataSource.GroupDataSource(RadHtmlChart2, GetRawDataSource(), "Year", "BarSeries", "Sales", "Quarter");


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