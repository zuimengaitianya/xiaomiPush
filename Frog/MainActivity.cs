using Android.App;
using Android.Widget;
using Android.OS;
using CN.Jpush.Android.Api;
using System.Collections.Generic;
//using Xamarin.Forms.Platform.Android;

namespace Frog
{
    [Activity(Label = "密信", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static ICollection<string> MyTags = null;//new List<string> { "123" };
        public static string myAlias = "565009871";
        public static Android.Content.Context appContext = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //global::Xamarin.Forms.Forms.Init(this, bundle);

            //LoadApplication(new App(IoC.Get<SimpleContainer>()));

            JPushInterface.SetDebugMode(true);
            JPushInterface.Init(ApplicationContext);

            appContext = ApplicationContext;

            //MyTags.Add("123");
            new JPushInterface().SetAliasAndTags(appContext, myAlias, MyTags);
            // Set our view from the "main" layout resource
            //SetContentView (Resource.Layout.Main);
        }
        

        protected override void OnResume()
        {
            base.OnResume();

            JPushInterface.OnResume(this);
        }

        protected override void OnPause()
        {
            base.OnPause();

            JPushInterface.OnPause(this);
        }

    }
}

