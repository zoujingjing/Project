<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paymentSuccess.aspx.cs" Inherits="CinemaTicketingSystem.paymentSuccess" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 购买成功 </title>
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
		购买成功
		<div class="floatright" id="choose">
                <a href="movieDetail.aspx">返回</a>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content2">
		<img src="images/success.png" width="40" height="40" border="0" alt=""><h1>购买成功</h1>
		<table style="border:0px;margin:auto;" >
		<tr>
			<td align="left">订单编号：</td>
			<td align="left"><%=orderNo %></td>
		</tr>
		<tr>
			<td align="left">影片名称：</td>
			<td align="left"><%=movieName %></td>
		</tr>
		<tr>
			<td align="left">姓名：</td>
			<td align="left"><%=customerName %></td>
		</tr>
		<tr>
			<td align="left">影片放映日期：</td>
			<td align="left"><%=playingDate%></td>
		</tr>
		<tr>
			<td align="left">影片放映时间：</td>
			<td align="left"><%=time %></td>
		</tr>
		<tr>
			<td align="left">放映厅号：</td>
			<td align="left"><%=hallName %></td>
		</tr>
		<tr>
			<td align="left">座位：</td>
			<td align="left"><%=seat %></td>
		</tr>		
		<tr>
			<td align="left">票价：</td>
			<td align="left"><%=price %>元</td>
		</tr>
		<tr>
			<td align="left">订单状态：</td>
			<td align="left"><%=statement %></td>
		</tr>
		<tr>
			<td align="left">订单生成日期</td>
			<td align="left"><%=generateDate %></td>
		</tr>
		</table>
		<br><br>
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
		#choose a
		{
		    font-size:15px;   
		 }
	</style>
    </form>
</body>
</html>
