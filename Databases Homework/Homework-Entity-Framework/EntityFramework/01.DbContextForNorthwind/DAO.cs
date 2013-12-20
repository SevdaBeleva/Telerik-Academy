using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Data;

public class DAO
{
    //create a field which holds database connection with Northwind and entity classes
    public static NorthwindEntities dbContext = new NorthwindEntities();

    public static void InsertCustomer(string customerID, string companyName, string contactName)
    {
        using(dbContext)
        {
            var newCustomer = new Customer()
            {
                CustomerID = customerID,
                CompanyName = companyName,
                ContactName = contactName
            };

            //dbContext.Customers.Attach(newCustomer);
            dbContext.Customers.Add(newCustomer);
            dbContext.SaveChanges();
        }
    }

    public static void ModifyingCustomer(string customerId, string companyName, string contactName)
    {
        using(dbContext)
        {
            var customer = dbContext.Customers.Find(customerId);
            {
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                dbContext.SaveChanges();
            };
        }
    }

    public static void DeleteCustomer(string customerId)
    {
        using (dbContext)
        {
            var customer = dbContext.Customers.Find(customerId);
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();

        }
    }
}

