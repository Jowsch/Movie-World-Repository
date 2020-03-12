<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AFilm.aspx.cs" Inherits="Default2" %>

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
            <input id="Text1" type="text" /><br />
            Film Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="Text2" type="text" /><br />
            Film Cert&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="Text4" type="text" /><br />
            Release Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="Text3" type="text" /><br />
            Departure Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="Text5" type="text"/><br />
            <input id="Checkbox1" type="checkbox" />&nbsp; Currently Showing<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
