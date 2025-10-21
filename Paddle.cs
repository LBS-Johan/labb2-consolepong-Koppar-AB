﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        int x;
        int y;

        int size;

        public Paddle(int x, int y) //int size
        {
            this.x = x;
            this.y = y;


            //this.size = size;
        }

        public void Move (int yAmount, int height)
        {

            if (y + yAmount <= height && y + yAmount > 0)
            {
                y = y + yAmount;
            }

                
            
        }

        public void Draw()
        {

            Console.SetCursorPosition(x, y - 1);
            Console.Write("|");
            
        }


    }
}
