<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>EIS - Sales DashBoard</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
  <style>
  .fakeimg {
      height: 200px;
      background: #aaa;
  }
  </style>
</head>
<body>

        <form id="form1" runat="server">
         <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />

<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <a class="navbar-brand" href="#">EIS - Sales DashBoard</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="collapsibleNavbar">
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link" href="#">Orders</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Products</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Customers</a>
      </li>    
        <li class="nav-item">
        <a class="nav-link" href="#">Reports</a>
      </li> 
    </ul>
  </div>  
</nav>

<div class="container" style="margin-top:30px">
  <div class="row">
    <div class="col-sm-6">
      
      
      <div >
          <telerik:RadHtmlChart ID="RadHtmlChart1" Skin="Vista" runat="server" Width="400" Height="250">
              <ChartTitle Text="Quarterly Sales">
                </ChartTitle>
               <PlotArea>

               <XAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false"/>

</XAxis>
 
<YAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false" />
</YAxis>
                </PlotArea>
		</telerik:RadHtmlChart>
      </div>
      
     
    </div>
    <div class="col-sm-6">
      
      
      <div >
           <telerik:RadHtmlChart ID="RadHtmlChart2" runat="server" Width="400" Height="250">
               <ChartTitle Text="Revenue in Years">
                </ChartTitle>
               <PlotArea>

               <XAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false"/>

</XAxis>
 
<YAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false" />
</YAxis>
                </PlotArea>
		</telerik:RadHtmlChart>
      </div>
      
      
    </div>
  </div>

    <div class="row">
    <div class="col-sm-6">
      
      
      <div >
          <telerik:RadHtmlChart runat="server" ID="RadHtmlChart3" Width="400" Height="250" >
                <PlotArea>
                    <Series>
                        <telerik:PieSeries DataFieldY="Quantity" NameField="Category" ExplodeField="IsExploded">
                            <LabelsAppearance DataFormatString="{0}%">
                            </LabelsAppearance>
                            <TooltipsAppearance Color="White" DataFormatString="{0}%"></TooltipsAppearance>
                        </telerik:PieSeries>
                    </Series>
                    <YAxis>
                    </YAxis>
                </PlotArea>
                <ChartTitle Text="Sales By Product Category">
                </ChartTitle>
            </telerik:RadHtmlChart>
      </div>
      
     
    </div>
    <div class="col-sm-6">
      
     
      <div >
           <telerik:RadHtmlChart ID="RadHtmlChart4" Skin="Silk" runat="server" Width="400" Height="250">
		<PlotArea>
                    <XAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false"/>

</XAxis>
 
<YAxis>
    <MajorGridLines Visible="false" />
    <MinorGridLines Visible="false" />
</YAxis>
		</PlotArea>
       <ChartTitle Text="Purchase History">
                </ChartTitle>
           </telerik:RadHtmlChart>
      </div>
      
      
    </div>
  </div>
</div>

<div class="jumbotron text-center" style="margin-bottom:0">
 
</div>
</form>
</body>
</html>


