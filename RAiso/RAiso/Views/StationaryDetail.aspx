<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="StationaryDetail.aspx.cs" Inherits="RAiso.Views.StationaryDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Stationary detail</h2>
    <br />
    <br />
    <div class="product">
        <h2>Product Name: </h2>
        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
        <br />
        <h2>Product Price:  </h2>
        <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>
    <br />
    <br />
    <!-- add to cart button -->
    <div>
        <asp:Label ID="QtyLbl" runat="server" Text="Quantity:  "></asp:Label>
        <asp:TextBox ID="QtyTB" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="AddToCart" runat="server" Text="Add to Cart" OnClick="AddToCart_Click"/>
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>
