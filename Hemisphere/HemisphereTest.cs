using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemisphere
{
    class HemisphereTest
    {
        static void Main(string[] args)
        {
            Hemisphere hem = new Hemisphere();
            Console.WriteLine(hem.CurvedSurfaceArea);
            Console.WriteLine(hem.TotalSurfaceArea);
            Console.WriteLine(hem.Volume);
            Console.ReadLine();
        }
    }
}
