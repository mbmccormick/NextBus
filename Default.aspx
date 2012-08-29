<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NextBus.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NextBus</title>
    <!--<meta http-equiv="refresh" content="20" />-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="page">
            <div id="header">
                <asp:Label ID="lblStopName" runat="server" />
            </div>
            <div id="content">
                <asp:ListView ID="lstStopTimes" runat="server">
                    <ItemTemplate>
                        <div class="stopTime <%# Eval("CssClass") %>">
                            <div class="routeNumber">
                                <%# Eval("RouteNumber") %>
                            </div>
                            <div class="routeName">
                                <%# Eval("RouteName") %>
                            </div>
                            <div class="arrivalTime">
                                <%# Eval("FriendlyArrivalTime") %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
