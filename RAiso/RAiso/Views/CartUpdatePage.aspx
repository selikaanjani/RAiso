<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="CartUpdatePage.aspx.cs" Inherits="RAiso.Views.CartUpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2 style="text-align: center;">Cart Update</h2>
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
    <div>
        <asp:Label ID="QtyLbl" runat="server" Text="Quantity:  "></asp:Label>
        <asp:TextBox ID="QtyTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>
