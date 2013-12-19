using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class DistanceBetweenTwoPoints
    {
        public double GetDistance(StructPoint3D point1, StructPoint3D point2)
        {
            double result = 0;
            result = Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2) + Math.Pow(point1.z - point2.z, 2));
            return result;
        }
        
    }
}
