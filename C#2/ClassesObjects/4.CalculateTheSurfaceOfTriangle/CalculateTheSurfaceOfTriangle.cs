using System;
namespace _4.CalculateTheSurfaceOfTriangle
{
    class CalculateTheSurfaceOfTriangle
    {
        static double GetSurfaceTriangleBySideAltitde(double b, double h)
        {
            double area = (b/2)*h;
            Console.WriteLine(area);
            return area;
        }
        static double GetSurfaceTrianlgeByThreeSides(double a, double b, double c)
        {
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt (halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Console.WriteLine(area);
            return area;


        }
       static double GetSurfaceTriangleByTwoSidesAndAngle(double a, double b, double angle)
       {
           double area = (a * b * Math.Sin(angle))/2;
           Console.WriteLine(area);
           return area;
       }

        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            GetSurfaceTriangleBySideAltitde(b, h);
            double a = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c  = double.Parse(Console.ReadLine());
            GetSurfaceTrianlgeByThreeSides(a, b1, c);
            GetSurfaceTriangleByTwoSidesAndAngle(a, b1, c);
            

            
        }
    }
}
