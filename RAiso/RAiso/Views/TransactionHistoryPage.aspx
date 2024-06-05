<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="RAiso.Views.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .thgv {
            width: 50%;
            border-collapse: collapse;
            table-layout: auto;
            margin:auto;
        }

            .thgv th, .thgv td {
                background-color: #f2f2f2;
                padding: 8px;
                text-align: left;
                white-space: nowrap; /* Prevents wrapping of content */
                border-bottom: 1px solid #ddd; /* Add bottom border */
            }
    </style>
    <div>
        <h1 style="text-align: center;">Raiso's Transaction History</h1>
        <br />
    </div>
    <br />
    <br />
    <asp:GridView CssClass="thgv" ID="THGV" runat="server" AutoGenerateColumns="False" OnRowEditing="THGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="MsUser.UserName" HeaderText="Customer Name" SortExpression="MsUser.UserName" />
            <asp:CommandField ButtonType="Button" EditText="Detail" HeaderText="Action" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
