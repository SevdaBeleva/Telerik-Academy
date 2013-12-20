<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTML-Contrlos.aspx.cs" Inherits="Controls.Homework.HTML_Contrlos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="textRandom1">min number: </label>
        <input id="textRandom1" type="text" runat="server"/>
        <label for="textRandom2">max number: </label>
        <input id="textRandom2" type="text" runat="server"/>
        <br/>
        <input id="buttonRandom" type="button" runat="server" value="Submit" onserverClick="Generate_Numbers"/>
        <br/>
        <label for="textRandom1">your get: </label>
        <input id="textRezult" type="text" runat="server"/>
    </div>
    </form>
</body>
</html>
