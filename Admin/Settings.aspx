<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Admin_Settings" %>

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
  
  <li>Users Setting</li>
    <ul>
        <li>
            <asp:LinkButton ID="LbtPendingRequet" runat="server" 
                onclick="LbtPendingRequet_Click">Pending Request</asp:LinkButton></li>
            <li>
            <asp:LinkButton ID="LbtDeleteUsers" runat="server" onclick="LbtDeleteUsers_Click">Delete Users</asp:LinkButton></li>
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
       <asp:Button ID="BtnSave" runat="server" Text="Save" CssClass="btn btn-default" />
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

</table>
<asp:Button ID="BtnChange" runat="server"  Text="Change" CssClass="btn btn-default"/> 
</asp:Panel>



<asp:Panel ID="pnlPending" runat="server" Visible="false">

</asp:Panel>


<asp:Panel ID="PnlDeleteUser" runat="server" Visible="false">

<asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control pull-left" Width="50%"></asp:TextBox>

 <asp:Button runat="server" ID="BtnSearch" Text="Search" CssClass="btn btn-default pull-left" />
<asp:Repeater ID="rptrRelated"   runat="server">
                                <ItemTemplate>
                                       <%#Eval("UserName") %>
                                       <asp:Button ID="BtnDelete"  runat="server" Text="Delete" />
                                                <br />
                        </ItemTemplate>
                    </asp:Repeater>
 </asp:Panel>





</div>

</asp:Content>

