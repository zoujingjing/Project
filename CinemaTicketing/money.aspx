<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="money.aspx.cs" Inherits="CinemaTicketingSystem.money" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 购票选座 </title>
    <meta charset="utf-8"/>
    <meta name="Generator" content="你的开发工具">
    <meta name="Author" content="木木">
    <meta name="Keywords" content="关键字">
    <meta name="Description" content="网页描述">
    <link rel="stylesheet" type="text/css" href="css/chaxun.css">
</head>
<body>
<form id="form1" runat="server">
    <div id="header">
		购票选座
		<div class="floatright" id="choose">
			<ul>
				<li><a href="movieDetail.aspx" target="_self"><font size = 2px>返回</font></a></li>
			</ul>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content2">
		请支付电影票价：<h4><%=price %>元</h4>
		<BR><BR>
		支付密码：<input type="password" name="payPassword">&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="确认支付" onclick="Button1_Click" />
        &nbsp;
        
		<%
           if(message!=null){
        %>
        <br /><br />
        <div class = "error" style = "font-size:13px;color:#ff0000;"><%=message %></div>
   		<%} %>
	</div>
	<div id="table1">

	</div>
	
   <div id = "footer">
		<!-- 版权内容请在本组件"内容配置-版权"处填写 -->
		<br>
		技术支持：邹晶晶 徐琳格 黄之凡<br>
		<br>
		地址:湖北省武汉市洪山区珞喻路152号 邮编：430079 &nbsp;&nbsp;<br>
		<br>
		<a href="">联系我们</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="">新闻投稿</a>
		<br>
		<br>
   </div>
	<style>
		#content2{
			
			font-size:20px;
		}
	</style>
    </form>
</body>
</html>
