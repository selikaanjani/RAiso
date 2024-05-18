<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="RAiso.Views.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Raiso's Cart</h1>
        <br />
    </div>
    <br />
    <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False" OnRowEditing="CartGV_RowEditing" OnRowDeleting="CartGV_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="StationeryName" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="StationeryPrice" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:CommandField ButtonType="Button" EditText="Update" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <br />
    <div>
        <asp:Button ID="BtnCheckout" runat="server" onclick="BtnCheckout_Click" Text="Checkout" />
    </div>
</asp:Content>
