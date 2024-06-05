<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAiso.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/styles.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .myGridView {
            width: 50%;
            border-collapse: collapse;
            table-layout: auto;
            margin: auto;
        }

            .myGridView th, .myGridView td {
                background-color: #f2f2f2;
                padding: 8px;
                text-align: left;
                white-space: nowrap; /* Prevents wrapping of content */
                border-bottom: 1px solid #ddd; /* Add bottom border */
            }

            .myGridView th {
                background-color: #DEE2E6; /* Light gray background for headers */
            }

            .myGridView tr:nth-child(even) {
                background-color: #f9f9f9;
            }

            .myGridView tr:hover {
                background-color: #f1f1f1;
            }

            .myGridView .aspNetDisabled {
                color: #999;
                background-color: #f2f2f2;
                cursor: not-allowed;
            }

        .myButtons {
            padding: 8px 12px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
            margin-right: 5px; /* Margin untuk tombol pertama */
        }

            .myButtons:last-child {
                margin-right: 0; /* Menghapus margin kanan untuk tombol kedua */
            }

            .myButtons:hover {
                background-color: #0056b3;
            }
    </style>
    <div>
        <br />
        <br />
        <h1 style="text-align: center;">Raiso's stationeries</h1>
        <br />
    </div>
    <asp:Button ID="InsertBtn" runat="server" Text="Insert another stationeries here!" OnClick="InsertBtn_Click" Style="background-color: #495057; color: white; padding: 10px 20px; border-radius: 5px;" />
    <br />
    <br />
    <asp:GridView CssClass="myGridView" ID="StGV" runat="server" AutoGenerateColumns="False" OnRowEditing="StGV_RowEditing" OnRowDeleting="StGV_RowDeleting" OnRowCommand="StGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="Stationary ID" SortExpression="StationeryID" />
            <asp:BoundField DataField="StationeryName" HeaderText="Stationary Name" SortExpression="StationeryName" />
            <asp:BoundField DataField="StationeryPrice" HeaderText="Stationary Price" SortExpression="StationeryPrice" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ItemStyle-CssClass="myButtons" />
            <asp:ButtonField CommandName="Detail" HeaderText="Detail" ShowHeader="True" Text="Select" ItemStyle-CssClass="myButtons" />

        </Columns>
    </asp:GridView>
</asp:Content>
