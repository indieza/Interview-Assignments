namespace Facade.Elements;

public class Customer
{
    private readonly string name;

    public Customer(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}