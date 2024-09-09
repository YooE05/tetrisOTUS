using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point(4,4,'d');
            p1.Draw();

            Square s1 = new Square(4, '*', 10, 5);
            s1.Draw();

            Console.ReadLine();
        }
    }
}
