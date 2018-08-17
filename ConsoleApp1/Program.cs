using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 1;
            float pi = (float)Math.PI;
            float volume = (2 / 3f) * pi * (radius * radius * radius);
            Console.Write(volume);
            Console.ReadLine();
        }
    }
}
