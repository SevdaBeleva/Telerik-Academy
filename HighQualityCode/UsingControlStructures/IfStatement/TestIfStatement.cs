using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
   public class TestIfStatement
    {
       private static void Main(string[] args)
       {
           CheckIfVisited(1, 23, true);
       }

       public static void CheckIfVisited(double x, double y, bool goVisit)
       {
           //create constant variables so don't need to ask for them 
           const double minX = 0;
           const double maxX = 100;
           const double minY = 0;
           const double maxY = 100;
           bool xIsInRange = minX <= x && x <= maxX;
           bool yIsInRange = minY <= y && y <= maxY;

           if ((xIsInRange && yIsInRange) && goVisit)
           {
               VisitCell();
           }
           else
           {
               Console.WriteLine("Invalid range: min value for x, y = 0; max value for x,y = 100");     
           }
       }

       public static void VisitCell()
       {
           //..
       }
    }
            
}
