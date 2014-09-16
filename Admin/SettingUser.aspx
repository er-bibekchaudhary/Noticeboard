<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SettingUser.aspx.cs" Inherits="Admin_SettingUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div id="DivMenu" style="Float:left; width:250px;">
  <ol>
  
  <li><a href="SettingPersonal.aspx">Personal settings</a></li>
  
  <li>Users Setting</li>
    <ul>
        <li>
            <asp:LinkButton ID="LbtPendingRequet" runat="server" 
                onclick="LbtPendingRequet_Click">Pending Request</asp:LinkButton></li>
        <li>
             <asp:LinkButton ID="LbtBlockUsers" runat="server" onclick="LbtBlockUsers_Click">Block Users</asp:LinkButton></li>
    </ul>

    <li><a href="SettingContent.aspx">Content settings</a></li>
  </ol>
</div>



<div id="DivSetting">

<asp:Panel ID="pnlPending" runat="server" Visible="false">


</asp:Panel>


<asp:Panel ID="PnlDeleteUser" runat="server" Visible="false">

<asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control pull-left" Width="50%"></asp:TextBox>

 <asp:Button runat="server" ID="BtnSearch" Text="Search" CssClass="btn btn-default pull-left" />
 <br />
 <br />
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

