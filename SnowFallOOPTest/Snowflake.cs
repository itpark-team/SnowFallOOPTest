using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowFallOOPTest
{
    internal class Snowflake
    {
        private int _x;
        private int _y;
        private ConsoleColor _color;

        public Snowflake(int x, int y, ConsoleColor color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public int Y
        {
            set 
            {
                _y = value;
            }
            get
            {
                return _y;
            }
        }

        public void Fall()
        {
            _y++;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.ForegroundColor = _color;
            Console.Write("*");
        }
    }
}
