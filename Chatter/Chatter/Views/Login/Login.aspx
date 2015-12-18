<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Chatter.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>Login Page</div>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Login1" />
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                You are not logged in. Click the Login link to sign in.<br />
            </AnonymousTemplate>
            <LoggedInTemplate>
                You are logged in. Welcome,
                <asp:LoginName ID="LoginName1" runat="server" />
            </LoggedInTemplate>
        </asp:LoginView>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </form>
</body>
</html>
