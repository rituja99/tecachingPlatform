<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ENstudyMaterials.aspx.cs" Inherits="teachingPlatform.ENstudyMaterials" %>
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
    .auto-style2 {
        padding: 2px 16px;
        width: 305px;
        height: 51px;
    }
    .auto-style3 {
        box-shadow: 0 4px 8px 0 rgba(0,0,0);
        transition: 0.3s;
        width: 44%;
        height: 56px;
        margin-left: 61px;
    }
    .auto-style4 {
        box-shadow: 0 4px 8px 0 rgba(0,0,0);
        transition: 0.3s;
        width: 44%;
        height: 61px;
        margin-left: 61px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    </br>
     <div class="auto-style4" style="background-color:powderblue">
  <div class="auto-style2">
      <asp:Label ID="Label1" Font-Size="Larger" runat="server" Text="1. "/>  
      <asp:HyperLink ID="HyperLink1" runat="server" Text="ChapterWise PDFs " Font-Size="Larger"
          ForeColor="#000000" Font-Underline="false"
          NavigateUrl="chapterWise.aspx" />
          </div>
</div>
    <br />
    <br />
    </br>
    <div class="auto-style3" style="background-color:powderblue">
  <div class="container">
      <asp:Label ID="Label2" Font-Size="Larger" runat="server" Text="2. "/>  
      <asp:HyperLink ID="HyperLink2" runat="server" Text="Reference Textbooks" Font-Size="Larger" Font-Underline="false"
          ForeColor="#000000"
          NavigateUrl="referenceTB.aspx" />
          </div>
</div>
</asp:Content>
