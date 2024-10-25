using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
namespace RaylibFun
{
    internal class Game
    {



        public void Run()
        {
            Raylib.InitWindow(640, 480, "Game Window");
            Raylib.SetTargetFPS(60);
             
            
            

            // Player

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);

                

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();







        }
    }
}
