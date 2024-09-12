using Raylib_cs;
using System.Net.WebSockets;

namespace Csharp_Multiplayer_Game_Client
{
    internal class Program
    {

        public static ClientWebSocket clientSocket = new ClientWebSocket();

        static void Main(string[] args)
        {
            //Raylib.InitWindow(1280, 720, "Multiplayer Game");
            ServerClientCommunication.InitClient("ws://localhost:8080");

            /*while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();*/

            Console.ReadLine();
        }
    }
}
