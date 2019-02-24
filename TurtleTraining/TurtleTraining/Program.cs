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
            Turtle.Speed = 5;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Turtle.Move(50);
                    Turtle.TurnRight();
                }
                for (int j = 0; j < 2; j++)
                {
                    Turtle.Move(50);
                    Turtle.TurnLeft();
                }
            }

        }
    }
}
