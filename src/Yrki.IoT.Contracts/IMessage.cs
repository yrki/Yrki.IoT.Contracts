using System;

namespace Yrki.IoT.Contracts
{
    public interface IMessage
    {
        /// <summary>
        /// The date and time the message was received by the gateway. 
        /// If not set the server will set the date and time.
        /// For best accurancy, only use if the gateway has a clock that is synchronized with a NTP-server.
        /// </summary>
        DateTimeOffset? ReceivedAtGatewayDateTime { get; set; }

        /// <summary>
        /// The unique Id of the gateway
        /// </summary>
        string GatewayId { get; set; }
    }
}