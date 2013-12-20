using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;


public class Program
{
    static void Main(string[] args)
    {
        TelerikAcademyEntities context = new TelerikAcademyEntities();
        //GetEmployeesInfoWithQueryProblem(context);
       GetEmployeesInfoWithoutQueryProblem(context);
      
    }

    public static void GetEmployeesInfoWithQueryProblem(TelerikAcademyEntities dbContext)
    {
        using (dbContext)
        {
            foreach(var employee in dbContext.Employees)
            {
                Console.WriteLine("{0} {1} {2}", employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
        }
    }

    public static void GetEmployeesInfoWithoutQueryProblem(TelerikAcademyEntities dbContext)
    {
        using (dbContext)
        {
            foreach (var employee in dbContext.Employees.Include("Department").Include("Address.Town"))
            {
                Console.WriteLine("{0} {1} {2}", employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
        }
    }
}

