<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Controls.Homework.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:label AssociatedControlID="textFirstName" runat="server" id="fName"  Text="First Name"/>
        <asp:textbox ID="textFirstName" runat="server"/>
        <br/>
        <asp:label AssociatedControlID="textLastName" runat="server" id="lName"  Text="Last Name"/>
        <asp:textbox ID="textLastName" runat="server"/>
        <br/>
        <asp:label AssociatedControlID="textFacNumber" runat="server" id="facNumber"  Text="Faculty number"/>
        <asp:textbox ID="textFacNumber" runat="server"/>
        <br/>
        <asp:label AssociatedControlID="textUniversity" runat="server" id="university"  Text="University"/>
        <asp:DropDownList ID="textUniversity" runat="server" AutoPostBack="true">
            <asp:ListItem value="SU Kliment Ohridski"></asp:ListItem>
            <asp:ListItem value="PU Paisii Hilendarski"></asp:ListItem>
            <asp:ListItem value="Tehnicheski universitet"></asp:ListItem>
        </asp:DropDownList>
        <br/>
        <asp:label AssociatedControlID="textSpecialty" runat="server" id="specialty"  Text="Specialty"/>
        <asp:CheckBoxList ID="textSpecialty" runat="server" SelectionMode="Multiple">
            <asp:ListItem value="HTML"></asp:ListItem>
            <asp:ListItem value="C#"></asp:ListItem>
            <asp:ListItem value="ASP.NET Web forms"></asp:ListItem>
        </asp:CheckBoxList>

        <br/>
        <asp:button ID="btnSubmit" runat="server" Text="Submit" OnClick="Submit_RegistrationForm"/>
        <br/>
        <asp:label ID="displaySubmited" runat="server"></asp:label>
    </div>
    </form>
</body>
</html>
