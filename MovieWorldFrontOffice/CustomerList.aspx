<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 649px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="561px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="562px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDel" runat="server" OnClick="Button1_Click1" Text="Delete" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
