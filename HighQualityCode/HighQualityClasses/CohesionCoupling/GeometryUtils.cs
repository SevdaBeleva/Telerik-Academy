using System;

namespace CohesionCoupling
{
   public static class GeometryUtils
    {
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }    
    }
}
