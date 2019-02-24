using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 7;
            //int x = 25;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Turtle.Move(x);
            //        Turtle.TurnRight();
            //    }
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Turtle.Move(x);
            //        Turtle.TurnLeft();
            //    }
            //}

            double x = 90 / 1.5;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Move(100);
                Turtle.Turn(x);
            }
        }
    }
}
