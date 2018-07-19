<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl1" Text="Cookie Demo:" runat="server"></asp:Label> <br /> <br />
        <asp:Label ID="labelId" runat="server">UserName</asp:Label> 
        <asp:TextBox ID="txtusername" runat="server" ToolTip="Enter Username"></asp:TextBox> <br />
        <asp:Label ID="labelPass" runat="server">Password  </asp:Label>
        <asp:TextBox ID="txtpassword" TextMode="Password"  ToolTip="Enter Password" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button Text="Submit" runat="server" ID="btn1" OnClick="btn1_Click" />

    </div>
    </form>
</body>
</html>
