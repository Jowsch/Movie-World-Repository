<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div style="height: 257px">
            Order No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" style="height: 26px" />
            <br />
            <br />
            Date Of Order:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDateOfOrder" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
            <br />
            <br />
            Total Cost:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
            <br />
            <br />
            Staff Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            <br />
            <br />
            Available Seats:&nbsp;&nbsp;
            <asp:TextBox ID="txtAvailableSeats" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonOk" runat="server" OnClick="ButtonOk_Click" Text="Ok" />
                &nbsp;&nbsp;
                <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
