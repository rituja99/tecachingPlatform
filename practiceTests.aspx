<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="practiceTests.aspx.cs" Inherits="teachingPlatform.practiceTests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        width: 42%;
        height: 41px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1" style="background-color:powderblue">
  <div class="container">
      <asp:Label ID="Label1" Font-Size="Larger" runat="server" Text="1. "/>  
      <asp:HyperLink ID="HyperLink1" runat="server" Text="Practice Test-1" Font-Size="Larger"
          ForeColor="#000000"
          NavigateUrl="https://forms.office.com/Pages/ResponsePage.aspx?id=Qr2-Kf_xPUyWiAZ-NGDcH1GoZ25E7ShBk0qdRvRrjBZUN05aWTk1MzJNTEJOU0hSUjFRUTlTQlpPUS4u"/>
  </div>
</div>
</asp:Content>
