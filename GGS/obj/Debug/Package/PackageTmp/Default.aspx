<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GGS.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTest" runat="server" BackColor="Black" ForeColor="Lime" BorderStyle="None" Height="250px" Rows="50" Width="100%" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtValue1" runat="server"></asp:TextBox>+<asp:TextBox ID="txtValue2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnTest" runat="server" Text="Send" OnClick="btnTest_Click" />
        </div>
    </form>
</body>
</html>
