using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowFallOOPTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snowflake snowflake = new Snowflake();
            snowflake.SetX(2);
            Console.WriteLine(snowflake.GetX());

            snowflake.X = 3;
            Console.WriteLine(snowflake.X);

            Console.ReadKey();
        }
    }
}
