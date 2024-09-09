using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square
    {
        private Point[][] _points;
        
        public Square(int size, char sym, int x, int y)
        {
            _points = new Point[size][];
            for (int i = 0; i < size; i++)
            {
                _points[i] = new Point[size];
                for (int j = 0; j < size; j++)
                {
                    _points[i][j] = new Point(x+i, y+j, sym);
                }
            }
        }
        
        public void Draw()
        {
            for (int i = 0; i < _points[0].Length; i++)
            {
                for (int j = 0; j < _points[0].Length; j++)
                {
                    _points[i][j].Draw();
                }
            }
        }
    }
}
