using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM_Entities;
using System.Transactions;
using System.Data.SqlClient;

public class Program
{
    //Put your server instance in the connection string in App.Config file
    static void Main(string[] args)
    {
        RetrieveMoney("1000000001", "4400", 234m);
    }

    public static void RetrieveMoney(string cardNumber, string cardPin, decimal amount)
    {
        ATMEntities dbContext = new ATMEntities();

        var scope = new TransactionScope( 
                TransactionScopeOption.RequiresNew, 
                new TransactionOptions()
                {
                    IsolationLevel = IsolationLevel.RepeatableRead
                }
            );

        using (scope)
        {
            using (dbContext)
            {
               var account = (from a in dbContext.CardAccounts
                                   where a.CardNnumber == cardNumber && a.CardPin == cardPin
                                   select a).First();

                    if (account != null || ((account.CardCash > 0) && (account.CardCash > amount)))
                    {
                        account.CardCash = account.CardCash - amount;   
                    }

                    else
                    {
                        Console.WriteLine("Not enough money in your account");         
                    }

                    dbContext.SaveChanges();
                    scope.Complete();     
            }
        }
    }
}

