using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle p1;
        Paddle p2;

        Ball ball;

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            p1 = new Paddle(110,10,3);
            p2 = new Paddle(10, 10,3);

            ball = new Ball(60, 10, 1, 1);

        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            p1.Draw();
            p2.Draw();

            ball.CheckCollision(p1, p2, width, height);
            ball.Draw();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                
                p1.Move(-1, height);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                p1.Move(1, height);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                p2.Move(-1, height);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                p2.Move(1, height);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
