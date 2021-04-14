<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movieDetail.aspx.cs" Inherits="CinemaTicketingSystem.movieDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 影片详情 </title>
    <meta charset="utf-8"/>
    <meta name="Generator" content="你的开发工具">
    <meta name="Author" content="木木">
    <meta name="Keywords" content="关键字">
    <meta name="Description" content="网页描述">
    <link rel="stylesheet" type="text/css" href="css/blue.css">
</head>
<body>
	<div id="header">
		影片详情
		<div class="floatright" id="choose">
			<ul>
				<li><a href="homePage2.aspx" target="_self"><font size = 2px>首页</font></a></li>
				<li>|</li>
				<li><a href="movieInfo.aspx" target="_self"><font size = 2px>影片资讯</font></a></li>

			</ul>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content0"> 
		<div class="floatright" id="content-right">
			<div class="floatright" id="picture">
				<img src="<%=mov.getImageMain() %>" height="350px" width="250px">
				<br><br>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<a href="Changci.aspx?content=<%=mov.getMovieName() %> " target="_self">场次列表</a>
				<div class="clear"></div>
			</div>	
			
			<div class="floatleft" id="jieshao">
               
				<i><b>电影编号：</b></i><%=mov.getMovieNo() %><br/>
				<br/>
				<i><b>影片名称：</b></i><%=mov.getMovieName() %><br/>
				<br/>
                <i><b>类型：</b></i><%=mov.getType() %><br/>
				<br/>
                <i><b>国家：</b></i><%=mov.getCountry() %><br/>
				<br/>
                <i><b>片长：</b></i><%=mov.getMinute() %><br/>
				<br/>
				<i><b>导演：</b></i><%=mov.getDirector() %>
				<br/>
				<br/>
				<i><b>主要演员/配音：</b></i><%=mov.getActors() %>
				<br/>
				<br/>
				<i><b>上映时间：</b></i><%=mov.getPlayDate() %>
				<br/>
				<br/>
				<i><b>剧情简介：</b></i><%=mov.getBriefIntroduction() %>
				<br/>
				<br/>
				<div class="clear"></div>
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
				<li style="margin-bottom:10px"><a href="movieDetail.aspx?content=<%=list[(int)Session["j"]] %>" target="_self"><%=list[(int)Session["j"]] %></a></li>
				<%  
                } %>
			</ul>
			<div class="clear"></div>
		</div>
		<div class="clear"></div>
	</div>

	<div id="pianhua">
		<br/>
		幕后片花<br/>
		<br/>
		<div id="butong_net_left" style="overflow:hidden;height:auto;margin-left:15px;margin-right:15px;">
			<table cellpadding="0" cellspacing="0" border="0">
				<tr>
					<td id="butong_net_left1" valign="bottom" align="center">
						<table cellpadding="2" cellspacing="0" border="0">
							<tr align="center" >
								<td><img src="<%=mov.getImage1() %>" height="134px" width="214.6px"></td>
								<td><img src="<%=mov.getImage2() %>" height="134px" width="214.6px"></td>
								<td><img src="<%=mov.getImage3() %>" height="134px" width="214.6px"></td>
								<td><img src="<%=mov.getImage4() %>" height="134px" width="214.6px"></td>
								<td><img src="<%=mov.getImage5() %>" height="134px" width="214.6px"></td>
								<td><img src="<%=mov.getImage6() %>" height="134px" width="214.6px"></td>
						</tr>
					</table>
				</td>
				<td id="butong_net_left2" valign="top"></td>
			</tr>
		</table>
		</div>
		&nbsp;<br/>
		&nbsp;<br/>
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
		<br><a href=""></a>
	</div>	 
	<script>
	    var speed = 30//速度数值越大速度越慢
	    butong_net_left2.innerHTML = butong_net_left1.innerHTML
	    function Marquee3() {
	        if (butong_net_left2.offsetWidth - butong_net_left.scrollLeft <= 0)
	            butong_net_left.scrollLeft -= butong_net_left1.offsetWidth
	        else {
	            butong_net_left.scrollLeft++
	        }
	    }
	    var MyMar3 = setInterval(Marquee3, speed)
	    butong_net_left.onmouseover = function () {
	        clearInterval(MyMar3)
	    }
	    butong_net_left.onmouseout = function () {
	        MyMar3 = setInterval(Marquee3, speed)
	    }
	</script>
 </body>
</html>
