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
        static void WriteT (int Size)
        {
            Turtle.Move(Size);
            Turtle.TurnLeft();
            Turtle.Move(Size/2);
            Turtle.Turn(180);
            Turtle.Move(Size);
        }

        static void WriteO(int c)
        {
            int r = 360;
            double Move = 0.5 / c;
            double x = 360 / r;
            for (int i = 0; i < (r / c); i++)
            {
                Turtle.Move(Move);
                Turtle.Turn(x);
            }
        }

        static void Position(int x)
        {
            Turtle.Angle = 0;
            double Word = 100 * x;
            Turtle.X = 50 + Word;
            Turtle.Y = 200;
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 8;

            Position(1);
            WriteT(100);

            Position(2);
            Turtle.TurnLeft();
            WriteO(1);

            Position(3);
            Turtle.Move(50);
            Turtle.TurnRight();
            WriteO(2);

            Position(4);
            WriteT(50);

            double p = (450 + 150) / 2;
            Turtle.X = p;
            Turtle.Y = 250;
            Turtle.Angle = 0;
        }
    }
}
