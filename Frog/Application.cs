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
using Android.Content.PM;

//[assembly: Permission(Name = Frog.Application.JPUSH_MESSAGE_PERMISSION, ProtectionLevel = Protection.Signature)]
//[assembly: UsesPermission(Name = Frog.Application.JPUSH_MESSAGE_PERMISSION)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.Internet)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.WakeLock)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.Vibrate)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.ReadPhoneState)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.WriteExternalStorage)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.ReadExternalStorage)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.MountUnmountFilesystems)]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.AccessNetworkState)]
//[assembly: UsesPermission(Name = "android.permission.RECEIVE_USER_PRESENT")]
//[assembly: UsesPermission(Name = Android.Manifest.Permission.WriteSettings)]
//namespace Frog
//{
//    [Application]
//    [MetaData("JPUSH_CHANNEL", Value = "developer-default")]
//    [MetaData("JPUSH_APPKEY", Value = "c8cec26a4856608723db2eaa")]
//    public class Application : Android.App.Application
//    {
//        //notification.Droid 即 Android 项目的 Package name
//        public const string JPUSH_MESSAGE_PERMISSION = "Frog.permission.JPUSH_MESSAGE";


//        //private SimpleContainer container;

//        public Application(IntPtr javaReference, JniHandleOwnership transfer)
//             : base(javaReference, transfer)
//        {
//        }
//    }
//}