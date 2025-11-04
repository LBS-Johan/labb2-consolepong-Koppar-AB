using System;
using System.Collections.Generic;
using System.Drawing;
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

        int p1Score;

        int p2Score;

        Random rand = new Random();

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;

            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;


            int direction = rand.Next(0, 3); //Kinda random direction at start
            if (direction == 0)
            {
                this.xVelocity = xVelocity * -1;
            }
            else if (direction == 1)
            {
                this.yVelocity = yVelocity * -1;
            }
        }

        public void CheckCollision(Paddle p1, Paddle p2, int width, int height, int size1, int size2)
        {
            if (y >= height - 1 || y <= 0)
            {
                yVelocity = yVelocity * -1;
            }

            if (x >= width - 5) //p2 loses
            {
                x = 60;
                y = 10;

                p1Score++;

            }

            if (x <= 0 + 5) //p1 loses
            {
                x = 60;
                y = 10;

                p2Score++;
            }


            if (x == p1.x - 1) // Collision on p1
            {
                for (int i = 0; i <= size1; i++)
                {
                    if (y == p1.y + i)
                    {
                        xVelocity = xVelocity * -1;

                    }
                }

            }

            if (x == p2.x + 1) // Collision on p2
            {
                for (int i = 0; i <= size1; i++)
                {
                    if (y == p2.y + i)
                    {
                        xVelocity = xVelocity * -1;

                    }
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
            

            Console.SetCursorPosition(5, 1);   // draws p1 score
            Console.Write(p1Score);

            Console.SetCursorPosition(115, 1); // draws p2 score
            Console.Write(p2Score);
        }



    }
}
