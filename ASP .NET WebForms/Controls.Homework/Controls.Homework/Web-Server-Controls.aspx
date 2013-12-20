<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web-Server-Controls.aspx.cs" Inherits="Controls.Homework.Web_Server_Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:label ID="labelRandom1" runat="server" Text="min number"></asp:label>
        <asp:textbox id="textRandom1" runat="server"/>
        <asp:label ID="labelRandom2" runat="server" Text="max number"></asp:label>
        <asp:textbox id="textRandom2" runat="server"/>
        <br/>
        <asp:button ID="submitRandom" runat="server" text="Submit" OnClick="Generate_Numbers"/>
        <br/>
        <asp:label ID="resultRandom" runat="server" Text="you get: "></asp:label>
        <asp:textbox ID="textResult" runat="server"/>
    </div>
    </form>
</body>
</html>
