using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{
    public class NotificationEventArgs : EventArgs
    {
        public NotificationEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
