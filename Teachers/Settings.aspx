<%@ Page Title="" Language="C#" MasterPageFile="~/Teachers/Teachers.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Teachers_Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div id="DivMenu" style="Float:left; width:250px;">
  <ol>
  
  <li>Personal settings</li>
    <ul>
        <li>
            <asp:LinkButton ID="LbtPerDetails" runat="server" onclick="LbtPerDetails_Click">Personal Deatils</asp:LinkButton></li>
        <li>
            <asp:LinkButton ID="LbtPassword" runat="server" onclick="LbtPassword_Click">Password</asp:LinkButton></li>
  </ul>
  </ol>
</div>



<div id="DivSetting">
<asp:Panel ID="pnlPersonal" runat="server">
<table>
    

    <tr>
   <td>
    Address:</td>
   <td> <asp:TextBox ID="TxtAddress" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
   <td>
    E-mail:</td>
   <td> <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

     <tr>
   <td> Contact No.:</td>
   <td> <asp:TextBox ID="TxtContact" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
   <td colspan='2'><center>
       <asp:Button ID="BtnSave" runat="server" Text="Save" CssClass="btn btn-default"  />
       </center>
       </td>
    </tr>
    </table>
</asp:Panel>



<asp:Panel ID="PnlPassword" runat="server" Visible="false">

<table>

<tr>
<td>Old Password</td>
<td>
    <asp:TextBox ID="TxtOldPassword" runat="server" CssClass="form-control"></asp:TextBox></td>
</tr>

<tr>
<td>New Password</td>
<td>
    <asp:TextBox ID="TxtNewPassword" runat="server" CssClass="form-control"></asp:TextBox></td>
</tr>

<tr>
<td>Conform Password</td>
<td>
    <asp:TextBox ID="TxtConform" runat="server" CssClass="form-control"></asp:TextBox></td>
</tr>
   <td colspan='2'><center>
      <asp:Button ID="BtnChange" runat="server"  Text="Change" CssClass="btn btn-default" /> 
       </center>
       </td>
    </tr>
</table>

</asp:Panel>
</div>

</asp:Content>

