<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DEdiscussionForum.aspx.cs" Inherits="teachingPlatform.DEdiscussionForum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <title>Foreign Language Teaching Platform</title>
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" 
        rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" 
        crossorigin="anonymous">
  
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
        .auto-style1 {
            margin-left: 136px;
            margin-top: 36px;
        }
        .auto-style2 {
            height: 207px;
        }
        .auto-style3 {
            margin-left: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="div" runat="server" class="auto-style2">
        <asp:TextBox ID="discussTB" TextMode="MultiLine" Rows="40" Columns="30" runat="server"
      BackColor="#e4f4f8" CssClass="auto-style1" Height="68px" Width="442px" />
    </br></br>
         <asp:Button ID="postQuestion" Text="Question" runat="server" 
        CssClass="btn btn-primary" style="float: right; border-radius:10px; 
position:absolute; right: 198px; top: 359px; width: 100px; height: 29px;"
        OnClick="postQuestion_Click" />
        <asp:Button ID="postAnswer" Text="Answer" runat="server" 
        CssClass="btn btn-primary" style="float: right; border-radius:10px; 
position:absolute; right: 74px; top: 359px; width: 100px; height: 29px;"
        OnClick="postAnswer_Click" />
        <asp:Panel ID="panel" runat="server" CssClass="auto-style3" Height="49px" Width="452px" />
  </div>  
</asp:Content>
