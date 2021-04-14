<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_login.aspx.cs" Inherits="CinemaTicketingSystem.backStage_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> 后台管理系统 </title>
  <meta name="Generator" content="EditPlus">
  <meta name="Author" content="">
  <meta name="Keywords" content="">
  <meta name="Description" content="">
  <link rel="stylesheet" type="text/css" href="css/back-login.css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="login">
	<br><br><br><br><br><br><br><br><br>
	<h1>管&nbsp;理&nbsp;人&nbsp;员&nbsp;登&nbsp;录&nbsp;</h1>
	<div class="log">
		登录ID：<input type="text" name="id"></input>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		密码：<input type="password" name="password"></input>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:Button ID="Button1" runat="server" Text="登录" Width="48px" onclick="Button1_Click" />
        <%
            if (message != null)
            {
        %>
        <div class = "error"><%=message%></div>
   		<%} %>
&nbsp;</div>
 </div>
    </form>
</body>
</html>
