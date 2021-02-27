<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true" CodeBehind="registrationPage.aspx.cs"
    Inherits="teachingPlatform.registrationPage" %>

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
            padding: 16px;
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
            width: 571px;
            margin-left: 373px;
            margin-top: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <center>
                <h1>Student Registration</h1>
            </center>
       
        <label for="uname"><b>FullName</b></label>
        <asp:TextBox runat="server" ID="txt_fullname" placeholder="Enter fullname"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_fullname"
            ErrorMessage="Please enter your fullname"
            Display="None"></asp:RequiredFieldValidator>

        <label for="psw"><b>Email ID</b></label>
        <asp:TextBox runat="server" ID="txt_emailid" placeholder="Enter Email ID"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_emailid"
            ErrorMessage="Please enter your email ID"
            Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator runat="server" ErrorMessage="Please enter your Email ID" ControlToValidate="txt_emailid"
            Display="None" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>

        <label for="psw"><b>Password</b></label>
        <asp:TextBox runat="server" ID="txt_password" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_password"
            ErrorMessage="Please enter password"
            Display="None"></asp:RequiredFieldValidator>

        <label for="psw"><b>Re-enter Password</b></label>
        <asp:TextBox runat="server" ID="txt_repassword" TextMode="Password" placeholder="Re-enter password"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_repassword"
            ErrorMessage="Please re-enter the password"
            Display="None"></asp:RequiredFieldValidator>
        <asp:CompareValidator ControlToValidate="txt_repassword" runat="server"
            ControlToCompare="txt_password"
            Display="None" ErrorMessage="Passwords do not match"></asp:CompareValidator>
        <asp:CustomValidator id ="passwordValid" runat="server" Display="Dynamic" Font-Bold="true"
            OnServerValidate="passwordValid_ServerValidate" ></asp:CustomValidator>

        <asp:Button runat="server" ID="btn_register" CssClass="lgnbtn" Text="Register"
            CausesValidation="true" OnClick="btn_register_Click" />
        <asp:Button runat="server" ID="btn_cancel"
            Text="Cancel" class="cnbtn" CausesValidation="false"
            OnClick="btn_cancel_Click" />
        <asp:ValidationSummary ShowMessageBox="true" ShowSummary="false" DisplayMode="BulletList"
            runat="server" ID="errors"/></br></br></br>
        <asp:Label ID="error" runat="server"></asp:Label>
    </div>
</asp:Content>
