<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectSeats.aspx.cs" Inherits="CinemaTicketingSystem.selectSeats" %>

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
				<li><a href="movieDetail.aspx" target="_self"><font size=2px>返回</font></a></li>
			</ul>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content2">
		银&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;幕<br>
		<br>
		<br>
		<br>
		<a href="selectSeats.aspx?content=1排1座">1排1座</a>&nbsp;<a href="selectSeats.aspx?content=1排2座">1排2座</a>&nbsp;<a href="selectSeats.aspx?content=1排3座">1排3座</a>&nbsp;<a href="selectSeats.aspx?content=1排4座">1排4座</a>&nbsp;<a href="selectSeats.aspx?content=1排5座">1排5座</a>&nbsp;<a href="selectSeats.aspx?content=1排6座">1排6座</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="selectSeats.aspx?content=1排7座">1排7座</a>&nbsp;<a href="selectSeats.aspx?content=1排8座">1排8座</a>&nbsp;<a href="selectSeats.aspx?content=1排9座">1排9座</a>&nbsp;<a href="selectSeats.aspx?content=1排10座">1排10座</a>&nbsp;<a href="selectSeats.aspx?content=1排11座">1排11座</a>&nbsp;<a href="selectSeats.aspx?content=1排12座">1排12座</a>
		<br><br><br>
		<a href="selectSeats.aspx?content=2排1座">2排1座</a>&nbsp;<a href="selectSeats.aspx?content=2排2座">2排2座</a>&nbsp;<a href="selectSeats.aspx?content=2排3座">2排3座</a>&nbsp;<a href="selectSeats.aspx?content=2排4座">2排4座</a>&nbsp;<a href="selectSeats.aspx?content=2排5座">2排5座</a>&nbsp;<a href="selectSeats.aspx?content=2排6座">2排6座</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="selectSeats.aspx?content=2排7座">2排7座</a>&nbsp;<a href="selectSeats.aspx?content=2排8座">2排8座</a>&nbsp;<a href="selectSeats.aspx?content=2排9座">2排9座</a>&nbsp;<a href="selectSeats.aspx?content=2排10座">2排10座</a>&nbsp;<a href="selectSeats.aspx?content=2排11座">2排11座</a>&nbsp;<a href="selectSeats.aspx?content=2排12座">2排12座</a>
		<br><br><br>
		<a href="selectSeats.aspx?content=3排1座">3排1座</a>&nbsp;<a href="selectSeats.aspx?content=3排2座">3排2座</a>&nbsp;<a href="selectSeats.aspx?content=3排3座">3排3座</a>&nbsp;<a href="selectSeats.aspx?content=3排4座">3排4座</a>&nbsp;<a href="selectSeats.aspx?content=3排5座">3排5座</a>&nbsp;<a href="selectSeats.aspx?content=3排6座">3排6座</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="selectSeats.aspx?content=3排7座">3排7座</a>&nbsp;<a href="selectSeats.aspx?content=3排8座">3排8座</a>&nbsp;<a href="selectSeats.aspx?content=3排9座">3排9座</a>&nbsp;<a href="selectSeats.aspx?content=3排10座">3排10座</a>&nbsp;<a href="selectSeats.aspx?content=3排11座">3排11座</a>&nbsp;<a href="selectSeats.aspx?content=3排12座">3排12座</a>
		<br><br><br>
		<a href="selectSeats.aspx?content=4排1座">4排1座</a>&nbsp;<a href="selectSeats.aspx?content=4排2座">4排2座</a>&nbsp;<a href="selectSeats.aspx?content=4排3座">4排3座</a>&nbsp;<a href="selectSeats.aspx?content=4排4座">4排4座</a>&nbsp;<a href="selectSeats.aspx?content=4排5座">4排5座</a>&nbsp;<a href="selectSeats.aspx?content=4排6座">4排6座</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="selectSeats.aspx?content=4排7座">4排7座</a>&nbsp;<a href="selectSeats.aspx?content=4排8座">4排8座</a>&nbsp;<a href="selectSeats.aspx?content=4排9座">4排9座</a>&nbsp;<a href="selectSeats.aspx?content=4排10座">4排10座</a>&nbsp;<a href="selectSeats.aspx?content=4排11座">4排11座</a>&nbsp;<a href="selectSeats.aspx?content=4排12座">4排12座</a>
		<br><br><br>
		<br /><br />
        <div class="buy">
        <% if (seat != null)
           {%>
		你已选择：<%=seat %>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="payment.aspx">购买</a>
        <% } %>
        </div>
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
    #content2 a:link{
	color:#FFFFFF;
	text-decoration:none;
}
#content2 a:visited{
	color:#757575;
	text-decoration:none;
}
#content2 a:hover{
	color:#757575;
	text-decoration:none;
}
#content2 a:active{
	color:#FFFFFF;
	text-decoration:none;
}
#content2 .buy a:link{
	font-size:15px;
	color:#ffffff;
	border:solid 1px #FFFFFF;
	width:20px;
	height:10px;
	text-decoration:none;
	padding-top:5px;
	padding-bottom:5px;
	padding-left:6px;
	padding-right:6px;
}
#content2 .buy a:visited{
	background-color:#FFFFFF;
	font-size:15px;
	color:#ffffff;
	border:solid 1px #FFFFFF;
	width:20px;
	height:10px;
	text-decoration:none;
	padding-top:5px;
	padding-bottom:5px;
	padding-left:6px;
	padding-right:6px;
}
#content2 .buy a:hover{
	font-size:15px;
	color:#ffffff;
	border:solid 1px #FFFFFF;
	width:20px;
	height:10px;
	text-decoration:underline;
	padding-top:5px;
	padding-bottom:5px;
	padding-left:6px;
	padding-right:6px;
}

   </style>
    </form>
</body>
</html>
