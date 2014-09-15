<%@ Page Title="" Language="C#" MasterPageFile="~/Students/Students.master" AutoEventWireup="true" CodeFile="AllNotices.aspx.cs" Inherits="Students_AllNotices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
  <div class="col-md-6"> 
                <ul class="list-group">
           <asp:Panel ID="PnlRelated" runat="server" GroupingText="Related Notices">
           <asp:Repeater ID="rptrRelated"   runat="server">
                                <ItemTemplate>
                                      <li class="list-group-item">  <%#Eval("Topic") %></li>
                                               
                        </ItemTemplate>
                    </asp:Repeater>
           </asp:Panel>
               </ul>
        </div>





  <div class="col-md-6">
  <ul class="list-group">
          <asp:Panel ID="PnlAll" runat="server" GroupingText="All Notices">
          <asp:Repeater ID="rptrAll"   runat="server">
                        <ItemTemplate>
                             <li class="list-group-item">        <%#Eval("Topic") %> </li>
                        </ItemTemplate>
                    </asp:Repeater>
           </asp:Panel>      
           </ul>          
 </div>
        </div>

</asp:Content>

