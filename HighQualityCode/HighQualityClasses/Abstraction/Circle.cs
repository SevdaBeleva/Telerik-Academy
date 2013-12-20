using System;
using System.Text;

namespace Abstraction
{
   public class Circle : Figure
    {
        private double radius;

        //Create constructors
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        //Create properties with encapsulation
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radis must be a positive number!");
                }

                this.radius = value;
            }
        }

        //Create methods for circle
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }

        //Print information about circle
        public override string ToString()
        {
            StringBuilder buildCircle = new StringBuilder();
            buildCircle.AppendFormat(base.ToString() + this.GetType().Name + "\n");
            buildCircle.AppendFormat("My perimeter is: {0}", CalcPerimeter() + "\n");
            buildCircle.AppendFormat("My sufarce is: {0}", CalcSurface());

            return buildCircle.ToString();
        }
    }
}
