<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 399px;
        }
    </style>
</head>
<body style="height: 402px">
    <form id="form1" runat="server">
        customer id:
        <asp:TextBox ID="txtcustomerid" runat="server"></asp:TextBox>
        <br />
        first name:
        <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
        <br />
        last name:
        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
        <br />
        email:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        active
        <asp:CheckBox ID="boolactive" runat="server" />
        <br />
        create date:
        <asp:TextBox ID="txtcreatedate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ok" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" />
    </form>
</body>
</html>
