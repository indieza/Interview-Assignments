using Facade.Elements;

namespace Facade;

public class StartUp
{
    private static void Main()
    {
        Mortgage mortgage = new();
        Customer customer = new("Ann McKinsey");
        bool eligible = mortgage.IsEligible(customer, 125000);
        Console.WriteLine($"\n{customer.Name} has been {(eligible ? "Approved" : "Rejected")}");
    }
}