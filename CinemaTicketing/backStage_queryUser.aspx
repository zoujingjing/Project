<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_queryUser.aspx.cs" Inherits="CinemaTicketingSystem.backStage_queryUser" %>

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
			管理员：<%=(String)Session["username"] %>&nbsp;&nbsp;&nbsp;&nbsp;你好！&nbsp;&nbsp;&nbsp;<a href="homePage1.aspx">退出登录</a>
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
				请输入查询条件：<input type="text" name="TextBox1"></input>
				</td>
				&nbsp;<asp:Button ID="Button1" runat="server" Text="查询" 
                    onclick="Button1_Click" />
				<br>
				<hr height="2px" width="1000px">
				<!-- 用户列表 -->
				<table style="text-align:center;margin:auto" height="auto">
                <tr height="50px" border="1px">
					<td width="80px"><b>姓名</b></td>
					<td width="80px"><b>性别</b></td>
					<td width="250px"><b>邮箱</b></td>
					<td width="90px"><b>用户名</b></td>
					<td width="150px"><b>手机号</b></td>
				</tr>
                <%  
                    for (int i = 0; i < list.Count(); i++)
                {%>
				<tr height="50px">
				<td><%=list[i].getName()%></td>
                <td><%=list[i].getSex()%></td>
                <td><%=list[i].getEmail()%></td>
                <td><%=list[i].getUsername()%></td>
                <td><%=list[i].getPhone()%></td>
			</tr><%} %>
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
</style>
    </form>
</body>
</html>
