<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="studyMaterials.aspx.cs" Inherits="teachingPlatform.studyMaterials" %>
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
        width: 44%;
        height: 47px;
    }
    .auto-style2 {
        padding: 2px 16px;
        width: 305px;
        height: 51px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
     <div class="auto-style1" style="background-color:powderblue">
  <div class="auto-style2">
      <asp:Label ID="Label1" Font-Size="Larger" runat="server" Text="1. "/>  
      <asp:HyperLink ID="HyperLink1" runat="server" Text="ChapterWise PDFs " Font-Size="Larger"
          ForeColor="#000000"
          NavigateUrl="chapterWise.aspx" />
          </div>
</div>
    </br>
    <div class="auto-style1" style="background-color:powderblue">
  <div class="container">
      <asp:Label ID="Label2" Font-Size="Larger" runat="server" Text="2. "/>  
      <asp:HyperLink ID="HyperLink2" runat="server" Text="Reference Textbooks" Font-Size="Larger"
          ForeColor="#000000"
          NavigateUrl="referenceTB.aspx" />
          </div>
</div>
</asp:Content>
