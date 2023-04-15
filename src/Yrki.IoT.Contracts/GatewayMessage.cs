namespace Yrki.IoT.Contracts
{
    public class GatewayMessage : Message
    {
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}