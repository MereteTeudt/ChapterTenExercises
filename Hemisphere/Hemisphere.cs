using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemisphere
{
    class Hemisphere
    {
        private float radius;
        private double volume;
        private double curvedSurfaceArea;
        private double totalSurfaceArea;

        public Hemisphere(float radius = 1)
        {
            Radius = radius;
        }
        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0.0 && value > 12.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Radius)} must be 0.0 - 12.0");
                }
                radius = value;
            }
        }
        public double CurvedSurfaceArea
        {
            get
            {
                return 2 * Math.PI * (Radius * Radius);
            }
        }
        
        public double TotalSurfaceArea
        {
            get
            {
                return 3 * Math.PI * (Radius * Radius);
            }
        }
        
        public double Volume
        {
            get
            {
                return 3 / 4 * Math.PI * (Radius * Radius * Radius);
            }
        }
    }
}
