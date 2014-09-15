<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="Admin_ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Select Task : 
    <asp:DropDownList ID="DdlTask" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DdlTask_SelectedIndexChanged" CssClass="form-control" Width="30%">
        <asp:ListItem Selected="True">Select Option </asp:ListItem>
        <asp:ListItem>Edit User</asp:ListItem>
        <asp:ListItem>Create User</asp:ListItem>
    </asp:DropDownList>
    <br />
<br />
<asp:Panel runat="server" ID="PnlCreateUser" GroupingText="Create User">
    <table>
    <tr>
    <td>Name:</td>
    <td><asp:TextBox ID="TxtUName" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
    <td>Last Name:</td>
    <td><asp:TextBox ID="TxtLastName" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

   <tr>
   <td>Depatrment:</td>
   <td><asp:DropDownList runat="server" AutoPostBack="True" CssClass="form-control">
   <asp:ListItem>IT </asp:ListItem>
   <asp:ListItem>Computer </asp:ListItem>
   <asp:ListItem>Electronic & Communication </asp:ListItem>
   <asp:ListItem>Software Engineering </asp:ListItem>
   <asp:ListItem>BBA </asp:ListItem>
   </asp:DropDownList></td>
    </tr>

   <tr>
   <td>Employee ID No.:</td>
   <td>  <asp:TextBox ID="TxtRollno" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

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
       &nbsp;&nbsp;&nbsp;
       <asp:Button ID="BtnReset" runat="server" Text="Reset" CssClass="btn btn-default" /></center>
       </td>
    </tr>
    </table>

</asp:Panel>


<asp:Panel runat="server" ID="PnlEditUser" GroupingText="Edit User">
					
<table>
    <tr>
    <td colspan='2'>
  
    <asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control pull-left" Width="70%"></asp:TextBox>
    
        
    
        <asp:Button ID="BtnSearch" runat="server" Text="Search" CssClass="btn btn-default pull-right" />
   
        </td>
    </tr>
    <tr>
    <td>Name:</td>
    <td><asp:TextBox ID="TxtNameEdit" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
    <td>Last Name:</td>
    <td><asp:TextBox ID="TxtLNameEdit" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

  
    <tr>
   <td>Department:</td>
   <td><asp:DropDownList ID="DdlFacultyEdit" runat="server" CssClass="form-control" AutoPostBack="True">
   <asp:ListItem>IT </asp:ListItem>
   <asp:ListItem>Computer </asp:ListItem>
   <asp:ListItem>Electronic & Communication </asp:ListItem>
   <asp:ListItem>Software Engineering </asp:ListItem>
   <asp:ListItem>BBA </asp:ListItem>
   </asp:DropDownList></td>
    </tr>

   <tr>
   <td>Emp ID No.:</td>
   <td>  <asp:TextBox ID="TxtROllnoEdit" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
   <td>
    Address:</td>
   <td> <asp:TextBox ID="TxtAddressEdit" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

    <tr>
   <td>
    E-mail:</td>
   <td> <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>

     <tr>
   <td> Contact No.:</td>
   <td> <asp:TextBox ID="TxtContactnoEdit" runat="server" CssClass="form-control"></asp:TextBox></td>
    </tr>


     <tr>
   <td colspan='2' ><center>
       <asp:Button ID="BtnSaveEdit" runat="server" Text="Save" CssClass="btn btn-default" /> 
       &nbsp;&nbsp;&nbsp;
       <asp:Button ID="BtnResetEdit" runat="server" Text="Reset" CssClass="btn btn-default" /></center></td>
    </tr>

    </table>
				
                </asp:Panel>		
</asp:Content>

