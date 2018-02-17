<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UrediOsebo.aspx.cs" Inherits="UrediOsebo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ime osebe:
            <asp:TextBox ID="txtBIme" runat="server"></asp:TextBox>
            <br />
            <br />
            Priimek osebe:<asp:TextBox ID="txtBPriimek" runat="server"></asp:TextBox>
            <br />
            <br />
            Leto do:<asp:TextBox ID="txtBLetoDo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bttPotrdi" runat="server" OnClick="bttPotrdi_Click" Text="Potrdi" />
            <br />
        </div>
    </form>
</body>
</html>
