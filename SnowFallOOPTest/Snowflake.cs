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

        public int X
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _x = value;
                }
                else
                {
                    throw new Exception("вышло за пределы знания");
                }
            }
            get
            {
                return _x;
            }
        }

        public int Y
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _y = value;
                }
                else
                {
                    throw new Exception("вышло за пределы знания");
                }
            }
            get
            {
                return _y;
            }
        }




    }
}
