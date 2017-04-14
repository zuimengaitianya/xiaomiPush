using Android.App;
using Android.Widget;
using Android.OS;
using CN.Jpush.Android.Api;
using System.Collections.Generic;

namespace Frog
{
    [Activity(Label = "Frog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            JPushInterface.SetDebugMode(true);
            JPushInterface.Init(ApplicationContext);

            ICollection<string> MyTags = null;//new ICollection<string> { "123" };

            //JPushInterface.SetAliasAndTags(ApplicationContext, "123123", MyTags);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

