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

using CN.Jpush.Android.Service;

namespace Frog
{
    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new string[] { "cn.jpush.android.intent.REGISTRATION" }, Categories = new string[] { "com.Frog" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.UNREGISTRATION" }, Categories = new string[] { "com.Frog" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.MESSAGE_RECEIVED" }, Categories = new string[] { "com.Frog" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_RECEIVED" }, Categories = new string[] { "com.Frog" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_OPENED" }, Categories = new string[] { "com.Frog" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.ACTION_RICHPUSH_CALLBACK" }, Categories = new string[] { "com.Frog" })]

    //[IntentFilter(new string[] {
    //    "cn.jpush.android.intent.REGISTRATION",
    //    "cn.jpush.android.intent.UNREGISTRATION" ,
    //    "cn.jpush.android.intent.MESSAGE_RECEIVED",
    //    "cn.jpush.android.intent.NOTIFICATION_RECEIVED",
    //    "cn.jpush.android.intent.NOTIFICATION_OPENED",
    //    "cn.jpush.android.intent.ACTION_RICHPUSH_CALLBACK",
    //    "cn.jpush.android.intent.CONNECTION"
    //}, Categories = new string[] { "com.Frog" })]

    public class JPushReceiver : PushReceiver
    {
        public async override void OnReceive(Context ctx, Intent ite)
        {
			//在这里处理各种消息类型
			base.OnReceive(ctx, ite);

            var action = ite.Action;
            System.Diagnostics.Debug.WriteLine(action);

            var bundle = ite.Extras;
            await ReceiverHandler.Handle(ite.Action, bundle);

        }
    }
}