<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GermanPracticeTestsTeacher.aspx.cs" Inherits="teachingPlatform.GermanPracticeTestsTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="text-white" style="padding-top:50px; height:100%; width:100%; background-image: linear-gradient(to bottom, #1a6be4, #2870e9, #3274ee, #3c79f3, #447ef8, #4b89fb, #5493fd, #5e9dff, #71aeff, #87beff, #9fcdff, #b9dcff); box-shadow: 0px 0px 40px 40px #B6DCFF">
           <div style="padding-left:100px; font-family: 'Inter', sans-serif;">
                <h1>German Practice Tests</h1>
                <div style="float:right; height: 45%; width: 45%; flex-wrap: wrap">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/clip-reading-of-books.png" Height="100%" Width="100%" style="float: right;" />
                </div>
                <br />
                <div>
                    <h4>Uploaded Tests</h4>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </div>
            </div>
        </div>

        <div style="padding:100px; font-family: 'Inter', sans-serif; float:left">
            <h4>Upload Practice Test</h4>
            <h6 style="color: darkslategray">Only MS Forms link accepted</h6> 
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="input-group input-group-text" placeholder="Enter test link"></asp:TextBox> <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="input-group input-group-text" placeholder="Enter test name"></asp:TextBox> <br />
            <asp:Button ID="UploadButton" runat="server" Text="Upload" CssClass="btn btn-primary" OnClick="UploadButton_Click" />
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="DarkSlateGray"></asp:Label>
        </div>
    </div>
</asp:Content>
