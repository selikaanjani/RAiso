<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavbarGuest.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RAiso.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Login</h3>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberCb" runat="server" Text="Remember me"/>
        </div>
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
        </div>
        <div style="color: red">
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
