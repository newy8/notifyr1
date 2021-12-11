namespace NotifyR.Api.Models
{
    internal class WebPushSubscription
    {
        public string Endpoint { get; set; }

        public string ExpirationTime { get; set; }

        public Keys Keys { get; set; }
    }

    internal class Keys
    {
        public string P256DH { get; set; }

        public string Auth { get; set; }
    }
}
