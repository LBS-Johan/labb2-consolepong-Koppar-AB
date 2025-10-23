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

            if (x >= width - 5 || x <= 0 + 5)
            {
                x = 60;
                y = 10;
                
            }

            if (x == p1.x - 1)
            {
                if(y == p1.y || y == p1.y - 1 || y == p1.y - 2)
                {
                    xVelocity = xVelocity * -1;
                }
                
            }

            if (x == p2.x + 1)
            {
                if (y == p2.y || y == p2.y - 1 || y == p2.y - 2)
                {
                    xVelocity = xVelocity * -1;
                }

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
