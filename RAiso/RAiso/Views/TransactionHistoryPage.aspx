<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="RAiso.Views.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Raiso's Transaction History</h1>
        <br />
    </div>
    <br />
    <br />
    <asp:GridView ID="THGV" runat="server" AutoGenerateColumns="False" OnRowEditing="THGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="MsUser.UserName" HeaderText="Customer Name" SortExpression="MsUser.UserName" />
            <asp:CommandField ButtonType="Button" EditText="Detail" HeaderText="Action" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
