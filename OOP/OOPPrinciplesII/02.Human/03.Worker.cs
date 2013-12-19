using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
   public class Worker :Human    // create class worker which is derived from human
    {
       public double weekSalary;       // define field
       public double workHoursPerDay;  // define field

       public Worker(double weekSalary, double workHoursPerDay, string FirstName, string LastName) // define a constructor
           : base(FirstName, LastName)   // call the constructor form a base class. If you don't call it and your base class does not 
                                        // contains constuructor by default (without parameters), then you'll get a compile error
       {
           this.WeekSalary = weekSalary;
           this.WorkHoursPerDay = workHoursPerDay;
       }

       public double WeekSalary     // define property for week salary
       {
           get { return this.weekSalary; }

           set {
               this.weekSalary = value;
               if (weekSalary < 0)    // check if salary is a negative number
               {
                   throw new ArgumentException("Week salary should not be a negative number!!");
               }    
           }
       }

       public double WorkHoursPerDay
       {
           get { return this.workHoursPerDay; }
           set
           {
               workHoursPerDay = value;
               if (workHoursPerDay < 0)   // check if salary is a negative number
               {
                   throw new ArgumentException("Work hours per day should not be a negative number!!");
               }      
           }
       }

       public double MoneyPerHour()   // create method to calculate money per hour. We suppose that the work days are 5
       {
           double result = weekSalary / (workHoursPerDay * 5);
           return result;
       }

       public override string ToString()   // Print info on the console
       {
           return string.Format("{0}" + "\n" + "Week salary: {1}" + "\n" + "Work hours per day: {2}" + "\n" + 
               "Earned money per hour: {3}" + "\n", base.ToString(), this.weekSalary, this.workHoursPerDay, MoneyPerHour());
       }
    }
}
