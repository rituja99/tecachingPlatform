<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="teachingPlatform.StudentHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_Themes/Header/header.css" rel="stylesheet" />
         <meta name="viewport" content="width=device-width, initial-scale=1">
<style>
.card {
  box-shadow: 0 4px 8px 0 rgba(0,0,0);
  transition: 0.3s;
  width: 40%;
}

.card:hover {
  box-shadow: 0 8px 16px 0 rgba(0,0,0);
}

.container {
  padding: 2px 16px;
}
    .auto-style1 {
        box-shadow: 0 4px 8px 0 rgba(0,0,0);
        transition: 0.3s;
        width: 30%;
        height: 146px;
        margin-left: 482px;
        margin-top: 75px;
    }
    .auto-style2 {
        padding: 2px 16px;
        width: 352px;
        height: 122px;
        margin-left: 0px;
        margin-top: 0px;
    }
    .auto-style3 {
        box-shadow: 0 4px 8px 0 rgba(0,0,0);
        transition: 0.3s;
        width: 30%;
        height: 149px;
        margin-left: 484px;
        margin-top: 28px;
    }
    .auto-style4 {
        width: 56px;
        height: 51px;
    }
    .auto-style5 {
        width: 82px;
        height: 70px;
    }
    .auto-style7 {
        width: 103%;
        max-width: 1320px;
        height: 90px;
        margin-left: auto;
        margin-right: auto;
        padding: 2px 16px;
        margin-top: 29px;
    }
    .auto-style10 {
        width: 100%;
        height: 518px;
    }
</style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="auto-style10">
     <div class="auto-style1" style="background-color:powderblue">
  <div class="auto-style2">
      <asp:Label ID="Label1" Font-Size="Larger" runat="server" Text="English"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <img alt="" src="english.png" class="auto-style5" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <div class="form-group col-lg-12 mx-auto mb-0" style="margin-top: 0px">
          <asp:Button ID="submitButton0" runat="server" CssClass="btn btn-primary btn-block py-2"
              OnClick="submitButton0_Click" Text="Go To Course" Width="118px" />
      </div>
          </div>
</div>
        </br>
    <div class="auto-style3" style="background-color:powderblue">
  <div class="auto-style7">
      <asp:Label ID="Label2" Font-Size="Larger" runat="server" Text="German"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;  
      <img alt="" src="german.png" class="auto-style4" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <div class="form-group col-lg-12 mx-auto mb-0" style="width: 389px; height: 34px; margin-top: 0px;">
                        <asp:Button ID="submitButton" runat="server" Text="Go To Course"
                            CssClass="btn btn-primary btn-block py-2" OnClick="submitButton_Click" Width="123px" />
                        <br />
                    </div>
          </div>
</div>
        <asp:Label ID="label" runat="server" />
    </div>
       
</asp:Content>
