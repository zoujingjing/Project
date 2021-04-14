<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movieList.aspx.cs" Inherits="CinemaTicketingSystem.movieList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
        <meta charset="UTF-8">
        <title>影院影片列表</title>
        <link rel="stylesheet" type="text/css" href="js/jquery-easyui-1.4.5/themes/default/easyui.css">
        <link rel="stylesheet" type="text/css" href="js/jquery-easyui-1.4.5/themes/icon.css">
        <script type="text/javascript" src="js/jquery-easyui-1.4.5/jquery.min.js"></script>
        <script type="text/javascript" src="js/jquery-easyui-1.4.5/jquery.easyui.min.js"></script> 
 
</head>
<body>
	<form id="form1" runat="server">
	<div id = "headbar">
		<h1 class = "center">影院售票系统</h1>
		<hr color = #6666ff>
		<div class = "section1" style = "float: left; margin-left:100px;">
			<div class = "one" style="float: left; margin-left:150px"><a href="" style = "color:#6666ff">首页</a></div>
			<div class = "one" style="float: left; margin-left:80px"><a href="" style = "color:#6666ff">影片资讯</a></div>
			<div class = "one" style="float: left; margin-left:80px"><a href="" style = "color:#6666ff">用户登录</a></div>
			<div class = "one" style="float: left; margin-left:80px"><a href="" style = "color:#6666ff">后台管理</a></div>
		</div>
	</div>
    


 <div title="高考成绩管理" data-options="iconCls:'icon-ok',closable:true" style="padding:10px;margin-left:15%;margin-right:15%">
	<table id="dg" title="所有影片信息列表" class="easyui-datagrid" style="width:100%;height:500px" url="get_users.php" toolbar="#tb" pagination="true" rownumbers="true" fitColumns="true" singleSelect="true">
		<thead>     
			<tr>
				<th field="moviename" width="10">影片名称</th>
				<th field="type" width="10">类型</th>
				<th field="country" width="10">国家</th>
				<th field="director" width="10">导演</th>
				<th field="actors" width="10">主演/配音</th> 
				<th field="playtime" width="10">上映日期</th>
				<th field="price" width="10">票价￥</th>
				<th field="detail" width="10">详细情况</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>千与千寻</td><td>奇幻 动画</td><td>日本</td><td>宫崎骏</td><td>柊瑠美、中村彰男、夏木真理</td><td>2017/12/4</td><td>20</td>
				<td><a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-search'"></a></td>
			</tr>
			<tr>
				<td>你的名字</td><td>爱情 动画</td><td>日本</td><td>新海诚</td><td>神木隆之介 上白石萌音</td><td>2017/12/4</td><td>20</td>
				<td><a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-search'"></a></td>
			</tr>
			
			
			
			
			
		</tbody>
	</table>
	<div id="tb" style="padding:2px 5px;"> 
		<div style="margin-bottom:20px">
			<label class="label-top">影片名称:</label>
            <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="165px"></asp:TextBox>
			&nbsp;
		    <asp:Button ID="Button1" runat="server" Text="查询" Height="24px" onclick="Button1_Click" Width="59px" />		
		</div>
	</div>
 </div>


	<style>
		#headbar{
			height:100px;
			margin-left:15%;
			margin-right:15%;
			background-color: #E0ECFF;
	    }
		.center {
			height:30px;
			text-align:center;
			color:#6666ff;
			font-size:50px;
			font-family:KaiTi;
			word-spacing:10px;
			margin-top:-8px;
		}
	
    </style>
    </form>
 </body>
</html>
