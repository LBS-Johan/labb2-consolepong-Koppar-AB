using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int x;
        int y;

        int xVelocity;
        int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;

            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }

        public void CheckCollision(Paddle p1, Paddle p2, int width, int height)
        {
            if (y >= height - 1 || y <= 0)
            {
                yVelocity = yVelocity * -1;
            }

            if (x >= width - 1 || x <= 0)
            {
                xVelocity = xVelocity * -1;
            }

            
        }

        public void Move()
        {
            x = x + xVelocity;
            y = y + yVelocity;
        }

        public void Draw()
        {
            Move();

            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }



    }
}
