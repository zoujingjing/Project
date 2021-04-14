<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_queryOrder.aspx.cs" Inherits="CinemaTicketingSystem.backStage_queryOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 后台管理系统 </title>
    <meta name="Generator" content="EditPlus">
    <meta name="Author" content="">
    <meta name="Keywords" content="">
    <meta name="Description" content="">
    <link rel="stylesheet" type="text/css" href="css/back.css">
</head>
<body>
    <form id="form1" runat="server">
    <!-- head开始 -->
	<div id="head">
		<div class="floatleft title">
			影院售票后台管理
			<div class="clear"></div>
		</div>
		<div class="floatright user">
			管理员：<%=Session["name"] %>&nbsp;&nbsp;&nbsp;&nbsp;你好！&nbsp;&nbsp;&nbsp;<a href="homePage1.aspx">退出登录</a>
			<div class="clear"></div>
		</div>
	</div>
<!-- head结束 -->

<!-- content开始 -->
	<div id="content">
		<!-- 左边菜单栏开始 -->
		<div class="floatleft" id="caidan">
			<ul>
				<li><a href="backStage_main.aspx">基本信息</a></li>
				<li><a href="backStage_userManagement.aspx">用户管理</a></li>
				<li><a href="backStage_movieManagement.aspx">影片管理</a></li>
				<li><a href="backStage_playManagement.aspx">放映管理</a></li>
				<li><a href="backStage_orderManagement.aspx">订单管理</a></li>
			</ul>
			<div class="clear"></div>
		</div>
		<!-- 左边菜单栏结束 -->
		<!-- 右边内容开始 -->
		<div id="content2">
			<div class="movie_manage">
				请输入查询条件：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<select name="queryType">
					<option value="" selected>查询类型</option>
					<option value="订单编号">订单编号</option>
					<option value="影片名称">影片名称</option>
				</select>&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="Button1" runat="server" Height="25px" Text="查询" Width="45px" 
                    onclick="Button1_Click" />
				<!-- 影片列表 --><br><br><br>
				<table style="text-align:center;margin:auto;font-size:14px" height="auto">
				<tr height="50px" border="1px">
					<td width="120px"><b>订单编号</b></td>
					<td width="70px"><b>影片名称</b></td>
					<td width="80px"><b>顾客姓名</b></td>
					<td width="80px"><b>放映日期</b></td>
					<td width="85px"><b>放映时间</b></td>
					<td width="90px"><b>影厅号</b></td>
					<td width="90px"><b>座位</b></td>
					<td width="60px"><b>价格</b></td>
					<td width="60px"><b>订单状态</b></td>
					<td width="230px"><b>订单生成日期</b></td>
					<td width="60px"><b>操作</b></td>
				</tr>
                <%
                    for (int i = 0; i < queryOrdersList.Count(); i++)
                    {
                        Session["j"] = i;
                 %>
				<tr height="35px">
					<td><%=queryOrdersList[(int)Session["j"]].getOrderNo()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getMovieName()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getCustomerName()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getPlayingDate()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getTime()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getHallName()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getSeat()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getPrice()%>元</td>
					<td><%=queryOrdersList[(int)Session["j"]].getStatement()%></td>
					<td><%=queryOrdersList[(int)Session["j"]].getGenerateDate()%></td>
					<td><a href="backStage_queryOrder.aspx?deleteOrderNo=<%=queryOrdersList[(int)Session["j"]].getOrderNo() %>">删除</a></td>
				</tr>
                <%} %>
				</table>
			</div>
			<div class="clear"></div>
            <div id="yeshu">
                <a href="">上一页</a>&nbsp;&nbsp;&nbsp;&nbsp;
                共1页&nbsp;&nbsp;&nbsp;&nbsp;
                <a href="">下一页</a>
            </div>
		</div>
		<!-- 右边内容结束 -->
	</div>
<!-- content 结束 -->


<!-- foot开始 -->
<div id="footer">
		<!-- 版权内容请在本组件"内容配置-版权"处填写 -->
		<br>
		技术支持：邹晶晶 徐琳格 黄之凡<br>
		<br>
</div>
<!-- foot结束 -->
<style>
#content2 .movie_manage table tr td{
	border-bottom:1px solid #8a8a8a;
}
#content2 .movie_manage{
	text-align:center;

}
#yeshu{
    text-align:center;
    margin-top:-50px;
    }
   
    #yeshu a:link{
		color:#000000;
		text-decoration:none;
    }
	#yeshu a:visited{
		color:#000000;
		text-decoration:none;
    }
    #yeshu a:hover{
		color:#000000;
		text-decoration:underline;
	}
	#yeshur a:active{
		color:#000000;
		text-decoration:underline;
	}
</style>
    </form>
</body>
</html>
