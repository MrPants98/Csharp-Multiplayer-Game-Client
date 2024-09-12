using Csharp_Multiplayer_Game_Client.Models.Packets.Serverbound;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Csharp_Multiplayer_Game_Client
{
    public class ServerClientCommunication
    {
        public static async void InitClient(string uri)
        {
            await ConnectToServerAsync(uri);
            await SendPacket(0x00, JsonSerializer.Serialize(new ClientConnect { username = "Sigma", uuid = 0, color = 2 })); 
        }

        private static async Task ConnectToServerAsync(string uri)
        {
            await Program.clientSocket.ConnectAsync(new Uri(uri), CancellationToken.None);
            Console.WriteLine("Connected To Server");
        }

        public static async Task SendPacket(byte packetID, string packetDataJSON)
        {
            await Task.Run(async () =>
            {
                byte[] packetDataBuffer = Encoding.UTF8.GetBytes(packetDataJSON);

                byte[] buffer = new byte[1 + packetDataBuffer.Length];
                buffer[0] = packetID;
                Array.Copy(packetDataBuffer, 0, buffer, 1, packetDataBuffer.Length);

                await Program.clientSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            });
        }
    }
}
