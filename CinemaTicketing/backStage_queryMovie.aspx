<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_queryMovie.aspx.cs" Inherits="CinemaTicketingSystem.backStage_queryMovie" %>


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
					<option value="影片编号">影片编号</option>
					<option value="影片名称">影片名称</option>
                </select>
                &nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="Button1" runat="server" Height="25px" Text="查询" Width="45px" 
                    onclick="Button1_Click" />
				&nbsp;&nbsp;&nbsp;&nbsp;
				<a href="backStage_movieAdd.aspx">添加</a>
				<!-- 影片列表 --><br><br><br>
				<table style="text-align:center" height="auto">
				<tr height="50px" border="1px">
					<td width="120px"><b>影片编号</b></td>
					<td width="80px"><b>影片名称</b></td>
					<td width="60px"><b>类型</b></td>
					<td width="60px"><b>国家</b></td>
					<td width="85px"><b>片长</b></td>
					<td width="100px"><b>导演</b></td>
					<td width="350px"><b>主演/配音</b></td>
					<td width="140px"><b>上映日期</b></td>
					<td width="60px"><b>价格</b></td>
					<td colspan="2" width="95px"><b>操作</b></td>
				</tr>
                <tr height="35px">
					<td><%=queryMovie.getMovieNo()%></td>
					<td><%=queryMovie.getMovieName()%></td>
					<td><%=queryMovie.getType()%></td>
					<td><%=queryMovie.getCountry()%></td>
					<td><%=queryMovie.getMinute()%></td>
					<td><%=queryMovie.getDirector()%></td>
					<td><%=queryMovie.getActors()%></td>
					<td><%=queryMovie.getPlayDate()%></td>
					<td><%=queryMovie.getPrice()%></td>
					<td><a href="backStage_movieUpdate.aspx?movieNo=<%=queryMovie.getMovieNo()%>">编辑</a></td>
					<td><a href="backStage_movieManagement.aspx?deleteMovieNo=<%=queryMovie.getMovieNo()%>">删除</a></td>
				</tr>
				</table>
			</div>
			<div class="clear"></div>
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
