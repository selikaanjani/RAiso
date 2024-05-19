<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="RAiso.Views.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Raiso's Transaction Detail</h1>
    <br />
    </div>
    <br />
    <br />
    <asp:GridView ID="GVTransDetails" runat="server" AutoGenerateColumns="false"></asp:GridView>
</asp:Content>
