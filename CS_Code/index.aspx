<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="CS_Code_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:Button ID="Read" runat="server" OnClick="Read_Click" Text="Read" />
        </div>
    </form>
</body>
</html>
