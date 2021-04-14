<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CinemaTicketingSystem.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>影院售票系统登录</title>
  <style> 
	
	#main{
		height:300px;
		width:100%;
	}
	#login{
		height:370px;
		width:360px;
		float:right;
		background:black;
		margin: 120px 120px 120px 120px;
	}
	#login .error{
		margin-top:5px;
		height:20px;
		width:200px;
		font-size:13px;
		color:#ff0000;
		text-align:center;
		margin-left:auto;
		margin-right:auto;
		line-height:20px;
	}
</style>
</head>
<body background="images/back.jpeg">

    <form id="form1" runat="server">
        <div id=login style="text-align:center">
			<br>
    		<font size=6 color=white><b>登录</b></font><br><br><br>
		    <strong><font size=4 color=white>账号&nbsp;&nbsp;<asp:TextBox ID="email" runat="server" Height="25px" Width="150px"></asp:TextBox>
            </font></strong>
            <BR><br/><br />
    	    <strong><font size=4 color=white>密码&nbsp;&nbsp;<input type="password" name="password" style="width: 150px; height: 25px">
            </font></strong>
            <BR><br />
		    <%
           		if(message!=null){
         	%>
            <div class = "error"><%=message %></div>
   		     <%} %>
            <br />
            <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" 
                Height="34px" Width="66px" style="margin-left: 0px"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="注册" onclick="Button2_Click" 
                Height="34px" Width="66px" />
            <BR>
         </div>
    </form>
</body>
</html>
