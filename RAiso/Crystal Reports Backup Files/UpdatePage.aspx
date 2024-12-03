<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="RAiso.Views.UpdatePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .container {
            width: 50%;
            margin: 0 auto;
            background-color: #ffffff;
            border: 1px solid #ced4da;
            border-radius: 5px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

            .container label {
                font-weight: bold;
                margin-bottom: 5px;
                display: block;
            }

            .container input[type="text"] {
                width: calc(100% - 10px);
                padding: 10px;
                border: 1px solid #ced4da;
                border-radius: 3px;
            }

            .container .insert-button {
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

                .container .insert-button:hover {
                    background-color: #0056b3;
                }

        .error-message {
            color: red;
            margin-top: 10px;
        }
    </style>
    <br />
    <br />
    <h2 style="text-align: center;">Update stationery page</h2>
    <br />
    <br />
    <div class="container" >
        <asp:Label ID="NameLbl" runat="server" Text=" Product Name"></asp:Label>
        <br />
        <asp:TextBox ID="NameTBUpdate" runat="server"></asp:TextBox>
    </div>
    <br />
    <div class="container">
        <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="PriceTBUpdate" runat="server"></asp:TextBox>
    </div>
    <br />
    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false"></asp:Label>
    <br />
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" Style="margin: 0 auto; display: block; width: 30%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;" />
    </div>
</asp:Content>
