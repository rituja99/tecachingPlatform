<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="TeacherHomePage.aspx.cs" Inherits="teachingPlatform.TeacherHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_Themes/Homepage Cards/cards.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="text-white" style="padding-top:100px; height:100%; width:100%; background-image: linear-gradient(to bottom, #1a6be4, #2870e9, #3274ee, #3c79f3, #447ef8, #4b89fb, #5493fd, #5e9dff, #71aeff, #87beff, #9fcdff, #b9dcff); box-shadow: 0px 0px 40px 40px #B6DCFF">
            <div style="padding-left:100px">
                <h2 class="teacher-text">Welcome username</h2>
                <p class="teacher-text">Add some text here about something idk</p>
                <p class="teacher-text">More text</p>
                <br /><br /><br />
            </div>
        </div>
        <div style="padding:100px;" >
            <br />
            <h3 >Your Courses</h3>
            <br />
            <div class="page-content">
                <div class="card" style="border:none">
                    <div class="content">
                        <br /><br /><br /><br />
                        <h2 class="title">English</h2>
                        <button class="btn btn-primary">Go to Course</button>
                    </div>
                </div>

                <div class="card" style="border:none">
                    <div class="content">
                        <br /><br /><br /><br />
                        <h2 class="title">German</h2>
                        <button class="btn btn-primary">Go to Course</button>
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
