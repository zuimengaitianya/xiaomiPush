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
using Com.Xiaomi.Mipush.Sdk;
using Android.Text;

namespace AndroidFrog
{
    public class DemoMessageReceiver : PushMessageReceiver
    {
        private string mRegId;
        private string mTopic;
        private string mAlias;
        private string mAccount;
        private string mStartTime;
        private string mEndTime;

        public override void OnReceivePassThroughMessage(Context context, MiPushMessage message)
        {
            if (!TextUtils.IsEmpty(message.Topic))
            {
                mTopic = message.Topic;
            }
            else if (!TextUtils.IsEmpty(message.Alias))
            {
                mAlias = message.Alias;
            }
        }

        public override void OnNotificationMessageClicked(Context context, MiPushMessage message)
        {
            if (!TextUtils.IsEmpty(message.Topic))
            {
                mTopic = message.Topic;
            }
            else if (!TextUtils.IsEmpty(message.Alias))
            {
                mAlias = message.Alias;
            }
        }

        public override void OnNotificationMessageArrived(Context context, MiPushMessage message)
        {
            if (!TextUtils.IsEmpty(message.Topic))
            {
                mTopic = message.Topic;
            }
            else if (!TextUtils.IsEmpty(message.Alias))
            {
                mAlias = message.Alias;
            }
        }

        // 用来接收客户端向服务器发送命令消息后返回的响应  
        public override void OnCommandResult(Context context, MiPushCommandMessage message)
        {
            string command = message.Command;
            IList<string> arguments = message.CommandArguments;
            string cmdArg1 = ((arguments != null && arguments.Count() > 0) ? arguments[0] : null);
            string cmdArg2 = ((arguments != null && arguments.Count() > 1) ? arguments[1] : null);
            string log;
            if (MiPushClient.CommandRegister.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mRegId = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandSetAlias.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mAlias = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandUnsetAlias.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mAlias = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandSetAccount.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mAccount = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandUnsetAccount.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mAccount = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandSubscribeTopic.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mTopic = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandUnsubscribeTopic.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mTopic = cmdArg1;
                }
                else
                {
                }
            }
            else if (MiPushClient.CommandSetAcceptTime.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mStartTime = cmdArg1;
                    mEndTime = cmdArg2;
                }
                else
                {
                }
            }
            else
            {
                log = message.Reason;
            }
        }

        public override void OnReceiveRegisterResult(Context context, MiPushCommandMessage message)
        {
            string command = message.Command;
            IList<string> arguments = message.CommandArguments;
            string cmdArg1 = ((arguments != null && arguments.Count() > 0) ? arguments[0] : null);
            string log;
            if (MiPushClient.CommandRegister.Equals(command))
            {
                if (message.ResultCode == ErrorCode.Success)
                {
                    mRegId = cmdArg1;
                }
                else
                {
                }
            }
            else
            {
                log = message.Reason;
            }
        }
    }
}