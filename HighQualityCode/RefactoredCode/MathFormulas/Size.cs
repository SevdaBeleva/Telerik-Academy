using System;

namespace MathFormulas
{
   public class Size
    {
       private double Width { get; set; }
       private double Height { get; set; }

       public Size(double width, double height)
       {
           this.Width = width;
           this.Height = height;
       }

       public Size()
       {

       }

       public Size GetRotatedSize(Size size, double angleOfRotation )
       {
           double widthCosSize = Math.Abs(Math.Cos(angleOfRotation)) * size.Width;
           double widthSinSize = Math.Abs(Math.Sin(angleOfRotation)) * size.Height;
           double heightCosSize = Math.Abs(Math.Sin(angleOfRotation)) * size.Width;
           double heightSinSize = Math.Abs(Math.Cos(angleOfRotation)) * size.Height;
           double fullWidth = widthCosSize + widthSinSize;
           double fullHeight = heightCosSize + heightSinSize;
           Size rotatedSize = new Size(fullWidth, fullHeight);
          
           return rotatedSize;
       }
    }
}
