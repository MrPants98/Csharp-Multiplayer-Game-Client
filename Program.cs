using Raylib_cs;

namespace Csharp_Multiplayer_Game_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1280, 720, "Multiplayer Game");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
