<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SettingContent.aspx.cs" Inherits="Admin_SettingContent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <br />
<div id="DivMenu" style="Float:left; width:250px;">
  <ol>
  
  <li><a href="SettingPersonal.aspx">Personal settings</a></li>
  <li><a href="SettingUser.aspx">Users Setting</a></li>
    <li>Content settings</li>
    <ul>
        <li>
            <asp:LinkButton ID="LbtEditBatch" runat="server" onclick="LbtEditBatch_Click" >Edit Batch</asp:LinkButton></li>
        <li>
            <asp:LinkButton ID="LbtEditFaculty" runat="server" 
                onclick="LbtEditFaculty_Click" >Edit Faculty</asp:LinkButton></li>
        
  </ul>
  </ol>
</div>



<div id="DivSetting">
<asp:Label ID="LblResult" runat="server" Text=" " ForeColor="Red"></asp:Label>
<asp:Panel ID="PnlBatch" runat="server">
<asp:TextBox ID="TxtBatch" runat="server" CssClass="form-control pull-left" Width="50%"></asp:TextBox>
 <asp:Button runat="server" ID="BtnAddBatch" Text="Add Batch" 
        CssClass="btn btn-default pull-left" onclick="BtnAddBatch_Click" /><br /><br /><br />

<table>
    <tr>
        <td>Batch Year</td>
        <td>Delete</td>
    </tr>
        <asp:Repeater ID="RptrBatch"   runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("BatchYear") %></td>
                   <td><asp:Button ID="BtnDeleteBatch"  runat="server" Text="Delete" CommandArgument='<%#Eval("BatchID") %>' onclick="BtnDeleteBatch_Click"/></td>
                </tr>
             </ItemTemplate>
        </asp:Repeater>
</table>
</asp:Panel>


<asp:Panel ID="PnlFaculty" runat="server" Visible="false">

<asp:TextBox ID="TxtFaculty" runat="server" CssClass="form-control pull-left" Width="50%"></asp:TextBox>
 <asp:Button runat="server" ID="BtnAddFaculty" Text="Add Faculty" 
        CssClass="btn btn-default pull-left" onclick="BtnAddFaculty_Click" /><br /><br /><br />
<table>
    <tr>
        <td>Faculty Name</td>
        <td>Delete</td>
    </tr>
        <asp:Repeater ID="RptrFaculty"   runat="server">
            <ItemTemplate>
                <tr>
                  <td> <%#Eval("FacultyName") %> </td>
                 <td><asp:Button ID="BtnDeleteFaculty"  runat="server" Text="Delete" CommandArgument='<%#Eval("FacultyID")%>' onclick="BtnDeleteFaculty_Click"/></td>
                </tr>
             </ItemTemplate>
        </asp:Repeater>
</table>
 </asp:Panel>



</div>
</asp:Content>

