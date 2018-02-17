<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UrediPodjetje.aspx.cs" Inherits="UrediPodjetje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Naziv podjetja:
            <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
            <br />
            <br />
            Panoga podjetja:
            <asp:TextBox ID="txtPanoga" runat="server"></asp:TextBox>
            <br />
            <br />
            Leto ustanovitve:
            <asp:TextBox ID="txtUstanovitev" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bttPotrdi" runat="server" OnClick="bttPotrdi_Click" Text="Potrdi" />
        </div>
    </form>
</body>
</html>
