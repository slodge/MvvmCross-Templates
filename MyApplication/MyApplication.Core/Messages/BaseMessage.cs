using Cirrious.MvvmCross.Plugins.Messenger;

namespace MyApplication.Core.Messages
{
    public class BaseMessage : MvxMessage
    {
        public BaseMessage(object sender) 
            : base(sender)
        {
        }
    }
}