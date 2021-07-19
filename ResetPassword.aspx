<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="teachingPlatform.ResetPassword" %>
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
							<asp:Label ID="Label1" runat="server" Text="Enter new password." Font-Size="16px"></asp:Label>
							<br />
							<asp:TextBox ID="TextBox1" runat="server" TextMode="Password" placeholder="Enter new password" CssClass="form-control form-control-sm"></asp:TextBox>
							<br /><br />
							<asp:Label ID="Label2" runat="server" Text="Re-Enter new password." Font-Size="16px"></asp:Label>
							<br />
							<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="Re-Enter new password" CssClass="form-control form-control-sm"></asp:TextBox>
						</div>
						<asp:Button ID="ResetButton" runat="server" Text="Reset" CssClass="btn btn-primary btn-block" OnClick="Reset_Click" />
						<br />
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
