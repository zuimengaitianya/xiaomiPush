using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using CN.Jpush.Android.Api;
using System.Threading.Tasks;

namespace Frog
{
    public class RegisrationHandler : BaseHandler
    {
        public override string Action
        {
            get
            {
                return "cn.jpush.android.intent.REGISTRATION";
            }
        }

        public override void Handle(Bundle bundle)
        {
            //SDK 向 JPush Server 注册所得到的注册 全局唯一的 ID ，可以通过此 ID 向对应的客户端发送消息和通知。
            var id = bundle.GetString(JPushInterface.ExtraRegistrationId);
        }
    }
}