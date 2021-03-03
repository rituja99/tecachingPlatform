<% @ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" 
    Inherits="teachingPlatform.StudentHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 171px;
            height: 104px;
            margin-left: 125px;
            margin-top: 72px;
        }
        .auto-style2 {
            width: 169px;
            height: 104px;
            margin-left: 312px;
            margin-top: 75px;
        }
        .auto-style3 {
            width: 72px;
            height: 170px;
        }
        .auto-style4 {
            width: 210px;
            height: 136px;
        }
        .auto-style5 {
            width: 569px;
            height: 136px;
        }
        .auto-style6 {
            width: 163px;
            height: 136px;
        }
        .auto-style7 {
            width: 40px;
        }
        .auto-style8 {
            margin-top: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <justify><asp:Label ID="Label1" runat="server" Font-Size="Medium"></asp:Label></justify>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Medium" 
        ForeColor="Black" NavigateUrl="~/registrationPage.aspx">Register</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" Font-Size="Medium" ForeColor="Red" NavigateUrl="~/loginPage.aspx">LogIn</asp:HyperLink>
    <br />
    <br />
    <justify>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               Which language do you want choose?
           </justify>
    <table class="auto-style3">
        <tr>
            <td class="auto-style6">
                <asp:TreeView ID="TreeView1" runat="server" Width="161px" Font-Size="Medium"
                     Font-Names="Palatino Linotype" Height="185px" ForeColor="#000000">
                    <Nodes>
                        <asp:TreeNode Text="About Us" Value="About Us"></asp:TreeNode>
                        <asp:TreeNode Text="Contact Us" Value="Contact Us"></asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
            </td>
       <td class="auto-style4">
           
           <div class="auto-style1">
               <center>
                   <h2>English</h2>
                   <img alt="" src="english.png" width="55px" height="55px" /><br />
               </center>
        <asp:Button ID="english" runat="server" 
            OnClick="english_Click" Text="Join" BackColor="White"
            Font-Bold="True" Font-Names="Palatino Linotype" Width="173px" />
       </div>
        </td>
       <td class="auto-style5"><div class="auto-style2">
            <center class="auto-style8">
                   <h2>German</h2>
                <img alt="" src="german.png" height="45px" class="auto-style7" /><br />
               </center>
        <asp:Button ID="german" runat="server" OnClick="german_Click"
            Text="Join" BackColor="White" Font-Bold="True" 
            Font-Names="Palatino Linotype" Width="173px" />
        </div>
           </td> 
            </tr>
     </table>
       
    <asp:Label id="label" runat="server" />
    
</asp:Content>
