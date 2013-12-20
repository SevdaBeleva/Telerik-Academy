using System;
using System.Text;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        //Create fields
        private double width;
        private double height;
        
        //Create constructors
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //Override properties with an encapsulation
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be a positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive number!");
                }
                this.height = value;
            }
        }
        
        //Override methods for rectanlge
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }

        //Print information about rectangle
        public override string ToString()
        {
            StringBuilder buildRectangle = new StringBuilder();
            buildRectangle.AppendFormat(base.ToString() + this.GetType().Name + "\n");
            buildRectangle.AppendFormat("My perimeter is: {0}", CalcPerimeter() + "\n");
            buildRectangle.AppendFormat("My surface is: {0}", CalcSurface());

            return buildRectangle.ToString();
        }
    }
}
