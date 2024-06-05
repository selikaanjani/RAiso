<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RAiso.Views.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .container {
            width: 300px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            top: 50%;
            left: 50%;
            position: absolute;
            transform: translate(-50%, -50%);
        }

            .container h3 {
                text-align: center;
                margin-bottom: 20px;
                padding: 20px;
            }

            .container div {
                margin-bottom: 10px;
            }

            .container input[type="text"],
            .container input[type="password"],
            .container input[type="checkbox"],
            .container button {
                width: calc(100% - 10px);
                padding: 10px;
                border: 1px solid #ccc;
                border-radius: 3px;
            }

            .container input[type="checkbox"] {
                width: auto;
                margin-left: 5px;
            }

            .container .error {
                color: red;
                text-align: center;
                margin-bottom: 10px;
            }
    </style>
    <div class="container">
        <h3>Login</h3>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:CheckBox ID="RememberCb" runat="server" Text="Remember me" />
            <br />
        </div>
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" style="width: 100%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;" />
            <br />
        </div>
        <div style="color: red">
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </div>
</asp:Content>
