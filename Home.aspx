<%@ Page Title="" Language="C#" MasterPageFile="~/General.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row">
  <div class="col-md-6">         
   <asp:Panel ID="PnlAll" runat="server" GroupingText="All Notices">


          <asp:Repeater ID="rptrAll"   runat="server">
                        <ItemTemplate>
                                    <%#Eval("Topic") %> <br />
                        </ItemTemplate>
                    </asp:Repeater>
           </asp:Panel>
           

</div>
  <div class="col-md-6">
  
  <div class="row">
  <div class="col-md-12">
    <asp:Panel ID="PnlSignup" runat="server" GroupingText="Sign In" Height="124px">
      <center>
        <table>
        <tr>
        <td>User Name</td>
        <td>

            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
        <td>Password</td>
        <td>
            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
             </td>
        </tr>

         <tr>
        <td colspan='2' align="center"> 
       
            <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-default" /><br />
            <a href=#> Forgot Password</a>
           
             </td>
        </tr>
        
        </table>
        </center>
       </asp:Panel>
  
  </div>
  </div>
 
 <br /><br />
  <div class="row">
  <div class="col-md-12">
  
   <asp:Panel runat="server" ID="PnlCreateUser" GroupingText="Sign Up">
    <table>
    <tr>
    <td>Name</td>
    <td><asp:TextBox ID="TxtUName" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td>Last Name</td>
    <td><asp:TextBox ID="TxtLastName" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

   <tr>
   <td>Faculty</td>
   <td><asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
   <asp:ListItem>IT </asp:ListItem>
   <asp:ListItem>Computer </asp:ListItem>
   <asp:ListItem>Electronic & Communication </asp:ListItem>
   <asp:ListItem>Software Engineering </asp:ListItem>
   <asp:ListItem>BBA </asp:ListItem>
   </asp:DropDownList></td>
    </tr>

   <tr>
   <td>College Roll No.</td>
   <td>  <asp:TextBox ID="TxtRollno" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
   <td>
    Address</td>
   <td> <asp:TextBox ID="TxtAddress" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

     <tr>
   <td> Contact No.</td>
   <td> <asp:TextBox ID="TxtContact" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
   <td> E-mail</td>
   <td> <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
   <td colspan='2' align="center">
       <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-default" Text="Save" />
      
       <asp:Button ID="BtnReset" runat="server" CssClass="btn btn-default" Text="Reset" />
       </td>
    </tr>
    </table>
    
    </asp:Panel>
  </div>
  </div>
  
  </div>
  </div>






        <div id="DivForms">
        
      

    
        
        </div>               
</asp:Content>

