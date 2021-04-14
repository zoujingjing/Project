<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_playUpdate.aspx.cs" Inherits="CinemaTicketingSystem.backStage_playUpdate" %>

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
				<h2>修改放映信息</h2>
				<hr height="2px" width="1000px">
				<table style="border:0px;margin-left:150px;margin:auto" >
					<tr height="40px">
						<td align="right">影片编号：</td>
						<td><%=old_movieNo%></td>
					</tr>
					<tr height="40px">
						<td align="right">影片名称：</td>
						<td><input type="text" name="movieName" value="<%=old_movieName %>"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">影厅号：</td>
						<td><select name="hallName">
                            <option value="<%=old_hallName%>" selected><%=old_hallName%></option>
							<option value="一号厅">一号厅</option>
							<option value="二号厅">二号厅</option>
							<option value="三号厅">三号厅</option>
							<option value="四号厅">四号厅</option>
							<option value="五号厅">五号厅</option>
							<option value="六号厅">六号厅</option>
						</select></td>
					</tr>
					<tr height="40px">
						<td align="right">放映日期：</td>
						<td> <input type="date" name="playingDate" value="<%=old_playingDate %>"/></td>
					</tr>
					<tr height="40px">
						<td align="right">放映时间：</td>
						<td><select name="time">
							<option value="<%=old_time%>" selected><%=old_time%></option>
                            <option value="09:00">09:00</option>
							<option value="11:30">11:30</option>
							<option value="14:00">14:00</option>
							<option value="16:30">16:30</option>
							<option value="19:00">19:00</option>
							<option value="21:30">21:30</option>
						</select></td>
					</tr>
					</table>
				<hr height="2px" width="1000px">
				<asp:Button ID="Button1" runat="server" Text="提交" Width="45px" onclick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="button" value="返回" onclick="window.location.href='backStage_playManagement.aspx'"></input>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="reset" onclick="window.location.href='backStage_playAdd.aspx'"></input>
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
#content2 .movie_manage{
	text-align:center;
}
#content2 {
	height:700px;
}
#caidan {
	height:700px;
}
</style>
    </form>
</body>
</html>
