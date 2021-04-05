<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="teachingPlatform.LandingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Inter&display=swap" rel="stylesheet">--%>
    <link href="App_Themes/Header/header.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="text-white" style="height:400px; background-image: linear-gradient(to bottom, #1a6be4, #2870e9, #3274ee, #3c79f3, #447ef8, #4b89fb, #5493fd, #5e9dff, #71aeff, #87beff, #9fcdff, #b9dcff); box-shadow: 0px 0px 40px 40px #B6DCFF">
            <div style="float:left">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/study.png" Height="60%" Width="60%" />
            </div>
            <div class="container py-5 text-end" >
                <h2 style="padding-top:10%">Join <i>Learn</i> Today</h2>
                <p>Learn by teaching your peers</p>
            </div>

        </div>
    </div>

    <div>
        
    </div>
    
</asp:Content>
