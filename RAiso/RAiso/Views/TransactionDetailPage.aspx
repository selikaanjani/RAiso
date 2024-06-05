<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="RAiso.Views.TransactionDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .tdgv {
            width: 50%;
            border-collapse: collapse;
            table-layout: auto;
            margin:auto;
        }

            .tdgv th, .tdgv td {
                background-color: #f2f2f2;
                padding: 8px;
                text-align: left;
                white-space: nowrap; 
                border-bottom: 1px solid #ddd; 
            }
    </style>
    <div>
        <h1 style="text-align: center;">Raiso's Transaction Detail</h1>
        <br />
    </div>
    <br />
    <br />
    <asp:GridView CssClass="tdgv" ID="GVTransactionDetails" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery's Name" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery's Price" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>
</asp:Content>
