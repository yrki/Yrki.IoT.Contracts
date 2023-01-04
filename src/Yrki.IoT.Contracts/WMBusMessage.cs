namespace Yrki.IoT.Contracts
{
    public class WMBusMessage : Message
    {
        /// <summary>
        /// The hex message as received from the gateway
        /// </summary>
        public string HexMessage { get; set; }
        
    }
}