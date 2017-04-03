<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Masteraspx.aspx.cs" Inherits="Masteraspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="100%">
            <tr>
                <%-- For left navigation--%>
                <td style="width: 30%" valign="top">
                    left navigatin pane
                    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE"

                        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em"

                        ForeColor="#284E98" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#B5C7DE" />
                        <DynamicSelectedStyle BackColor="#507CD1" />
                        <Items>
                            <asp:MenuItem Text="Menu1" Value="Menu1"></asp:MenuItem>
                            <asp:MenuItem Text="Menu2" Value="Menu2"></asp:MenuItem>
                            <asp:MenuItem Text="Menu3" Value="Menu3"></asp:MenuItem>
                            <asp:MenuItem Text="Menu4" Value="Menu4"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#507CD1" />
                    </asp:Menu>
                </td>
                <%--For content place holder--%>
                <td style="width: 70%">
                   
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
