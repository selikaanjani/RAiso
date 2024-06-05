<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="RAiso.Views.UpdatePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h3 style="text-align: center;">Update stationery page</h3>
    <div>
        <asp:Label ID="NameLbl" runat="server" Text=" Product Name"></asp:Label>
        <br />
        <asp:TextBox ID="NameTBUpdate" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="PriceTBUpdate" runat="server"></asp:TextBox>
    </div>
    <br />
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
    <br />
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" style="width: 100%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;" />
    </div>
</asp:Content>
