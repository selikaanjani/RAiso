<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="RAiso.Views.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .cartGV {
            width: 50%;
            border-collapse: collapse;
            table-layout: auto; 
            margin: auto
        }

            .cartGV th, .cartGV td {
                background-color: #f2f2f2;
                padding: 8px;
                text-align: left;
                white-space: nowrap; /* Prevents wrapping of content */
                border-bottom: 1px solid #ddd; /* Add bottom border */
            }
    </style>
    <div>
        <h1 style="text-align: center;">Raiso's Cart</h1>
        <br />
    </div>
    <br />
    <asp:GridView CssClass="cartGV" ID="CartGV" runat="server" AutoGenerateColumns="False" OnRowEditing="CartGV_RowEditing" OnRowDeleting="CartGV_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="StationeryName" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="StationeryPrice" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:CommandField ButtonType="Button" EditText="Update" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <br />
    <div>
       <asp:Button ID="BtnCheckout" runat="server" OnClick="BtnCheckout_Click" Text="Checkout" style="width: 50%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem; margin: auto; display: block;" />

    </div>
</asp:Content>
