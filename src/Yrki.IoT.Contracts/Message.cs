using System;

namespace Yrki.IoT.Contracts
{
    public class Message : IMessage
    {
        
        public DateTimeOffset? ReceivedAt { get; set; }

        public string GatewayId { get; set; }
    }
}