using System;

namespace Abstraction
{
   public abstract class Figure
    {
        //Create methods
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            return "I am a ";
        }     
    }
}
