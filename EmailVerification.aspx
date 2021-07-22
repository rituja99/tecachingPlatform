<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="EmailVerification.aspx.cs" Inherits="teachingPlatform.EmailVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_Themes/Login/forgotPW.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="vertical-align: middle; text-align: center"><h3>Verification link has been sent to your registered email address</h3></div>
<div class="reset-body">
		<div class="card login-form">
			<div class="card-body">
				<h3 class="card-title text-center">&nbsp;</h3>
				<div class="card-text">
					<div class="reset-form">
						<div class="form-group">
							Enter OTP sent in the mail:<br /><br />
							<asp:TextBox ID="TextBox1" runat="server" TextMode="Number" placeholder="Enter OTP" CssClass="form-control form-control-sm"></asp:TextBox>
						</div>
						<asp:Button ID="SendEmailButton" runat="server" OnClick="SubmitClick" Text="Submit" CssClass="btn btn-primary btn-block"/>
						<br />
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
					</div>
				</div>
			</div>
		</div>
	</div>
			</div>
</asp:Content>
