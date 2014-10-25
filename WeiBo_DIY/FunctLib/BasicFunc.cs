using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace WeiBo_DIY
{
   public static  class BasicFunc
    {
       /// <summary>
       /// 将图片转换成字节数组
       /// </summary>
       /// <param name="image"></param>
       /// <returns></returns>
       public static  byte[] ImageToByte(Image image)
       {     
           try
           {
               Image sceneImage = new Bitmap(image);
               ////实例化流       
               System.IO.MemoryStream imageStream = new System.IO.MemoryStream();
               //将图片的实例保存到流中       
               sceneImage.Save(imageStream, ImageFormat.Png);
               //保存流的二进制数组           
               byte[] imageContent = new Byte[imageStream.Length];
               imageStream.Position = 0;
               //将流写入数组中          
               imageStream.Read(imageContent, 0, (int)imageStream.Length);
               return imageStream.ToArray();
           }
           catch (Exception ex)
           {
               throw(ex);
           } 
       }

       /// <summary>
       /// 将获取到的微博文件添加到ListBox中
       /// </summary>
       /// <param name="MainForm"></param>
       /// <param name="JsonText"></param>
       public static void JsonInfo(MainForm MainForm, dynamic JsonText)
       {
           foreach (var status in JsonText.statuses)
           {
               if (status.IsDefined("user"))	//这里要判断下是不是有user这个项，一般微博被删除了就不会返回user，直接xxx.user要出错。
               {

                   MainForm.lstMessage.Items.Insert(0, string.Format("{0} 说：{1}", status.user.screen_name, status.text)+DateTime.Now.ToString());//打印用户名和他说的内容
                  
               }
           }
       }

       /// <summary>
       /// 展示获取到的微博状态
       /// </summary>
       /// <param name="MainForm"></param>
       /// <param name="JsonText"></param>
       public static void ShowStatus(MainForm MainForm, dynamic JsonText)
       {
           foreach (var status in JsonText.statuses)
           {
               if (status.IsDefined("user"))	//这里要判断下是不是有user这个项，一般微博被删除了就不会返回user，直接xxx.user要出错。
               {
                   ucWeiBoInfo ucStatusInfo = new ucWeiBoInfo(MainForm,status);
                   ucStatusInfo.Size= new System.Drawing.Size(MainForm.ControlsContainer.Size.Width,MainForm.ControlsContainer.Size.Height);//对每一条微博信息新建一个微博控件进行展示
                   MainForm.ControlsContainer.Controls.Add(ucStatusInfo);
               }
           }
       }
    }
}
