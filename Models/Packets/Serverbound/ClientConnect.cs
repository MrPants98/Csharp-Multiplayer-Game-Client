namespace Csharp_Multiplayer_Game_Client.Models.Packets.Serverbound
{
    public class ClientConnect
    {
        public string username { get; set; }
        public UInt64 uuid { get; set; }
        public byte color { get; set; }
    }
}
