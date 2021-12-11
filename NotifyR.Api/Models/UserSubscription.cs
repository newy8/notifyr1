using System.Collections.Generic;

namespace NotifyR.Api.Models
{
    internal class UserSubscription
    {
        public string Id { get; set; }

        public string EmailAddress { get; set; }

        public List<WebPushSubscription> WebPushSubscriptions { get; set; }
    }
}
