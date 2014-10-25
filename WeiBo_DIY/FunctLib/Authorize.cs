using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetDimension.Weibo;

namespace WeiBo_DIY
{
    public static class Authorize
    {
        //初始化oAuth，准备认证
          public static   OAuth  oauth ;
          public static  AccessToken  accessToken;
        /*
             * 正常的流程或Web流程：
             * 1. 获取授权地址
             * 2. 访问授权地址
             * 3. 授权成功后自动跳转至callback指定的网站，并获得code
             * 4. 通过code换取access token
             */
        public static void StartAuth(string Appkey,string Appsecert,string callbackURL){
            oauth = new NetDimension.Weibo.OAuth(Appkey ,Appsecert , callbackURL );
            string  url = oauth.GetAuthorizeURL( ResponseType.Code);//根据授权方法，获得授权地址。
            System.Diagnostics.Process.Start(url);//模拟弹窗，Console方式直接打开了浏览器，Web项目可以根据需求来使用iframe、新窗口等打开此页面。
            //打开浏览器，进行授权流程，之后会跳转到callback指定的网址，并获得code
        }
        
        public static  void  TakeAccess(string Code)
        {
              //根据code获取AccessToken
             accessToken = oauth.GetAccessTokenByAuthorizationCode(Code);//注意：callback指定的url必须一致
            //看看我们获得的access token
          
            //至此，我们已经获得了AccessToken
        }
          
          

    }
}
