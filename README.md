# 需求文档
**小组成员：邹晶晶 徐琳格 黄之凡**
## 一、系统名称
影院售票系统
## 二、系统开发的背景
&ensp;&ensp;&ensp;&ensp;随着社会的不断发展，电影摄影及放映技术也与时俱进，特别是近年来轰动全世界的3D电影《阿凡达》的问题，促使群众对电影的观看从家里观看DVD慢慢的转向了高级影城去观看电影。近年来随着去电影院观看电影的人数的增多，电影票的订购以及管理的问题也越来越突出的摆在了工作人员的面前，所以人们迫切的需要一套完整的售票及管理系统来帮助人们解决这些繁杂的事情。
## 三、系统开发的目的
&ensp;&ensp;&ensp;&ensp;影院售票系统是辅助影院进行销售电影票的系统应用软件，是可以集管理、电影票销售以及统计查看功能为一身的应用程序。传统的人工售票的方式手续繁琐、效率低下。为了提高售票效率，同时也方便客户，因此开发一个面向客户的、自主在线的影院售票系统是及其必要的。影院售票系统的目的在于，一能方便用户查看最近影片，并随时随地能购买电影票，节省用户大量时间，丰富用户的生活；二能提高影院的售票效率，招揽更多的潜在客户，提高影院的收益。
## 四、系统的总体设计和及其所要实现的功能。
&ensp;&ensp;&ensp;&ensp;系统主要分为三大模块：系统前台模块设计、系统后台模块设计和数据库设计。
### 1、系统前台模块设计
&ensp;&ensp;&ensp;&ensp;系统前台主要实现的功能有：网站首页模块、用户登录模块、用户注册模块、影片详细咨询模块、购票支付模块和个人后台模块。<br>
&ensp;&ensp;&ensp;&ensp;网站首页的布局分为用户登录注册和影片资讯两大部分。<br>
&ensp;&ensp;&ensp;&ensp;用户登录注册部分：<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;**（1）用户注册模块**
本模块用于新用户的注册，注册后的用户可享受本平台提供的一切服务。该模块主要是新用户输入自己的相关数据，包括用户名、密码、确认密码、姓名、电话、邮箱、性别。当用户将所有模块填好后，点击确定按钮，即为注册成功，返回官网首页。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;**（2）用户登录模块**
本模块用于已经在本网站注册过的用户进行登录，享受本网站提供的服务。
用户进入登陆模块，输入账号密码。若二者相符合，直接进入登录后页面；若二者不符，给出提示，用户重新输入。
在此模块中，我们提供了找回密码（忘记密码）服务，用户若忘记注册密码，可进行找回。点击“忘记密码”按钮，进入找回密码界面。本平台提供通过邮箱找回密码的方式，用户输入注册邮箱，系统会自动发送一封邮件到用户邮箱中，该邮件附带一个链接。用户进入邮箱，点击该链接，证明当下改动是由本人操作完成，此时界面跳转到更改密码的界面。用户输入新密码，并再次确认新密码，点击确认，密码更改成功，此时跳转到登录界面。
用户使用新密码即可进行登录。<br>
&ensp;&ensp;&ensp;&ensp;影片咨询部分：<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;在网站首页模块有一个栏目滚动播放最新影片，用户可以在登录之前进行浏览。如果用户对滚动播放的影片感兴趣，则可以点击影片进入该影片的详细咨询模块，进一步了解该影片的信息。滚动播放栏目下方有一个“更多影片”的按钮，用户可以通过点击它进入到所有影片信息列表的一个界面，影片列表包括影片名，导演、
主演，影片类型，国家，上映时间，票价和“详细情况”按钮，并且列表头部具有查询影片的功能。若用户对某一个影片感兴趣也可以点击“详细情况”进入到该影片的详细介绍模块。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;**影片详细咨询模块**中又包含了两大模块：影片详细介绍模块和影片场次列表模块。影片详细介绍模块主要描述了某一部影片的详细信息，包含影片名，影片导演、主演，影片类型，国家，影片内容简介。影片场次列表模块了包含了该影片上映的具体时间和具体场次，每一场次都有“购票”按钮。用户可以自由选择场次进行购票。点击“购票”时，用户进入到购票支付模块，在该模块中用户可以进行选座，用户选择座位后点击支付即可完成购票。当购票成功后，会生成一个界面显示用户购票成功，同时有一个“查看订单”按钮。点击它可以进入到订单详细界面。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;**个人后台模块：**
用户登录后，可以进入用户个人中心。在个人中心中有个人信息、我的钱包、卡包、我的订单以及客服中心五大功能。在“个人信息”中，用户可以进行个人信息修改；“我的钱包”中可以显示当前钱包的余额和支付密码设置；“卡包”可以显示当前绑定的银行卡，以及添加银行卡和解绑的功能；在“我的订单”中能够显示该用户所有的订单记录，点击某一个订单，可以显示该订单的详细情况，包括订单号，影片名，放映时间，放映地点，座位号等。同时每一个未完成的订单有一个退款的功能，用户可以进行退票操作。“客服中心”是一个即时通讯界面，帮助用户在遇到问题时可以向客服进行咨询，从而获得帮助。
### 2、系统后台模块设计
&ensp;&ensp;&ensp;&ensp;后台共分为三个功能模块：影片信息管理模块、订票信息管理模块、用户信息管理模块。<br>
&ensp;&ensp;&ensp;&ensp;管理员从后台登陆页面正确输入用户名和密码以后可以转到系统后台页面。后台页面有影片信息管理模块、订票信息管理模块和用户信息管理模块。<br>
&ensp;&ensp;&ensp;&ensp;**影片信息管理模块：**<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;添加影片信息：管理员在后台影片信息管理界面中，详细填写有关影片的信息（包括电影编号、电影名称、导演、主演、影片类型、国家、片长、上映时间、票价、图片和电影简介）以后，点击添加，系统就会把影片信息添加到数据库里。在		前台也可以浏览该信息。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;查询影片信息模块中有修改和删除影片功能。在修改页面中修改完影片信息以后，点击修改，数据库就会自动更新有关数据。点击删除影片，数据库就会删除该数据。<br>
&ensp;&ensp;&ensp;&ensp;**订票信息管理模块：** <br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;添加订票信息：管理员在后台订票信息管理界面中，可手动添加注册用户的订票记录。管理员需填写对应的用户名和影片信息（包括电影编号、电影名称、放映时间和场次、座位、票价），点击添加，系统就会把订票信息添加到数据库里。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;查询订票信息模块中有修改和删除订票记录功能。在修改页面修改完订票信息以后，点击修改，数据库就会自动更新有关数据。点击删除订票信息，数据库就会删除该数据。<br>
&ensp;&ensp;&ensp;&ensp;**用户信息管理模块：**<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;添加用户信息：管理员在后台用户信息管理界面中，可手动添加注册用户的信息。管理员需填写对应的用户信息（包括用户编号和初始密码），点击添加，系统就会把用户信息添加到数据库里。<br>
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;查询用户信息模块中可修改和删除用户。在修改页面修改完用户信息以后，点击修改，数据库就会自动更新有关数据。点击删除用户，数据库就会删除该数据。
