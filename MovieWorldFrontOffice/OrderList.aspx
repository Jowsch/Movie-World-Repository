<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="561px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="562px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" />
    &nbsp;&nbsp;<asp:Button ID="Edit" runat="server" OnClick="ButtonUpdate_Click2" Text="Edit" />
        &nbsp;
        <asp:Button ID="btnDel" runat="server" OnClick="ButtonDelete_Click1" Text="Delete" />
        <br />
        <br />
        Enter a CustomerID to search for:
        <asp:TextBox ID="CustomerIdInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Apply" runat="server" OnClick="ButtonApply_Click3" Text="Apply" />
        <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
Order