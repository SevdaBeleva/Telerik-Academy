using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Data;
using System.Transactions;

public class Program
{
    public static NorthwindEntities dbContext = new NorthwindEntities();

    static void Main(string[] args)
    {
        
       //DAO.InsertCustomer("NEV", "samara", "asq");
       //DAO.ModifyingCustomer( "NEV", "elena", "raq");
       //DAO.DeleteCustomer("NEV");

        //FindCustomerByOrder(1997, "Canada");
        //FindCustomerByOrderNativeSQL(1997, "Canada");

        FindAllSalesByRegionPeriod("04-12-96", "12-12-98", "NULL" );

        using (TransactionScope scope = new TransactionScope())
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                MakeNewOrder("OFFSET", "very secret order", null, null, null, null, null, null, null, null, null, null, null);
            }
            scope.Complete();
        }
    }

    //task 3: Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
    public static void FindCustomerByOrder(int shippedYear, string shipCountry)
    {
        using(dbContext)
        {
            var customerOrder = dbContext.Orders
                                .Where(x => x.OrderDate.Value.Year == shippedYear && x.ShipCountry == shipCountry)
                                .Select(x => x.CustomerID ).Distinct();
          
            foreach(var c in customerOrder)
             {
                 Console.WriteLine(c);
             }
        }
    }

    // task 4: Implement previous by using native SQL query and executing it through the DbContext.
    public static void FindCustomerByOrderNativeSQL(int shippYear, string shipCountry)
    {
        using (dbContext)
        {
            var sql =
                 "SELECT c.CustomerID " +
                 "FROM Customers c " +
                 "JOIN Orders o " +
                 "On c.CustomerID = o.CustomerID " +
                 "WHERE YEAR(o.OrderDate) = {0} " + 
                 "AND o.ShipCountry = {1} "  +
                 "group by c.CustomerID";

            object[] param = { shippYear, shipCountry };
            var customer = dbContext.Database.SqlQuery<string>(sql, param);

            foreach (var c in customer)
            {
                Console.WriteLine(c);
            }
        }
    }

    //task 5: Write a method that finds all the sales by specified region and period (start / end dates).
    public static void FindAllSalesByRegionPeriod(string startDate, string endDate, string region)
    {
        using (dbContext)
        {
            DateTime startDateParsed = DateTime.Parse(startDate);
            DateTime endDateParsed = DateTime.Parse(endDate);

            var sales = dbContext.Orders.Where(x => x.ShipRegion.Equals(region) || x.ShipRegion == null)
                        .Where(x => x.ShippedDate >= startDateParsed && x.ShippedDate <= endDateParsed)
                        .Select(x => x.ShipName).Distinct();
               
            foreach (var sale in sales)
            {
                Console.WriteLine(sale);
            }
        }
    }

    //task 9: Create a method that places a new order in the Northwind database. 
    //The order should contain several order items. Use transaction to ensure the data consistency.
    public static void MakeNewOrder(string shipName, string shipAddress,
        string shipCity, string shipRegionm,
        string shipPostalCode, string shipCountry,
        string customerID = null, int? employeeID = null,
        DateTime? orderDate = null, DateTime? requiredDate = null,
        DateTime? shippedDate = null, int? shipVia = null,
        decimal? freight = null)
    {
        using (NorthwindEntities context = new NorthwindEntities())
        {
            Order newOrder = new Order
            {
                ShipAddress = shipAddress,
                ShipCity = shipCity,
                ShipCountry = shipCountry,
                ShipName = shipName,
                ShippedDate = shippedDate,
                ShipPostalCode = shipPostalCode,
                ShipRegion = shipRegionm,
                ShipVia = shipVia,
                EmployeeID = employeeID,
                OrderDate = orderDate,
                RequiredDate = requiredDate,
                Freight = freight,
                CustomerID = customerID
            };

            context.Orders.Add(newOrder);
            context.SaveChanges();    
        }
    }
}


