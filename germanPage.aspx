<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="germanPage.aspx.cs" Inherits="teachingPlatform.germanPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1">
<style>
    .auto-style3 {
        width: 185px;
        height: 57px;
    }
    .auto-style4 {
        width: 148px;
    }
    .auto-style5 {
        padding: 2px 16px;
        width: 398px;
    }
    .auto-style6 {
        margin-left: 129px;
        margin-top: 0px;
    }
    .auto-style7 {
        width: 224px;
        height: 48px;
    }
    .auto-style8 {
        margin-left: 96px;
        margin-top: 0px;
    }
    .auto-style9 {
        width: 183px;
        height: 42px;
    }
    .auto-style10 {
        box-shadow: 0 4px 8px 0 rgb(0, 0, 0);
        transition: 0.3s;
        width: 40%;
        height: 119px;
        margin-left: 83px;
    }
    .auto-style11 {
        box-shadow: 0 4px 8px 0 rgb(0, 0, 0);
        transition: 0.3s;
        width: 40%;
        height: 101px;
        margin-left: 81px;
    }
    .auto-style12 {
        box-shadow: 0 4px 8px 0 rgb(0, 0, 0);
        transition: 0.3s;
        width: 40%;
        height: 112px;
        margin-left: 83px;
    }
    .auto-style13 {
        padding: 2px 16px;
        width: 391px;
        height: 75px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Lasst uns beginnen!</h3>
    <div class="auto-style11" style="background-color:powderblue">
  <div class="auto-style5">
     <table>
         <tr>
             <td>
                 <h3 class="auto-style9">Study Materials</h3>
             </td>
             <td class="auto-style4">
                 <asp:Button ID="Button1" runat="server" 
                     Text="View" CssClass="auto-style6" Height="29px" Width="74px" />
             </td>
         </tr>
     </table> 
      
  </div>
</div>
    </br>
    <div class="auto-style12" style="background-color:powderblue">
  <div class="auto-style13">
     <table>
         <tr>
             <td>
                 <h3 class="auto-style3">Practice Tests</h3>
             </td>
             <td class="auto-style4">
                 <asp:Button ID="Button2" runat="server" Text="View"
                     CssClass="auto-style6" Height="29px" Width="74px" />
             </td>
         </tr>
     </table> 
      
  </div>
</div>
    </br>
    <div class="auto-style10" style="background-color:powderblue">
  <div class="auto-style5">
     <table>
         <tr>
             <td>
                 <h3 class="auto-style7">Q/A with Instructor</h3>
             </td>
             <td class="auto-style4">
                 <asp:Button ID="Button3" runat="server" Text="View" 
                     CssClass="auto-style8" Height="29px" Width="74px" />
             </td>
         </tr>
     </table> 
      
  </div>
</div>
</asp:Content>
