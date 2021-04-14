<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Changci.aspx.cs" Inherits="CinemaTicketingSystem.Changci" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> 影片场次列表 </title>
    <meta charset="utf-8"/>
    <meta name="Generator" content="你的开发工具">
    <meta name="Author" content="木木">
    <meta name="Keywords" content="关键字">
    <meta name="Description" content="网页描述">
    <link rel="stylesheet" type="text/css" href="css/chaxun.css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
		影片详情咨询
		<div class="floatright" id="choose">
			<ul>
				<li><a href="movieInfo.aspx" target="_self"><font size = 2px>影片资讯</font></a></li>
	
			</ul>
			<div class="clear"></div>
		</div>
	</div>
	<div id="content1">
		<br/>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b><%=sessionList[0].getMovieName() %></b>  —————————————————  <%=sessionList[0].getType() %>
		<br/>
		<br/>
	</div>
	<div id="table1">
		<br/>
		<br/>
		<table border="1" width="800px" style="margin:auto">
		<tr>
			<td align="center" valign="middle">日期</td>
			<td align="center" valign="middle">时间</td>
			<td align="center" valign="middle">厅号</td>
            <td align="center" valign="middle">影厅类型</td>
			<td align="center" valign="middle">价格</td>
			<td align="center" valign="middle">购票</td>
		</tr>
        <%  
            for (int i = 0; i < sessionList.Count(); i++)
            {
               Session["j"] = i;
               int m = -1;
         %>
		<tr>
           <%
               int k = (int)Session["j"] - 1;
               if (k == -1) { flag = true; }
               else if (sessionList[(int)Session["j"]].getPlayingDate().Equals(sessionList[k].getPlayingDate()))
               { 
                   flag = false; 
               }
               else 
               { 
                   flag = true;
               }
               if(flag)
               {
                   m = m + 1;%>
			<td align="center" valign="middle" rowspan="<%=countList[m] %>"><%=sessionList[(int)Session["j"]].getPlayingDate()%></td>
			<%    
              } %>
            <td align="center" valign="middle"><%=sessionList[(int)Session["j"]].getTime()%></td>
			<td align="center" valign="middle"><%=sessionList[(int)Session["j"]].getHallName()%></td>
            <td align="center" valign="middle"><%=sessionList[(int)Session["j"]].getHallType()%></td>
			<td align="center" valign="middle"><%=sessionList[(int)Session["j"]].getPrice()%></td>
			<td align="center" valign="middle"><a href="selectSeats.aspx?movie=<%=sessionList[0].getMovieName() %>&date=<%=sessionList[(int)Session["j"]].getPlayingDate()%>&time=<%=sessionList[(int)Session["j"]].getTime()%>&hall=<%=sessionList[(int)Session["j"]].getHallName()%>&price=<%=sessionList[(int)Session["j"]].getPrice()%>">购买</a></td>
		</tr>
		<%} %>
		</table>
		<br/>
		<br/>
	</div>
	
   <div id = "footer">
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
