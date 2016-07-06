using Store.Core.Contracts;
using System;
using Store.Core.Models.Common;

namespace Store.Core.Models
{
    public abstract class Decorator : IUser
    {
        protected IUser user;

        protected Decorator(IUser setUser)
        {
            this.user = setUser;
        }

        public void AddItem(Item item)
        {
            user.AddItem(item);
        }

        public void RemoveItem(Item item)
        {
            user.RemoveItem(item);
        }
    }
}
