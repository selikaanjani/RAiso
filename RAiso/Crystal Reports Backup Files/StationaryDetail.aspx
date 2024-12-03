<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="StationaryDetail.aspx.cs" Inherits="RAiso.Views.StationaryDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .product {
            width: 300px;
            margin: 0 auto;
            text-align: center;
            margin: 0 auto;
            padding: 20px;
            top: 40%;
            left: 50%;
            position: absolute;
            transform: translate(-50%, -50%);
        }

            .product h2 {
                font-size: 1.2rem;
                margin-bottom: 10px;
            }

            .product input[type="text"] {
                width: 30%;
                padding: 8px;
                border: 1px solid #ccc;
                border-radius: 3px;
                margin-bottom: 10px;
            }

            .product button {
                width: 100%;
                background-color: #007bff;
                color: #fff;
                cursor: pointer;
                transition: background-color 0.3s;
                border: none;
                border-radius: 3px;
                padding: 10px;
                font-size: 1.1rem;
            }

                .product button:hover {
                    background-color: #0056b3;
                }

        .error {
            color: red;
            text-align: center;
            margin-top: 10px;
        }

        .qty {
            width: 300px;
            text-align: center;
            margin: 0 auto;
            padding: 20px;
            top: 60%;
            left: 50%;
            position: absolute;
            transform: translate(-50%, -50%);
            font-size: 1.2rem;
        }

        .qty input[type="text"] {
            width: 30%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 3px;
            margin-bottom: 30px;
        }
    </style>
    <h2 style="text-align: center;">Stationary detail</h2>
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
    <div class="qty">
        <asp:Label ID="QtyLbl" runat="server" Text="Quantity:  "></asp:Label>
        <asp:TextBox ID="QtyTB" runat="server"></asp:TextBox>
        <asp:Button ID="AddToCart" runat="server" Text="Add to Cart" OnClick="AddToCart_Click" Style="width: 50%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;" />
        <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
    </div>
</asp:Content>
