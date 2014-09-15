<%@ Page Title="" Language="C#" MasterPageFile="~/Teachers/Teachers.master" AutoEventWireup="true" CodeFile="AllNotices.aspx.cs" Inherits="Teachers_AllNotices" %>

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
                    close: function (event, ui) {

                        __doPostBack('<%= btnRefresh.ClientID %>', '');
                    }
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
              
           <asp:Panel ID="PnlRelated" runat="server" GroupingText="Related Notices">
           <ul class="list-group">
           <asp:Repeater ID="rptrRelated"   runat="server">
                                <ItemTemplate>
                                  <li class="list-group-item">    <a ID="popup" href='~/Notice.aspx?id=<%# Eval("NoticeID") %>'><%#Eval("Reference")%> </a></li>
                                              
                        </ItemTemplate>
                    </asp:Repeater>
            </ul>
           </asp:Panel>
               
         </div>





  <div class="col-md-6">
          <asp:Panel ID="PnlAll" runat="server" GroupingText="All Notices">
           <ul class="list-group">
             <asp:Repeater ID="rptrAll"   runat="server">
                        <ItemTemplate>
                              <li class="list-group-item">  <a ID="popup" href='~/Notice.aspx?id=<%# Eval("NoticeID") %>'><%#Eval("Reference")%> </a> </li>
                        </ItemTemplate>
                    </asp:Repeater>
                     </ul>  
           </asp:Panel>         
                
 </div>
        </div>

</asp:Content>

