<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AFilm.aspx.cs" Inherits="AFilm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text4 {
            margin-top: 6px;
        }
        #Text7 {
            margin-top: 6px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 275px">
            Film Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilmName" runat="server"></asp:TextBox>
            <br />
            Film Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilmDesc" runat="server"></asp:TextBox>
            <br />
            Film Cert&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCert" runat="server"></asp:TextBox>
            <br />
            Release Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRelease" runat="server"></asp:TextBox>
            <br />
            Departure Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDeparture" runat="server"></asp:TextBox>
            <br />
            Currently Showing&nbsp;
            <asp:CheckBox ID="showingCheck" runat="server" />
            <br />
            <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="OK" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
