<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" AssociatedControlID="TextBoxFirstNumber" Text="First Number: "></asp:Label>
        <asp:TextBox ID="TextBoxFirstNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" AssociatedControlID="TextBoxSecondNumber" Text="Second Number: "></asp:Label>
        <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Calculate" runat="server" Text="Calculate" onClick="Button1_Click"/>
        <br />
        <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
    </div>
    </form>
</body>
</html>
