<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movieInfo.aspx.cs" Inherits="CinemaTicketingSystem.movieInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 影片资讯 </title>
    <meta charset="utf-8"/>
    <meta name="Generator" content="你的开发工具">
    <meta name="Author" content="木木">
    <meta name="Keywords" content="关键字">
    <meta name="Description" content="网页描述">
    <link rel="stylesheet" type="text/css" href="css/blue.css">
</head>
<body>
    
	<form id="form1" runat="server">
    
	<div id="header">
		影片资讯
		<div class="floatright" id="choose">
			<ul>
				<li><a href="homePage2.aspx" target="_self"><font size = 2px>首页</font></a></li>
				<li>|</li>
				<li><a href="" target="_self"><font size = 2px>影片资讯</font></a></li>
				
			</ul>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content0"> 
		<div class="floatright" id="content-right">
			<div class="shouye_picture">
				<img src="images/detail_shouye.jpg" height="500px" width="400px"></img>
			</div>
			<div class="clear"></div>
		</div>
		<div class="floatleft" id="content-left">
			<br/>
			<br/>
			<b>影片列表</b>
			<br/>
			<br/>
            
            
			<ul>
            <%  
                for (int i = 0; i < list.Count(); i++)
                {
                    Session["j"] = i;
                    %>
                <li style="margin-bottom:10px"><a href = "movieDetail.aspx?content=<%=list[(int)Session["j"]] %>" target="_self"><%=list[(int)Session["j"]] %></a></li>
                 
            <%  
                } %>

			</ul>
           
			<div class="clear"></div>
		</div>
		<div class="clear"></div>
	</div>

	<div id="footer">
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

    </form>

 </body>
</html>
