using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnowFallOOPTest
{
    internal class SnowflakesManager
    {
        private Snowflake[] snowflakes = null;
        private Random rnd = new Random();

        public SnowflakesManager(int count)
        {
            snowflakes = new Snowflake[count];
            RandomSnowflakes();
        }

        public void RunSnowFall()
        {
            while (true)
            {
                Console.Clear();

                DrawSnowflakes();

                Thread.Sleep(100);

                FallSnowflakes();
            }
        }

        private void RandomSnowflakes()
        {
            for (int i = 0; i < snowflakes.Length; i++)
            {
                int x = rnd.Next(1, Console.WindowWidth - 1);
                int y = rnd.Next(1, Console.WindowHeight - 1);
                ConsoleColor color = (ConsoleColor)rnd.Next(1, 15 + 1);
                snowflakes[i] = new Snowflake(x, y, color);
            }
        }

        private void DrawSnowflakes()
        {
            for (int i = 0; i < snowflakes.Length; i++)
            {
                snowflakes[i].Draw();
            }
        }

        private void FallSnowflakes()
        {
            for (int i = 0; i < snowflakes.Length; i++)
            {
                snowflakes[i].Fall();

                if (snowflakes[i].Y > Console.WindowHeight - 1)
                {
                    snowflakes[i].Y = 1;
                }
            }
        }
    }
}
