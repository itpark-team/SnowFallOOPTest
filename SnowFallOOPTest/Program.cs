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
            SnowflakesManager snowflakesManager = new SnowflakesManager(50);
            snowflakesManager.RunSnowFall();
        }
    }
}
