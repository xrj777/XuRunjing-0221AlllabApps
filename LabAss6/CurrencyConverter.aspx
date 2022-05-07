<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="LabAss6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1265px;
            height: 589px;
        }
    </style>
</head>
<body style="width: 1257px; height: 589px">
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Convert:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" Text="OK" />
    </form>
</body>
</html>
