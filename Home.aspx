<%@ Page Title="" Language="C#" MasterPageFile="~/General.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.microsoft.com/ajax/jquery.ui/1.8.6/jquery-ui.min.js"></script>
    <link type="text/css" rel="Stylesheet" href="http://ajax.microsoft.com/ajax/jquery.ui/1.8.6/themes/smoothness/jquery-ui.css">
    <script type="text/javascript">
        $(document).ready(function () {
            $('a#popup').live('click', function (e) {

                var page = $(this).attr("href")

                var $dialog = $('<div></div>')
                .html('<iframe style="border: 0px; " src="' + page + '" width="100%" height="100%"></iframe>')
                .dialog({
                    autoOpen: false,
                    modal: true,
                    height: 450,
                    width: 'auto',
                    title: "Notice:",
                    buttons: {
                        "Close": function () { $dialog.dialog('close'); }
                    },
                    
                });
                $dialog.dialog('open');
                e.preventDefault();
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
  <div class="col-md-6">         
   <asp:Panel ID="PnlAll" runat="server" GroupingText="All Notices">

                <ul class="list-group">
          <asp:Repeater ID="rptrAll"   runat="server">
                        <ItemTemplate>
                            <li class="list-group-item">         <a ID="popup" href='Notice.aspx?id=<%# Eval("NoticeID") %>'><%#Eval("Reference")%> </a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                      </ul>
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

            <asp:TextBox ID="TxtUserName" CssClass="form-control" placeholder="User Name" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
        <td>Password</td>
        <td>
            <asp:TextBox ID="TxtPassword" CssClass="form-control" runat="server" Placeholder="Password"></asp:TextBox>
             </td>
        </tr>

         <tr>
        <td colspan='2' align="center"> 
       
            <asp:Button ID="BtnSignIn" runat="server" Text="Sign In" 
                CssClass="btn btn-default"  /><br />
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
    <td><asp:TextBox ID="TxtUName" CssClass="form-control" runat="server" Placeholder="First Name"></asp:TextBox></td>
    </tr>

    <tr>
    <td>Last Name</td>
    <td><asp:TextBox ID="TxtLastName" CssClass="form-control" runat="server" Placeholder="Last Name"></asp:TextBox></td>
    </tr>

   <tr>
   <td>Faculty</td>
   <td><asp:DropDownList ID="DDLFaculty" CssClass="form-control" runat="server" >
   </asp:DropDownList></td>
    </tr>

    <tr>
   <td>Batch</td>
   <td><asp:DropDownList ID="DDLBatch" CssClass="form-control" runat="server">
   </asp:DropDownList></td>
    </tr>

   <tr>
   <td>College Roll No.</td>
   <td>  <asp:TextBox ID="TxtRollno" CssClass="form-control" runat="server" Placeholder="Eg: 10401"></asp:TextBox></td>
    </tr>

    <tr>
   <td>
    Address</td>
   <td> <asp:TextBox ID="TxtAddress" CssClass="form-control" runat="server" Placeholder="Address"></asp:TextBox></td>
    </tr>

     <tr>
   <td> Contact No.</td>
   <td> <asp:TextBox ID="TxtContact" CssClass="form-control" runat="server" Placeholder="Eg: 9841403303"></asp:TextBox></td>
    </tr>

    <tr>
   <td> E-mail</td>
   <td> <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server" Placeholder="Email"></asp:TextBox></td>
    </tr>

    <tr>
   <td colspan='2' align="center">
       <asp:Button ID="BtnSignUp" runat="server" CssClass="btn btn-default" 
           Text="Sign Up" onclick="BtnSignUp_Click" />
      
       <asp:Button ID="BtnReset" runat="server" CssClass="btn btn-default" 
           Text="Reset"/>
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

