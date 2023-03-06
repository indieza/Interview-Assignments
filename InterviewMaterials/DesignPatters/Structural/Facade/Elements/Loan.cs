namespace Facade.Elements;

public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
        Console.WriteLine($"Check loans for {c.Name}");
        return true;
    }
}