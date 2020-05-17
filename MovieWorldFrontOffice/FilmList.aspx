<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FilmList.aspx.cs" Inherits="FilmList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstFilmList" runat="server" Height="296px" Width="407px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Add_Click" Text="Add" />
        </p>
    </form>
</body>
</html>
