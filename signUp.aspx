<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="teachingPlatform.signUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .border-md {
            border-width: 2px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row py-5 align-items-center">
        <div class="col-md-5 pr-lg-5 mb-5 mb-md-0">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/sign up girl.png" CssClass="img-fluid mb-3 d-none d-md-block"/>
            <h1>Sign Up to <i>Learn</i> today</h1>
            <p><i>Learn</i> will help you take your learning one step further by blurring the lines between a teacher and a student</p>
        </div>

        <div class="col-md-7 col-lg-6 ml-auto">
            <form action="#">
                <div class="row">

                    <div class="input-group col-lg-6 mb-4">
                        <asp:TextBox ID="txt_fullname" runat="server" placeholder="Full Name" CssClass="form-control bg-white border-left-0 border-md"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fullNameReq" runat="server" ControlToValidate="txt_fullname"
                         Display="None" ErrorMessage="Please enter your full name." />
                    </div>

                    <div class="input-group col-lg-12 mb-4">
                    <asp:TextBox ID="txt_emailid" runat="server" placeholder="Email Address" EnableViewState="false"
                        CssClass="form-control bg-white border-left-0 border-md"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txt_emailid"
                             Display="None" ErrorMessage="Please enter your Email Id." />
                        <asp:RegularExpressionValidator ID="emailreg" runat="server" ControlToValidate="txt_emailid"
                             Display="None" ErrorMessage="Please enter a valid Email Id."
                             ValidationExpression="\S+@\S+\.\S+"/>
                    </div>

                    <div class="input-group col-lg-12 mb-4">
                        <asp:DropDownList ID="modeDropDownList" runat="server" style="width:100%"
                            CssClass="custom-select form-control bg-white border-left-0 border-md h-100 font-weight-bold text-muted">
                            <asp:ListItem>Choose User Type</asp:ListItem>
                            <asp:ListItem>Student</asp:ListItem>
                            <asp:ListItem>Teacher</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="modeReq" runat="server" ControlToValidate="modeDropDownList"
                             Display="None" ErrorMessage="Please select your user type." />
                    </div>

                    <div class="input-group col-lg-6 mb-4">
                      <asp:TextBox ID="txt_password" runat="server" TextMode="Password" placeholder="Password" EnableViewState="false"
                            CssClass="form-control bg-white border-left-0 border-md"></asp:TextBox>
                    <asp:CustomValidator Display="None" ID="passwordValid" ControlToValidate="txt_password" runat="server"
                         OnServerValidate="passwordValid_ServerValidate"></asp:CustomValidator>
                        <asp:RequiredFieldValidator ID="passwordReq" Display="None" ControlToValidate="txt_password"
                            runat="server" ErrorMessage="Please enter the password." />
                    </div>
                    
                   <div class="input-group col-lg-6 mb-4">
                        <asp:TextBox ID="passwordConfirmationTextBox" runat="server" TextMode="Password"
                            placeholder="Confirm Password"
                            CssClass="form-control bg-white border-left-0 border-md"></asp:TextBox>
                        <asp:CompareValidator runat="server" ID="confirmPassword" 
                            ControlToValidate="passwordConfirmationTextBox"
                            ControlToCompare="txt_password" Display="None" ErrorMessage="The passwords do not match.">
                        </asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="confirmPasswordReq" Display="None" 
                            ControlToValidate="passwordConfirmationTextBox"
                            runat="server" ErrorMessage="Please re-enter your password." />
                    </div>

                    <div class="form-group col-lg-12 mx-auto mb-0">
                        <asp:Button ID="submitButton" runat="server" Text="Create Account"
                            CssClass="btn btn-primary btn-block py-2" 
                            OnClick="submitButton_Click" CausesValidation="true"
                            />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </div>
                    
                    <asp:ValidationSummary ShowMessageBox="true" ShowSummary="false" ID="ValidationSummary1"
                        runat="server" DisplayMode="BulletList" />
                    <div class="form-group col-lg-12 mx-auto d-flex align-items-center my-4">
                        <div class="border-bottom w-100 ml-5"></div>
                        <span class="px-2 small text-muted font-weight-bold text-muted">OR</span>
                        <div class="border-bottom w-100 mr-5"></div>
                    </div>

                    <div class="text-center w-100">
                        <p class="text-muted font-weight-bold">Already Registered? <a href="signIn.aspx" class="text-primary ml-2">Login</a></p>
                    </div>

                </div>
            </form>
        </div>
    </div>
</div>
</asp:Content>
