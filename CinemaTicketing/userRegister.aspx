<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userRegister.aspx.cs" Inherits="CinemaTicketingSystem.userRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>用户注册</title>
  <meta name="Generator" content="EditPlus">
  <meta name="Author" content="">
  <meta name="Keywords" content="">
  <meta name="Description" content="">

  <style>
  #head{
	height:80px;
	width:100%;
	background-color:black;
	color:white;
  }

  #main{
	width:500px;
	height:750px;
	background:black;
	color:white;

  }
#head a:link{
	color:#FFFFFF;
	text-decoration:underline;
}
#head a:visited{
	color:#FFFFFF;
	text-decoration:none;
}
#head a:hover{
	color:#FFFFFF;
	text-decoration:underline;
}
#head a:active{
	color:#FFFFFF;
	text-decoration:underline;
	
}
  </style>
</head>
<body background="images/back.jpeg";>
    
    <div id=head>
		<font size=5><br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;欢&nbsp;迎&nbsp;注&nbsp;册</font>
		<div style="float:right; margin-right:60px;">
		<br>已有账号？
		请<a href="login.aspx">登录</a>
		</div>
	</div>
	<hr>
	<center>
		<div id=main>
		<br>
		<font  size=6>注册</font><br><br><br>
			<div style="width:300px;text-align:center">
				<form id="form1" runat="server">
				<font size=4>姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名&nbsp;&nbsp;</font>
				<INPUT type=text name="name" style="width: 200px; height: 25px" ></input><BR><BR>
    			<font size=4>邮&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;箱&nbsp;&nbsp;</font>
				<input type="text" name="email" style="width: 200px; height: 25px" ></input><BR><BR>
    			<font size=4>手机号码&nbsp;&nbsp;</font>
				<input type="text" name="phoneNo" style="width: 200px; height: 25px"></input><BR><BR>
				<font size=4>用&nbsp;&nbsp;户&nbsp;&nbsp;名&nbsp;&nbsp;</font>
				<input type="text" name="userName" style="width:200px; height: 25px" ></input><BR><BR>
				<font size=4>登录密码&nbsp;&nbsp;</font>
				<input type="password" name="password" style="width: 200px; height: 25px"></input><BR><BR>
				<font size=4>确认密码&nbsp;&nbsp;</font>
				<input type="password" name="pswRepeat" style="width: 200px; height: 25px"></input><BR><BR>
				
				<%
           		    if(message!=null){
         	    %>
                <div class = "error" style = "font-size:15px;color:#ff0000;"><%=message %></div>
   		        <%} %>
                <br />
                
				<hr style="color:#ffffff">
				<h4>支付密码</h4>
				<font size=4>支付密码&nbsp;&nbsp;</font>
				<input type="password" name="payPassword" style="width: 200px; height: 25px" ></input><BR><BR>
				<font size=4>确认密码&nbsp;&nbsp;</font>
				<input type="password" name="rePayPassword" style="width: 200px; height: 25px" ></input><BR><BR><br>
				<asp:Button ID="Button1" runat="server"  Height="24px" onclick="Button1_Click" 
                    Text="注册" Width="49px" />
                </form>

		
			</div>
		</div>
	</center>
    </form>
</body>
</html>
