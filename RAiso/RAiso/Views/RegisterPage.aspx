<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="RAiso.Views.RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .container {
            width: 300px;
            margin: 0 auto;
            padding: 20px;
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
            font-size: 1.5rem;
            position:center;

        }

        .container div {
            margin-bottom: 10px;
        }

        .container input[type="text"],
        .container input[type="password"],
        .container input[type="date"] {
            width: calc(100% - 10px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        .container input[type="radio"] {
            margin: 0 5px;
        }

        .container button {
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

        .container button:hover {
            background-color: #0056b3;
        }

        .container .error {
            color: red;
            text-align: center;
            margin-bottom: 10px;
        }
    </style>
    <div class="container">
        <h3>Register</h3>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server" placeholder="Joddy Hartono"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="DobLbl" runat="server" Text="DOB: "></asp:Label>
            <asp:TextBox ID="DobTxt" runat="server" TextMode="Date"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="GenderLbl" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="MaleBtn" runat="server" Text="Male" GroupName="GenderBtn" />
            <asp:RadioButton ID="FemaleBtn" runat="server" Text="Female" GroupName="GenderBtn" />
            <br />
        </div>
        <div>
            <asp:Label ID="AddressLbl" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="AddressTxt" runat="server" placeholder="Tangerang City"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" placeholder="**************"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label ID="PhoneLbl" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="PhoneTxt" runat="server" placeholder="085219827345"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" style="width: 100%; background-color: #7a7a7a; color: #fff; cursor: pointer; transition: background-color 0.3s; border: none; border-radius: 3px; padding: 10px; font-size: 1.1rem;"/>
            <br />
        </div>
        <div style="color: red">
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </div>
</asp:Content>
