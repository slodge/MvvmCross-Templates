using Cirrious.MvvmCross.Plugins.Messenger;

namespace MyApplication.Core.Messages
{
    public class Message : MvxMessage
    {
        public Message(object sender) 
            : base(sender)
        {
        }
    }
}