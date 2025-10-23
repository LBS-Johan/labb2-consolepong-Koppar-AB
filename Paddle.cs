using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        public int x;
        public int y;

        public int size;

        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;


            this.size = size;
        }

        public void Move (int yAmount, int height)
        {

            if (y + yAmount + size + 1 <= height && y + yAmount >= 0)
            {
                y = y + yAmount;
            }

                
            
        }

        public void Draw()
        {        
            for (int i = 1; i <= size; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
            }
        }


    }
}