<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="teachingPlatform.ForgotPasswordStudent1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="App_Themes/Login/forgotPW.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="reset-body">
		<div class="card login-form">
			<div class="card-body">
				<h3 class="card-title text-center"><b>Reset Password</b></h3>
				<div class="card-text">
					<div class="reset-form">
						<div class="form-group">
							<asp:Label ID="Label1" runat="server" Text="Enter an email address to recieve the password reset link." Font-Size="16px"></asp:Label>
							<br /><br />
							<asp:TextBox ID="TextBox1" runat="server" TextMode="Email" placeholder="Enter your email address" CssClass="form-control form-control-sm"></asp:TextBox>
						</div>
						<asp:Button ID="SendEmailButton" runat="server" Text="Send email" CssClass="btn btn-primary btn-block" OnClick="SendEmail_Click" />
						<br />
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
