<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backStage_movieAdd.aspx.cs" Inherits="CinemaTicketingSystem.backStage_movieAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 后台管理系统 </title>
    <meta name="Generator" content="EditPlus">
    <meta name="Author" content="">
    <meta name="Keywords" content="">
    <meta name="Description" content="">
    <link rel="stylesheet" type="text/css" href="css/back.css">
    <style type="text/css">
    .pic_text{ color:Red;}
    .pic_label { color:Gray; margin-top:5px; margin-bottom:5px;}
    .pic_image { margin:0px;}
    </style>
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
				<h2>添加影片信息</h2>
				<hr height="2px" width="1000px">
				<div class="picture floatright" style="text-align:center">
						<div class="" style="border:1px solid #000000;width:250px;height:350px;margin-right:100px">
                            <div class="pic_image"><asp:Image ID="pic" runat="server" height="350px" width="250px"/></div>
                        </div>
                        <br>
						<div style="margin-right:80px">
                            <asp:Button ID="btn_upload" runat="server" Text="上传" onclick="btn_upload_Click"/>&nbsp;
                            <asp:FileUpload ID="pic_upload" runat="server" />
                            <asp:Label ID="lbl_pic" runat="server" class="pic_text"></asp:Label>
                        </div>
						<div class="clear"></div>
				</div>
				<table style="border:0px;margin-left:150px;" >
					<tr height="40px">
						<td align="right">影片编号：</td>
						<td><input type="text" name="movieNo"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">影片名称：</td>
						<td><input type="text" name="movieName"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">类型：</td>
						<td><input type="text" name="type"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">国家：</td>
						<td><input type="text" name="country"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">片长：</td>
						<td><input type="text" name="minute"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">导演：</td>
						<td><input type="text" name="director"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">主演/配音：</td>
						<td><input type="text" name="actors"></input></td>
					</tr>
					<tr height="40px">
						<td align="right">上映日期：</td>
						<td><input type="date" name="playDate" style="width:173" /></td>
					</tr>
					<tr height="40px">
						<td align="right">价格：</td>
						<td><input type="text" name="Price"></input></td>
					</tr>
					</table>
					<br>
				<hr height="2px" width="1000px">
				<table style="border:0px;margin-left:150px;" >
					<tr height="80px">
						<td align="right">总概：</td>
						<td><textarea name="summary" rows="3px" cols="80px"></textarea></td>
					</tr>
					<tr height="100px">
						<td align="right">故事简介：</td>
						<td><textarea name="briefIntroduction" rows="8px" cols="80px"></textarea></td>
					</tr>
				</table>
				<hr height="2px" width="1000px">	
					<!-- 片花图片 -->
					幕后片花
				<div class="pianhua" style="width:1000px;height:400px">
                    <br />
                    <div class="pianhua1" style="margin-left:140px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic1" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload1" runat="server" Text="上传" 
                            onclick="btn_upload1_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload1" runat="server" Width="180px" /><br />
                        <asp:Label ID="lbl_pic1" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    <div class="pianhua2" style="margin-left:40px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic2" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload2" runat="server" Text="上传" 
                            onclick="btn_upload2_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload2" runat="server" Width="180px"/><br />
                        <asp:Label ID="lbl_pic2" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    <div class="pianhua3" style="margin-left:40px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic3" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload3" runat="server" Text="上传" 
                            onclick="btn_upload3_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload3" runat="server" Width="180px"/><br />
                        <asp:Label ID="lbl_pic3" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    
                    <div class="pianhua1" style="margin-top:10px;margin-left:140px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic4" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload4" runat="server" Text="上传" 
                            onclick="btn_upload4_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload4" runat="server" Width="180px"/>
                        <asp:Label ID="lbl_pic4" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    <div class="pianhua1" style="margin-top:10px;margin-left:40px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic5" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload5" runat="server" Text="上传" 
                            onclick="btn_upload5_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload5" runat="server" Width="180px"/>
                        <asp:Label ID="lbl_pic5" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    <div class="pianhua1" style="margin-top:10px;margin-left:40px;float:left;">
                        <div class="pic_image"><asp:Image ID="pic6" runat="server" height="134px" width="214.6px"/></div>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_upload6" runat="server" Text="上传" 
                            onclick="btn_upload6_Click" />&nbsp;
                        <asp:FileUpload ID="pic_upload6" runat="server" Width="180px"/>
                        <asp:Label ID="lbl_pic6" runat="server" class="pic_text"></asp:Label>
                        <br />
                    </div>
                    
                </div>
				<hr height="2px" width="1000px">
				<asp:Button ID="Button1" runat="server" Text="提交" Width="45px" 
                    onclick="Button1_Click" />
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="button" value="返回" onclick="window.location.href='backStage_movieManagement.aspx'"></input>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="reset" onclick="window.location.href='backStage_movieAdd.aspx'"></input>
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
	height:1400px;
}
#caidan {
	height:1400px;
}
</style>
    </form>
</body>
</html>
