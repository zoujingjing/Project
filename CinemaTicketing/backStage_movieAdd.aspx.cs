using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CinemaTicketingSystem.Entity;
using System.IO;
using System.Security.Cryptography;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CinemaTicketingSystem
{
    public partial class backStage_movieAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //设置virpath变量用来存放图片的路径，图片包括海报和幕后片花
        string virpath;  
        string virpath1;
        string virpath2;
        string virpath3;
        string virpath4;
        string virpath5;
        string virpath6;
        
        
        /// <summary>
        /// 验证是否指定的图片格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            //限定只能上传jpg和gif图片
            string[] allowExtension = { ".jpg", ".gif", ".bmp", ".png" };
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }

        /// <summary>
        /// 创建一个指定长度的随机salt值
        /// </summary>
        public string CreateSalt(int saltLenght)
        {
            //生成一个加密的随机数
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[saltLenght];
            rng.GetBytes(buff);
            //返回一个Base64随机数的字符串
            return Convert.ToBase64String(buff);
        }


        /// <summary>
        /// 返回加密后的字符串
        /// </summary>
        public string CreatePasswordHash(string pwd, int saltLenght)
        {
            string strSalt = CreateSalt(saltLenght);
            //把密码和Salt连起来
            string saltAndPwd = String.Concat(pwd, strSalt);
            //对密码进行哈希
            string hashenPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
            //转为小写字符并截取前16个字符串
            hashenPwd = hashenPwd.ToLower().Substring(0, 16);
            //返回哈希后的值
            return hashenPwd;
        }

        //上传海报以及幕后片花
        protected void btn_upload_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath = filepath + CreatePasswordHash(pic_upload.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                        pic_upload.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic.ImageUrl = virpath;
                        Session["imageMain"] = virpath;//记录海报图片存储路径
                        //清空提示
                        lbl_pic.Text = "";
                    }
                    else
                    {
                        pic.ImageUrl = "";
                        lbl_pic.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic.ImageUrl = "";
                    lbl_pic.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic.ImageUrl = "";
                lbl_pic.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload1_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload1.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload1.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload1.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath1 = filepath + CreatePasswordHash(pic_upload1.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath1);//转换成服务器上的物理路径
                        pic_upload1.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic1.ImageUrl = virpath1;
                        Session["image1"] = virpath1;
                        //清空提示
                        lbl_pic1.Text = "";
                    }
                    else
                    {
                        pic1.ImageUrl = "";
                        lbl_pic1.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic1.ImageUrl = "";
                    lbl_pic1.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic1.ImageUrl = "";
                lbl_pic1.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload2_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload2.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload2.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload2.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath2 = filepath + CreatePasswordHash(pic_upload2.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath2);//转换成服务器上的物理路径
                        pic_upload2.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic2.ImageUrl = virpath2;
                        Session["image2"] = virpath2;
                        //清空提示
                        lbl_pic2.Text = "";
                    }
                    else
                    {
                        pic2.ImageUrl = "";
                        lbl_pic2.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic2.ImageUrl = "";
                    lbl_pic2.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic2.ImageUrl = "";
                lbl_pic2.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload3_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload3.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload3.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload3.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath3 = filepath + CreatePasswordHash(pic_upload3.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath3);//转换成服务器上的物理路径
                        pic_upload3.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic3.ImageUrl = virpath3;
                        Session["image3"] = virpath3;
                        //清空提示
                        lbl_pic3.Text = "";
                    }
                    else
                    {
                        pic3.ImageUrl = "";
                        lbl_pic3.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic3.ImageUrl = "";
                    lbl_pic3.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic3.ImageUrl = "";
                lbl_pic3.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload4_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload4.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload4.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload4.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath4 = filepath + CreatePasswordHash(pic_upload4.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath4);//转换成服务器上的物理路径
                        pic_upload4.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic4.ImageUrl = virpath4;
                        Session["image4"] = virpath4;
                        //清空提示
                        lbl_pic4.Text = "";
                    }
                    else
                    {
                        pic4.ImageUrl = "";
                        lbl_pic4.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic4.ImageUrl = "";
                    lbl_pic4.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic4.ImageUrl = "";
                lbl_pic4.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload5_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload5.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload5.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload5.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath5 = filepath + CreatePasswordHash(pic_upload5.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath5);//转换成服务器上的物理路径
                        pic_upload5.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic5.ImageUrl = virpath5;
                        Session["image5"] = virpath5;
                        //清空提示
                        lbl_pic5.Text = "";
                    }
                    else
                    {
                        pic5.ImageUrl = "";
                        lbl_pic5.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic5.ImageUrl = "";
                    lbl_pic5.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic5.ImageUrl = "";
                lbl_pic5.Text = "请选择要上传的图片！";
            }
        }

        protected void btn_upload6_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload6.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload6.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload6.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/uploadimages/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        virpath6 = filepath + CreatePasswordHash(pic_upload6.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath6);//转换成服务器上的物理路径
                        pic_upload6.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic6.ImageUrl = virpath6;
                        Session["image6"] = virpath6;
                        //清空提示
                        lbl_pic6.Text = "";
                    }
                    else
                    {
                        pic6.ImageUrl = "";
                        lbl_pic6.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic6.ImageUrl = "";
                    lbl_pic6.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic6.ImageUrl = "";
                lbl_pic6.Text = "请选择要上传的图片！";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLConnection sqlconnection = new SQLConnection();
            //获取前台网页所提交的数据
            string movieNo = Request.Form["movieNo"];
            string movieName = Request.Form["movieName"];
            string type = Request.Form["type"];
            string country = Request.Form["country"];
            string minute = Request.Form["minute"];
            string director = Request.Form["director"];
            string actors = Request.Form["actors"];
            string playDate = Request.Form["playDate"];
            string price = Request.Form["price"];
            string summary = Request.Form["summary"];
            string briefIntroduction = Request.Form["briefIntroduction"];
            string imageMain = (string)Session["imageMain"];
            string image1 = (string)Session["image1"];
            string image2 = (string)Session["image2"];
            string image3 = (string)Session["image3"];
            string image4 = (string)Session["image4"];
            string image5 = (string)Session["image5"];
            string image6 = (string)Session["image6"];

            if (movieNo == null)
            {
                Response.Write("<script>alert('你没有输入影片编号，无法进行影片的添加！');</script>");
            }
            else 
            {
                sqlconnection.openDatabase();
                string sqlyuju = "insert into Movies(MovieNo,MovieName,Type,Country,Minute,Director,Actors,PlayDate,Price,Summary,BriefIntroduction,ImageMain,Image1,Image2,Image3,Image4,Image5,Image6) values('" + movieNo + "','" + movieName + "','" + type + "','" + country + "','" + minute + "','" + director + "','" + actors + "','" + playDate + "','" + price + "','" + summary + "','" + briefIntroduction + "','" + imageMain + "','" + image1 + "','" + image2 + "','" + image3 + "','" + image4 + "','" + image5 + "','" + image6 + "')";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);

                cmd.ExecuteNonQuery();

                sqlconnection.closeDatabase();
                Response.Write("<script>alert('添加成功!');window.location.href ='backStage_movieManagement.aspx'</script>");
            }


        }

    }
}