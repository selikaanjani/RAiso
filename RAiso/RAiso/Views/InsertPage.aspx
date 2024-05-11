<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="RAiso.Views.InsertPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- isi content web di sini -->
    <br />
    <h3>Insert stationery page</h3>
    <br />
    <br />

    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>
    </div>
    <br />
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible ="false"></asp:Label>
    <br />
    <div>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
    </div>

</asp:Content>
