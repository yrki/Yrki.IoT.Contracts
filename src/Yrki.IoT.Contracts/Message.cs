using System;

namespace Yrki.IoT.Contracts
{
    public class Message : IMessage
    {
        public DateTimeOffset? ReceivedAtGatewayDateTime { get; set; }

        public string GatewayId { get; set; }
    }
}