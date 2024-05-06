<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavbarGuest.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="RAiso.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Register</h3>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="DobLbl" runat="server" Text="DOB: "></asp:Label>
            <asp:TextBox ID="DobTxt" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="GenderLbl" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="MaleBtn" runat="server" text="Male" GroupName="GenderBtn"/>
            <asp:RadioButton ID="FemaleBtn" runat="server" text="Female" GroupName="GenderBtn"/>
        </div>
        <div>
            <asp:Label ID="AddressLbl" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="AddressTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PhoneLbl" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="PhoneTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/>
        </div>
        <div style="color: red">
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
