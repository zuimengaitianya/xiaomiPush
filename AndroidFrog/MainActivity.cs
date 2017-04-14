using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Com.Xiaomi.Mipush.Sdk;
using Android.Text;
using Android.Content;
using static Android.App.ActivityManager;

namespace AndroidFrog
{
    [Activity(Label = "AndroidFrog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        // user your appid the key.  
        private static string APP_ID = "2882303761517520746";
        // user your appid the key.  
        private static string APP_KEY = "5731752028746";

        // 此TAG在adb logcat中检索自己所需要的信息， 只需在命令行终端输入 adb logcat | grep  
        // com.xiaomi.mipushdemo  
        public static string TAG = "com.AndroidFrog";

        private static DemoHandler sHandler = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // 注册push服务，注册成功后会向DemoMessageReceiver发送广播  
            // 可以从DemoMessageReceiver的onCommandResult方法中MiPushCommandMessage对象参数中获取注册信息  
            if (shouldInit())
            {
                MiPushClient.RegisterPush(this, APP_ID, APP_KEY);
            }
            if (sHandler == null)
            {
                sHandler = new DemoHandler(this);
            }
            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
        }

        private bool shouldInit()
        {
            ActivityManager am = ((ActivityManager)GetSystemService(ActivityService));
            IList<RunningAppProcessInfo> processInfos = am.RunningAppProcesses;
            string mainProcessName = PackageName;
            int myPid = Android.OS.Process.MyPid();
            foreach (RunningAppProcessInfo info in processInfos)
            {
                if (info.Pid == myPid && mainProcessName.Equals(info.ProcessName))
                {
                    return true;
                }
            }
            return false;
        }
        public static DemoHandler getHandler()
        {
            return sHandler;
        }

        public class DemoHandler : Handler
        {
            private Context context;
            public DemoHandler(Context context)
            {
                this.context = context;
            }
            public override void HandleMessage(Message msg)
            {
                string s = (string)msg.Obj;
                if (!TextUtils.IsEmpty(s))
                {
                    Toast.MakeText(context, s, ToastLength.Long).Show();
                }
            }
        }
    }
}

