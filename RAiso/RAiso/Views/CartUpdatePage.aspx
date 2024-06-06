<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="CartUpdatePage.aspx.cs" Inherits="RAiso.Views.CartUpdatePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .product {
            width: 50%;
            margin: 0 auto;
            background-color: #ffffff;
            border: 1px solid #ced4da;
            border-radius: 5px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

            .product label {
                font-weight: bold;
                margin-bottom: 5px;
                display: block;
            }

            .product input[type="text"] {
                width: calc(100% - 10px);
                padding: 10px;
                border: 1px solid #ced4da;
                border-radius: 3px;
            }

            .product .insert-button {
                width: 100%;
                background-color: #007bff;
                color: #ffffff;
                border: none;
                border-radius: 3px;
                padding: 10px;
                font-size: 1.1rem;
                cursor: pointer;
                transition: background-color 0.3s;
            }

        .error-message {
            color: red;
            margin-top: 10px;
        }
    </style>

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
    <div class="product">
        <asp:Label ID="QtyLbl" runat="server" Text="Quantity:  "></asp:Label>
        <asp:TextBox ID="QtyTB" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"
            Style="margin: 0 auto; display: block; width: 50%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>
