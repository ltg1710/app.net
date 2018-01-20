<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="VB_Code_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Create" runat="server" Text="Create" />
            <br />
            Name:<asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:Button ID="Write" runat="server" Text="Write" />
        </div>
    </form>
</body>
</html>
