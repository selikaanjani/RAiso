<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RAiso.Views.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Login</h3>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:CheckBox ID="RememberCb" runat="server" Text="Remember me" />
            <br />
        </div>
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
            <br />
        </div>
        <div style="color: red">
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </div>
</asp:Content>
