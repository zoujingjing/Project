<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homePage1.aspx.cs" Inherits="CinemaTicketingSystem.homePage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 影院售票系统 </title>
  <meta name="Generator" content="EditPlus">
  <meta name="Author" content="">
  <meta name="Keywords" content="">
  <meta name="Description" content="">
    <link rel="stylesheet" type="text/css" href="css/shouye1.css">
</head>
   <body>
    <form id="form1" runat="server">
    <div id = "headbar">
		<br>
		<h1 class = "center">影院售票系统</h1>
		<hr color = #FFFFFF>
		<div class = "section3" >
			<ul>
				<li><a href="">首页</a></li>
				<li><a href="movieInfo.aspx">影片资讯</a></li>
				<li><a href="login.aspx">用户登录</a></li>
				<li><a href="backStage_login.aspx">后台管理</a></li>
			</ul>
		</div>
	</div>

    <div id="butong_net_left" style="overflow:hidden;height:350px;margin-top:30px;background-color:#000000">
		<br>
		<table cellpadding="0" cellspacing="0" border="0">
			<tr>
				<td id="butong_net_left1" valign="bottom" align="center">
					<table cellpadding="2" cellspacing="0" border="0">
						<tr align="center" >
							<td><img src="<%=movieList[0].getImageMain() %>" style="width:200px;height:300px"></td>
							<td><img src="<%=movieList[1].getImageMain()%>" style="width:200px;height:300px"></td>
							<td><img src="<%=movieList[2].getImageMain()%>" style="width:200px;height:300px"></td>
							<td><img src="<%=movieList[3].getImageMain()%>" style="width:200px;height:300px"></td>
							<td><img src="<%=movieList[4].getImageMain()%>" style="width:200px;height:300px"></td>
							<td><img src="<%=movieList[5].getImageMain()%>" style="width:200px;height:300px"></td>
						</tr>
					</table>
				</td>
				<td id="butong_net_left2" valign="top"></td>
			</tr>
		</table>
	</div>

	
	<div id="more">
			<br>
			&nbsp;&nbsp;&nbsp;&nbsp;<a href="movieInfo.aspx">>>更多</a>
			<br>
			<br>
	</div>
	<div id = "section2">
		<div class = "list" style = "float:left;width:50%;margin-left:0px">
			<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[0].getMovieName() %>"><img src = "<%=movieList[0].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px;">
					<p><b>电影名称：</b><%=movieList[0].getMovieName() %><br>
					   <b>导演：</b><%=movieList[0].getDirector() %><br>
					   <b>主演：</b><%=movieList[0].getActors() %><br>
					   <b>类型：</b><%=movieList[0].getType() %><br>
					   <b>国家：</b><%=movieList[0].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[0].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[0].getSummary() %>
					</p>
				</div>
			</div>
			<div class = "list" style = "float:left;width:50%">
				<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[1].getMovieName() %>"><img src = "<%=movieList[1].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px;">
					<p><b>电影名称：</b><%=movieList[1].getMovieName() %><br>
					   <b>导演：</b><%=movieList[1].getDirector() %><br>
					   <b>主演：</b><%=movieList[1].getActors() %><br>
					   <b>类型：</b><%=movieList[1].getType() %><br>
					   <b>国家：</b><%=movieList[1].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[1].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[1].getSummary() %>
					</p>
				</div>
			</div>
			<div class = "list" style = "float:left;width:50%;margin-top:20px">
				<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[2].getMovieName() %>"><img src = "<%=movieList[2].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px">
					<p><b>电影名称：</b><%=movieList[2].getMovieName() %><br>
					   <b>导演：</b><%=movieList[2].getDirector() %><br>
					   <b>主演：</b><%=movieList[2].getActors() %><br>
					   <b>类型：</b><%=movieList[2].getType() %><br>
					   <b>国家：</b><%=movieList[2].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[2].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[2].getSummary() %>
					</p>
				</div>
			</div>
            <div class = "list" style = "float:left;width:50%;margin-top:20px">
				<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[3].getMovieName() %>"><img src = "<%=movieList[3].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px">
					<p><b>电影名称：</b><%=movieList[3].getMovieName() %><br>
					   <b>导演：</b><%=movieList[3].getDirector() %><br>
					   <b>主演：</b><%=movieList[3].getActors() %><br>
					   <b>类型：</b><%=movieList[3].getType() %><br>
					   <b>国家：</b><%=movieList[3].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[3].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[3].getSummary() %>
					</p>
				</div>
			</div>
			<div class = "list" style = "float:left;width:50%;margin-top:20px">
				<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[4].getMovieName() %>"><img src = "<%=movieList[4].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px">
					<p><b>电影名称：</b><%=movieList[4].getMovieName() %><br>
					   <b>导演：</b><%=movieList[4].getDirector() %><br>
					   <b>主演：</b><%=movieList[4].getActors() %><br>
					   <b>类型：</b><%=movieList[4].getType() %><br>
					   <b>国家：</b><%=movieList[4].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[4].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[4].getSummary() %>
					</p>
				</div>
			</div>
			<div class = "list" style = "float:left;width:50%;margin-top:20px">
				<div class = "picture" sytle = "float:left"><a href = "movieDetail.aspx?content=<%=movieList[5].getMovieName() %>"><img src = "<%=movieList[5].getImageMain() %>" height = 250px width = 200px></a></div>
				<div class = "description" style = "float:left;margin-top:-250px;margin-left:220px">
					<p><b>电影名称：</b><%=movieList[5].getMovieName() %><br>
					   <b>导演：</b><%=movieList[5].getDirector() %><br>
					   <b>主演：</b><%=movieList[5].getActors() %><br>
					   <b>类型：</b><%=movieList[5].getType() %><br>
					   <b>国家：</b><%=movieList[5].getCountry() %><br>
					   <b>上映时间：</b><%=movieList[5].getPlayDate() %><br>
					   <b>内容简介：</b><%=movieList[5].getSummary() %>
					</p>
				</div>
			</div>
			<div class="clear"></div>
		</div>
		
   <div id = "footbar">
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
    </form>
</body>
</html>
