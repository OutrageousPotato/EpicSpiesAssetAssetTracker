<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpiesAssetAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
            height: 150px;
        }
    </style>
</head>
<body style="font-family: Arial, Helvetica, sans-serif">
    <form id="form1" runat="server">
        <div>

            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><h2>Asset Performance Tracker</h2>
            Asset Name:&nbsp;
        <asp:TextBox ID="assetNameTextbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections rigged:&nbsp;
        <asp:TextBox ID="electionsRiggedTextbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:&nbsp;
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
