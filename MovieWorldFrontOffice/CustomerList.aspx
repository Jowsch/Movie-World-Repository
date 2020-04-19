<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 750px;
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
    &nbsp;&nbsp;<asp:Button ID="Edit" runat="server" OnClick="Button1_Click2" Text="Edit" />
        &nbsp;
        <asp:Button ID="btnDel" runat="server" OnClick="Button1_Click1" Text="Delete" />
        <br />
        <br />
        Enter an email to search for:
        <asp:TextBox ID="emailInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Apply" runat="server" OnClick="Button1_Click3" Text="Apply" />
        <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
