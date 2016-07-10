using System;

namespace Store.Core.Infrastructure.Events
{
    public class LoginEvents
    {
        //1 - Define a delegate
        //2 - Define an event based on that deledegate
        //3 - Raise the event

        public delegate void UserLoginEventHandler(object source, EventArgs args);

        public event UserLoginEventHandler UserLoged;

        public virtual void OnUserLoged()
        {
            if (UserLoged != null)
                UserLoged(this, EventArgs.Empty);
        }
    }
}
