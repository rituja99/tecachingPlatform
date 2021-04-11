<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="TeacherHomePage.aspx.cs" Inherits="teachingPlatform.TeacherHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_Themes/Homepage Cards/cards.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="text-white" style="padding-top:100px; height:100%; width:100%; background-image: linear-gradient(to bottom, #1a6be4, #2870e9, #3274ee, #3c79f3, #447ef8, #4b89fb, #5493fd, #5e9dff, #71aeff, #87beff, #9fcdff, #b9dcff); box-shadow: 0px 0px 40px 40px #B6DCFF">
           
            <div style="padding-left:100px">
                <h2 class="teacher-text">Welcome <asp:Label ID="TeacherName" runat="server" Text=""></asp:Label></h2>
                <p class="teacher-text">A good teacher makes all the difference to a student's life</p>
                <%--<div style="float:right; height: 45%; width: 45%; flex-wrap: wrap; padding-right:50px">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/clip-99.png" Height="55%" Width="55%" style="float: right;" />
                </div>--%>
                <p class="teacher-text"></p>
                <br /><br />
            </div>
        </div>
        
        <div style="padding-left:100px; padding-top:100px;" >
            <br />
            <h3 class="page-content">Available Courses</h3>
            <br />
            <div class="page-content">
                <div class="card" style="border:none">
                    <div class="content">
                        <br /><br /><br /><br />
                        <h2 class="title">English</h2>
                        <asp:Button ID="EnglishButton" runat="server" Text="Go to Course" CssClass="btn btn-primary" PostBackUrl="~/EnglishStudyMaterialsTeacher.aspx" />
                    </div>
                </div>

                <div class="card" style="border:none">
                    <div class="content">
                        <br /><br /><br /><br />
                        <h2 class="title">German</h2>
                        <asp:Button ID="GermanButton" runat="server" Text="Go to Course" CssClass="btn btn-primary" PostBackUrl="~/GermanStudyMaterialsTeacher.aspx" />
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
