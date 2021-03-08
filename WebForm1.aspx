<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="teachingPlatform.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }
        form {
            border: 3px solid #f1f1f1;
        }
        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }
        button:hover {
            opacity: 0.8;
        }
        .cnbtn {
            background-color: #ec3f3f;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 49%;
        }
        .lgnbtn {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 50%;
        }
        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }
        img.avatar {
            width: 40%;
            border-radius: 50%;
        }
        .container {
            padding-top: 72px;

        }
        span.psw {
            float: right;
            padding-top: 16px;
        }
        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }
            .cnbtn {
                width: 100%;
            }
        }
        .frmalg {
            margin: auto;
            width: 40%;
        }
        .auto-style1 {
            padding: 16px;
            width: 375px;
            height: 140px;
            position: absolute;
            left: 493px;
            top: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="auto-style1">
            
            <center>
                <h1></h1>
                <h1>Student Login</h1>
            </center>
            <label for="uname"><b>Username</b></label>
            <asp:TextBox runat="server" ID="txt_Username"
                placeholder="Enter Username"></asp:TextBox>
            <asp:RequiredFieldValidator ID="username" ControlToValidate="txt_Username"
                Display="None" ErrorMessage="Please enter the username."></asp:RequiredFieldValidator>
            
            <label for="psw"><b>Password</b></label>
            <asp:TextBox runat="server" ID="txt_password" TextMode="Password"
                placeholder="Enter Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="password" ErrorMessage="Please enter the password"
                 Display="None" ControlToValidate="txt_password"></asp:RequiredFieldValidator>

            <asp:Button runat="server" ID="btn_Login" CssClass="lgnbtn" Text="Login"
                 OnClick="btn_Login_Click"/><br />
            <asp:HyperLink ID="registerHere" runat="server" NavigateUrl="~/registrationPage.aspx"
                 Text="Register Here" 
                ForeColor="#800000" Font-Bold="true" Font-Italic="true">
            </asp:HyperLink>
            </br></br>
            <center>
                <asp:Label ID="WrongCredentials" Font-Bold="true" ForeColor="#ff0000" runat="server" Text=""></asp:Label>

            </center>
            
        </div>
    

</asp:Content>