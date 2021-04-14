<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personCenter_updatePassword.aspx.cs" Inherits="CinemaTicketingSystem.personCenter_updatePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 个人中心 </title>
    <meta name="Generator" content="EditPlus">
    <meta name="Author" content="">
    <meta name="Keywords" content="">
    <meta name="Description" content="">
    <link rel="stylesheet" type="text/css" href="css/person-center.css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="head">
		<a href="homePage2.aspx">返回首页</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="movieInfo.aspx">影片资讯</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="homePage1.aspx">退出登录</a>
	</div>
	<div id="fenge">
	</div>
	<div id="title">
			<h2>&nbsp;&nbsp;&nbsp;&nbsp;个人中心</h2>
	</div>
	<div id="person_center">
		<div class="xuanxiang floatleft" style="height:745px">
			<ul>
				<li><a href="personCenter_main.aspx">基本信息</a></li>
				<li><a href="personCenter_myOrders.aspx">我的订单</a></li>
			</ul>
			<div class="clear"></div>
		</div>
		<div id="base_information" class="floatright">
			<div class="content">
				<h2>登录密码</h2>
				<br><br>
				原&nbsp;始&nbsp;密&nbsp;码：<input type="password" name="beforecode1">
				<br><br>
				新&nbsp;&nbsp;&nbsp;密&nbsp;&nbsp;&nbsp;码：<input type="password" name="newcode1">
				<br><br>
				确认新密码：<input type="password" name="renewrode1">
				<br><br>
                <%
           		if(message1!=null){
         	    %>
                <div class = "error"><font color=red ><%=message1 %></font></div>
   		        <%} %>
				<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确认修改" /><br><br>
			</div>
			<hr style="margin-top:20px;border-top:2px #666666 solid" width="700px">
			<div class="content">
				<h2>支付密码</h2>
				<br><br>
				原&nbsp;始&nbsp;密&nbsp;码：<input type="password" name="beforecode2">
				<br><br>
				新&nbsp;&nbsp;&nbsp;密&nbsp;&nbsp;&nbsp;码：<input type="password" name="newcode2">
				<br><br>
				确认新密码：<input type="password" name="renewrode2">
				<br><br><br>
				<%
           		if(message2!=null){
         	    %>
                <div class = "error"><font color=red ><%=message2 %></font></div>
   		        <%} %>
				<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="确认修改" />
				<br><br>
			</div>
			<div class="clear"></div>
		</div>
		<div class="clear"></div>
	</div>
	<br>
	<BR>
	<div id="fenge">
	</div>
	<div id="footer">
		<!-- 版权内容请在本组件"内容配置-版权"处填写 -->
		<br>
		技术支持：邹晶晶 徐琳格 黄之凡<br>
		<br>
		地址:湖北省武汉市洪山区珞喻路152号 邮编：430079 &nbsp;&nbsp;<br>
		<br>
		<a href="">联系我们</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="">新闻投稿</a>
		<br>
		
	</div>
    </form>
</body>
</html>
