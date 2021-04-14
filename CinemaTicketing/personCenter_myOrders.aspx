<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personCenter_myOrders.aspx.cs" Inherits="CinemaTicketingSystem.personCenter_myOrders" %>

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
				<h2>未完成订单</h2>
				<div id="uncompleted">
					<hr style="margin-left:0px;border-top:1px #666666 dashed" width="550px">
					<%  
                    for (int i = 0; i < list1.Count(); i++)
                    {%>
                        
                        <div class="clear"></div>
					    <div class="floatleft number">
						<div class="number3">订单编号</div>
						<div class="number3"><%=list1[i].getOrderNo() %>	</div>
						<div class="clear"></div>
					</div>
					<div class="floatright number2">
						<div class="floatleft detail">
                            <div style="height:20px;width:350px;font-size:13px;">电影：<%=list1[i].getMovieName() %></div>
							<div style="height:20px;width:350px;font-size:13px;">日期：<%=list1[i].getPlayingDate() %></div>
							<div style="height:20px;width:350px;font-size:13px;">时间：<%=list1[i].getTime()%></div>
							<div style="height:20px;width:350px;font-size:13px;">厅号：<%=list1[i].getHallName()%></div>
                            <div style="height:20px;width:350px;font-size:13px;">座位：<%=list1[i].getSeat()%></div>
							<div style="height:20px;width:350px;font-size:13px;">价格：<%=list1[i].getPrice()%></div>
						</div>
						<div class="floatright zhuangtai">
							<div>
								未完成&nbsp;&nbsp;
								<a href="personCenter_myOrders.aspx?orderNo=<%=list1[i].getOrderNo() %>">打印</a>
							</div>

							<div class="clear"></div>
						</div>
						<div class="clear"></div>
					</div><br/><br/><br/><br/><br/><br/><br/><br/>
                    <%  
                    } %>
                    
				</div>
				<div class="clear"></div>
				<div id="history">
					<h2>历史记录</h2>
				</div>
				<!--  -->
				<div id="uncompleted">
					<hr style="margin-left:0px;border-top:1px #666666 dashed" width="550px">
					<%  
                    for (int i = 0; i < list2.Count(); i++)
                    {%>
                        <div class="clear"></div>
					    <div class="floatleft number">
						<div class="number3">订单编号</div>
						<div class="number3"><%=list2[i].getOrderNo() %>	</div>
						<div class="clear"></div>
					</div>
					<div class="floatright number2">
						<div class="floatleft detail">
                            <div style="height:20px;width:350px;font-size:13px;">电影：<%=list2[i].getMovieName() %></div>
							<div style="height:20px;width:350px;font-size:13px;">日期：<%=list2[i].getPlayingDate() %></div>
							<div style="height:20px;width:350px;font-size:13px;">时间：<%=list2[i].getTime()%></div>
							<div style="height:20px;width:350px;font-size:13px;">厅号：<%=list2[i].getHallName()%></div>
                            <div style="height:20px;width:350px;font-size:13px;">座位：<%=list2[i].getSeat()%></div>
							<div style="height:20px;width:350px;font-size:13px;">价格：<%=list2[i].getPrice()%></div>
						</div>
						<div class="floatright zhuangtai">
							已完成
							<div class="clear"></div>
						</div>
						<div class="clear"></div>
					</div><br/><br/><br/><br/><br/><br/><br/><br/>
                    
                 
                    <%  
                    } %>
				</div>
				<!--  -->
				<div id="total" >
					<br/><br /><br />
                    <h2>我的订单总数&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%=list1.Count() + list2.Count()%></h2>
				</div>
			</div>
		</div>
		<div class="clear"></div>
	</div>
	<br>
	<BR>
	<div id="fenge"></div>
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
