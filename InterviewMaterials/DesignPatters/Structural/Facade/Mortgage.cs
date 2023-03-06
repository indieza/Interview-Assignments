using Facade.Elements;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class Mortgage
{
    private readonly Bank bank = new();
    private readonly Loan loan = new();
    private readonly Credit credit = new();

    public bool IsEligible(Customer cust, int amount)
    {
        Console.WriteLine($"{cust.Name} applies for {amount:C} loan\n");
        bool eligible = true;

        if (!this.bank.HasSufficientSavings(cust, amount))
        {
            eligible = false;
        }
        else if (!this.loan.HasNoBadLoans(cust))
        {
            eligible = false;
        }
        else if (!this.credit.HasGoodCredit(cust))
        {
            eligible = false;
        }

        return eligible;
    }
}