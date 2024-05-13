<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAiso.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="~/Styles/styles.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Raiso's stationeries</h1>
        <br />
    </div>
    <asp:Button ID="InsertBtn" runat="server" Text="Insert another stationeries here!" OnClick="InsertBtn_Click" />
    <br />
    <br />
    <asp:GridView ID="StGV" runat="server" AutoGenerateColumns="False" OnRowEditing="StGV_RowEditing" OnRowDeleting="StGV_RowDeleting" OnRowCommand="StGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="Stationary ID" SortExpression="StationeryID" />
            <asp:BoundField DataField="StationeryName" HeaderText="Stationary Name" SortExpression="StationaryName" />
            <asp:BoundField DataField="StationeryPrice" HeaderText="Stationary Price" SortExpression="StationeryPrice" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            <asp:ButtonField CommandName="Detail" HeaderText="Detail" ShowHeader="True" Text="Select" />

        </Columns>
    </asp:GridView>


</asp:Content>
