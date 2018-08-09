<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     
   
    <form id="form1" runat="server">
         <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />

        <div>

            <div class="demo-container">
                
            <telerik:RadHtmlChart runat="server" ID="RadHtmlChart1" Height="400px" Width="580px" >
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
            <div>
                
		<telerik:RadHtmlChart ID="RadHtmlChart2" runat="server" Width="800" Height="500">
		</telerik:RadHtmlChart>
            </div>
        </div>
    </form>
</body>
</html>
