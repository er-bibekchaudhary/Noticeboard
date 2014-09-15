<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Notice.aspx.cs" Inherits="Notice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
    <asp:Label ID="LblHeading" runat="server" Text=" "></asp:Label>
    </h1>
    <br />
    <br />
    <br />
     <asp:Label ID="LblBody" runat="server" Text=""></asp:Label>

     <br />
    <br />
    <p align="right">
    <asp:Label ID="LblName" runat="server" Text=""></asp:Label>
    </p>
    </div>
    </form>
</body>
</html>
