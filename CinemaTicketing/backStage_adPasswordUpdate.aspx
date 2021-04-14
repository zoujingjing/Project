<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_adPasswordUpdate.aspx.cs" Inherits="CinemaTicketingSystem.backStage_adPasswordUpdate" %>

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
			管理员：<%=(string)Session["name"] %>&nbsp;&nbsp;&nbsp;&nbsp;你好！&nbsp;&nbsp;&nbsp;<a href="homePage1.aspx">退出登录</a>
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
			<div class="manager_information">
			<table>
			<tr height="40px">
				<td align="right">原密码：</td>
				<td><input type="password" name="beforecode"></input></td>
			</tr>
			<tr height="40px">
				<td align="right">新密码：</td>
				<td><input type="password" name="newcode"></input></td>
			</tr>
			<tr height="40px">
				<td align="right">确认新密码：</td>
				<td><input type="password" name="renewrode"></input></td>
			</tr>
            </table><br>
			<%
           		if(message!=null){
         	    %>
                <div class = "error"><font color=red ><%=message %></font></div>
   		    <%} %>
			<br>
				&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="button" value="返回" onclick="window.location.href='backStage_main.aspx'"></input>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="reset" onclick="window.location.href='backStage_adPasswordUpdate.aspx'"></input>
&nbsp;<div class="clear"></div>
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
    </form>
</body>
</html>
