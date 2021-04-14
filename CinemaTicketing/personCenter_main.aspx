<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personCenter_main.aspx.cs" Inherits="CinemaTicketingSystem.personCenter_main" %>

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
		<a href="Shouye2.aspx">返回首页</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="movieInfo.aspx">影片资讯</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="homePage1.aspx">退出登录</a>
	</div>
	<div id="fenge">
	</div>
	<div id="title">
			<h2>&nbsp;&nbsp;&nbsp;&nbsp;个人中心</h2>
	</div>
	<div id="person_center">
		<div class="xuanxiang floatleft" style="height:373px">
			<ul>
				<li><a href="personCenter_main.aspx">基本信息</a></li>
				<li><a href="personCenter_myOrders.aspx">我的订单</a></li>
			</ul>
			<div class="clear"></div>
		</div>
		<div id="base_information" class="floatright">
				<div class="change">
					<a href="personCenter_updateInfomation.aspx">修改个人信息</a>&nbsp;&nbsp;|&nbsp;&nbsp;
					<a href="personCenter_updatePassword.aspx">修改密码</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				</div>
				<div class="content">
				用户名：<%=username %>	
				<br>
				<br>
				<br>
                姓&nbsp;&nbsp;&nbsp;&nbsp;名：<%=name %>	
				<br>
				<br>
				<br>
				性&nbsp;&nbsp;&nbsp;&nbsp;别：<%=sex %>	
				<br>
				<br>
				<br>
				手机号：<%=phone %>	
				<br>
				<br>
				<br>
				邮&nbsp;&nbsp;&nbsp;&nbsp;箱：<%=email %>	
				<br>
				<br>
				
				<br>
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
