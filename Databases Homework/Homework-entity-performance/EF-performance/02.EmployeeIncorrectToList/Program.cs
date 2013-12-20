using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;

class Program
{
    static void Main(string[] args)
    {
        TelerikAcademyEntities context = new TelerikAcademyEntities();
        GetEmployeeIncorrectToList(context);
        //GetEmployeeCorrectUseToList(context);
    }

    public static void GetEmployeeIncorrectToList(TelerikAcademyEntities dbContext)
    {
        var employee = dbContext.Employees.ToList()
                           .Select(x => x.Address).ToList()
                           .Select(t => t.Town).ToList()
                           .Where(n => n.Name.Equals("Sofia")).ToList();

        foreach (var item in employee)
        {
            Console.WriteLine(item.Name);
        }         
    }

    public static void GetEmployeeCorrectUseToList(TelerikAcademyEntities dbContext)
    {
        var employee = dbContext.Employees
                           .Select(x => x.Address)
                           .Select(t => t.Town)
                           .Where(n => n.Name.Equals("Sofia")).ToList();

        foreach (var item in employee)
        {
            Console.WriteLine(item.Name);
        }
    }
}

