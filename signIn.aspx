<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master"
    AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="teachingPlatform.loginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <link href="App_Themes/Login/login.css" rel="stylesheet" />

<%--    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>--%>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form></form>
        <div class="container login-container" style="padding-top: 0px">
            <div class="row" style="text-align:center">
                <div class="col-md-6 login-form-1">
                    <h3>Sign In as Student</h3>
                    <form id="form2">
                        <div class="form-group">
                            <asp:TextBox ID="emailIDTextBoxStudent" runat="server" CssClass="form-control" placeholder="Email ID"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="passwordTextBoxStudent" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="signInButtonStudent" runat="server" Text="Sign In" CssClass="btnSubmit" OnClick="studentSignIn_Click" />
                        </div>
                        <div class="form-group">
                            <a href="#" class="ForgetPwd">Forgot Password?</a>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="WrongCredentialsStudent" runat="server" Text="" ForeColor="#1A6BE4"></asp:Label>
                        </div>
                    </form>
                </div>
                
                <div class="col-md-6 login-form-2">
                    <h3>Sign In as Teacher</h3>
                    <form id="form3">
                        <div class="form-group">
                            <asp:TextBox ID="emailIDTextBoxTeacher" runat="server" CssClass="form-control" placeholder="Email ID"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="passwordTextBoxTeacher" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="signInButtonTeacher" runat="server" Text="Sign In" CssClass="btnSubmit" OnClick="teacherSignIn_Click" />
                        </div>
                        <div class="form-group">
                            <a href="#" class="ForgetPwd" value="Login">Forgot Password?</a>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="WrongCredentialsTeacher" runat="server" Text="" ForeColor="White"></asp:Label>
                        </div>
                    </form>
                </div>

                <div>
                    <br />
                    <a href="signUp.aspx" class="ForgetPwd">Dont have an account? Sign Up</a>
                </div>
            </div>
        </div>

</asp:Content>
