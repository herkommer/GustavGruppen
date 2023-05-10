using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReturnHello
    {
        public static string GetHello (string name)
        {
            return $"Welcome to the world sir {name}!";
        }
    }
}
